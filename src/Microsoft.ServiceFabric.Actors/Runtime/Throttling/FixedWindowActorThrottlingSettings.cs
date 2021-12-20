// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime
{
    using System;
    using Microsoft.ServiceFabric.Actors.Runtime.Throttling;

    /// <summary>
    /// Settings for fixed window actor throttling.
    /// </summary>
    public class FixedWindowActorThrottlingSettings : ActorThrottlingSettings
    {
        private long limit;
        private TimeSpan throttlingInterval;

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="limit">The number of calls allowed.</param>
        /// <param name="throttlingInterval">Throttling interval.</param>
        public FixedWindowActorThrottlingSettings(long limit, TimeSpan throttlingInterval)
            : base(ActorThrottlingMethod.FIXED_WINDOW)
        {
            this.limit = limit;
            this.throttlingInterval = throttlingInterval;
        }

        /// <inheritdoc/>
        public override IActorThrottler GetThrottler()
        {
            return new FixedWindowActorThrottler(this.limit, this.throttlingInterval);
        }
    }
}
