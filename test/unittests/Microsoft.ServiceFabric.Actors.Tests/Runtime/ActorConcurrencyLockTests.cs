// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Tests.Runtime
{
    using System;
    using System.Fabric;
    using System.Numerics;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Microsoft.ServiceFabric.Actors;
    using Microsoft.ServiceFabric.Actors.Runtime;
    using Microsoft.ServiceFabric.Actors.Throttling;
    using Moq;
    using Xunit;

    /// <summary>
    /// Class containing tests for ActorConcurrencyLock.
    /// </summary>
    public class ActorConcurrencyLockTests
    {
        private static string currentContext = Guid.Empty.ToString();

        private delegate Task<bool> DirtyCallback(Actor actor);

        /// <summary>
        /// Interface for DummyActor used for tests.
        /// </summary>
        private interface IDummyActor : IActor
        {
            /// <summary>
            /// Actor Method for test.
            /// </summary>
            /// <returns>Task with the result.</returns>
            Task<string> Greetings();
        }

        /// <summary>
        /// Verifies usage of ReentrancyGuard.
        /// </summary>
        [Fact]
        public void VerifyReentrants()
        {
            var a = new DummyActor();
            var guard = this.CreateAndInitializeReentrancyGuard(a, ActorReentrancyMode.LogicalCallContext);

            var tasks = new Task[1];
            for (var i = 0; i < 1; ++i)
            {
                tasks[i] = Task.Run(() =>
                {
                    RunTest(guard);
                });
            }

            Task.WaitAll(tasks);
        }

        /// <summary>
        /// VerifyDirtyCallbacks test.
        /// </summary>
        [Fact]
        public void VerifyDirtyCallbacks()
        {
            var actor = new DummyActor();
            var guard = this.CreateAndInitializeReentrancyGuard(actor, ActorReentrancyMode.LogicalCallContext);
            actor.IsDirty = true;
            var callContext = Guid.NewGuid().ToString();
            var result = guard.Acquire(callContext, @base => ReplacementHandler(actor), CancellationToken.None);
            try
            {
                result.Wait();
                actor.IsDirty.Should().BeFalse("ReentrancyGuard IsDirty should be set to false");
            }
            finally
            {
                guard.ReleaseContext(callContext).Wait();
            }

            RunTest(guard);
        }

        /// <summary>
        /// Tests Releasing context with a different call context.
        /// </summary>
        [Fact]
        public void VerifyInvalidContextRelease()
        {
            var actor = new DummyActor();
            var guard = this.CreateAndInitializeReentrancyGuard(actor, ActorReentrancyMode.LogicalCallContext);
            var context = Guid.NewGuid().ToString();
            guard.Acquire(context, null, CancellationToken.None).Wait();
            guard.Test_CurrentContext.Should().Be(context);
            guard.Test_CurrentCount.Should().Be(1);

            Action action = () => guard.ReleaseContext(Guid.NewGuid().ToString()).Wait();
            action.Should().Throw<AggregateException>();

            guard.ReleaseContext(context).Wait();
            guard.Test_CurrentContext.Should().NotBe(context);
            guard.Test_CurrentCount.Should().Be(0);
        }

        /// <summary>
        /// Tests ActorReentrancyMode.Disallowed
        /// </summary>
        [Fact]
        public void ReentrancyDisallowedTest()
        {
            var actor = new DummyActor();
            var guard = this.CreateAndInitializeReentrancyGuard(actor, ActorReentrancyMode.Disallowed);
            var context = Guid.NewGuid().ToString();
            guard.Acquire(context, null, CancellationToken.None).Wait();
            guard.Test_CurrentContext.Should().Be(context);
            guard.Test_CurrentCount.Should().Be(1);

            Action action = () => guard.Acquire(context, null, CancellationToken.None).Wait();
            action.Should().Throw<AggregateException>();

            guard.ReleaseContext(context).Wait();
            guard.Test_CurrentContext.Should().NotBe(context);
            guard.Test_CurrentCount.Should().Be(0);
        }

        /// <summary>
        /// Test to verify fixed window actor throttler.
        /// </summary>
        [Fact]
        public void VerifyFixedWindowActorThrottler()
        {
            var actor = new DummyActor();
            var guard = this.CreateAndInitializeThrottlingGuard(
                actor,
                () => new FixedWindowActorThrottler(new FixedWindowActorThrottlingSettings(100, TimeSpan.FromSeconds(2))),
                ActorReentrancyMode.Disallowed);

            Action actorConcurrencyLockAquireAction = () =>
            {
                string context = Guid.NewGuid().ToString();
                guard.Acquire(context, null, CancellationToken.None).Wait();
                guard.ReleaseContext(context).Wait();
            };

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 4,
            };

            int callsRejected = 0;
            Parallel.For(0, 200, options, i =>
            {
                try
                {
                    actorConcurrencyLockAquireAction();
                }
                catch (AggregateException ex)
                {
                    ex.InnerException.Should().BeOfType<ActorThrottlingException>();
                    Interlocked.Increment(ref callsRejected);
                }
            });

            callsRejected.Should().Be(100);

            actorConcurrencyLockAquireAction.Should().Throw<ActorThrottlingException>();
            actorConcurrencyLockAquireAction.Should().Throw<ActorThrottlingException>();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            actorConcurrencyLockAquireAction.Should().NotThrow<ActorThrottlingException>();
            actorConcurrencyLockAquireAction.Should().NotThrow<ActorThrottlingException>();
        }

        /// <summary>
        /// Test to verify reentrant calls are not throttled.
        /// </summary>
        [Fact]
        public void VerifyReentrantCallsNotThrottled()
        {
            var actor = new DummyActor();
            var guard = this.CreateAndInitializeThrottlingGuard(
                actor,
                () => new FixedWindowActorThrottler(new FixedWindowActorThrottlingSettings(1, TimeSpan.FromSeconds(1))),
                ActorReentrancyMode.LogicalCallContext);

            Action actorConcurrencyLockAquireAction = () =>
            {
                string context = Guid.NewGuid().ToString();
                guard.Acquire(context, null, CancellationToken.None).Wait();
                guard.ReleaseContext(context).Wait();
            };

            actorConcurrencyLockAquireAction.Should().NotThrow<ActorThrottlingException>();
            actorConcurrencyLockAquireAction.Should().Throw<ActorThrottlingException>();

            Thread.Sleep(TimeSpan.FromSeconds(1));

            RunTest(guard);
        }

        private static Task<bool> ReplacementHandler(ActorBase actor)
        {
            actor.IsDirty.Should().BeTrue("Expect actor to be in dirty state when handler invoked");
            actor.IsDirty = false;
            return Task.FromResult(true);
        }

        private static void RunTest(ActorConcurrencyLock guard)
        {
            var test = Guid.NewGuid().ToString();
            guard.Acquire(test, null, CancellationToken.None).Wait();
            guard.Test_CurrentCount.Should().Be(1);
            currentContext = test;
            for (var i = 0; i < 10; i++)
            {
                var testContext = test + ":" + Guid.NewGuid().ToString();
                guard.Acquire(testContext, null, CancellationToken.None).Wait();
                testContext.Should().StartWith(currentContext, "Call context Prefix Matching ");
                guard.ReleaseContext(testContext).Wait();
            }

            guard.Test_CurrentCount.Should().Be(1);
            guard.ReleaseContext(test).Wait();
        }

        private ActorConcurrencyLock CreateAndInitializeReentrancyGuard(ActorBase owner, ActorReentrancyMode mode)
        {
            var settings = new ActorConcurrencySettings() { ReentrancyMode = mode };
            var guard = new ActorConcurrencyLock(owner, settings);
            return guard;
        }

        private ActorConcurrencyLock CreateAndInitializeThrottlingGuard(ActorBase owner, Func<IActorThrottler> throtllerFactory, ActorReentrancyMode mode)
        {
            var settings = new ActorConcurrencySettings() { ReentrancyMode = mode };
            var guard = new ActorConcurrencyLock(owner, settings, throtllerFactory);
            return guard;
        }

        /// <summary>
        /// DummyActor used for tests.
        /// </summary>
        private class DummyActor : Actor, IDummyActor
        {
            public DummyActor()
                : base(GetMockActorService(), null)
            {
            }

            public Task<string> Greetings()
            {
                return Task.FromResult("Hello");
            }

            private static ActorService GetMockActorService()
            {
                var nodeContext = new NodeContext(
                    "MockNodeName",
                    new NodeId(BigInteger.Zero, BigInteger.Zero),
                    BigInteger.Zero,
                    "MockNodeType",
                    "0.0.0.0");

                var serviceContext = new StatefulServiceContext(
                    nodeContext,
                    TestMocksRepository.GetCodePackageActivationContext(),
                    "MockServiceTypeName",
                    new Uri("fabric:/MockServiceName"),
                    null,
                    Guid.Empty,
                    long.MinValue);

                return new ActorService(
                    serviceContext,
                    ActorTypeInformation.Get(typeof(DummyActor)));
            }
        }
    }
}
