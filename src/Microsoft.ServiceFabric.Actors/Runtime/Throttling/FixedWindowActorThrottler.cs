// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime.Throttling
{
    using System;
    using System.Collections.Concurrent;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// Fixed Windows Actor call throttler.
    /// </summary>
    public sealed class FixedWindowActorThrottler : IActorThrottler
    {
        private readonly object lockObject = new object();
        private readonly long limit;
        private readonly TimeSpan throttlingInterval;
        private long callCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottler"/> class.
        /// </summary>
        /// <param name="limit">The number of calls allowed.</param>
        /// <param name="throttlingInterval">Throttling interval.</param>
        public FixedWindowActorThrottler(long limit, TimeSpan throttlingInterval)
        {
            this.limit = limit;
            this.throttlingInterval = throttlingInterval;
            this.callCount = 0;

            Timer timer = new Timer(
                _ =>
                {
                    this.callCount = 0;
                },
                null,
                throttlingInterval,
                throttlingInterval);
        }

        /// <summary>
        /// Method to throttle actor calls
        /// </summary>
        /// <returns>returns true/false depicting the call is accepted or rejected.</returns>
        public bool Throttle()
        {
            lock (this.lockObject)
            {
                if (this.callCount < this.limit)
                {
                    this.callCount++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
