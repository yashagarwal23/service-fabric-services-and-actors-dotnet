// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Fixed Window Actor Throttler
    /// </summary>
    public class FixedWindowActorThrottler : IActorThrottler
    {
        private readonly object lockObject = new object();
        private readonly long limit;
        private readonly TimeSpan throttlingInterval;
        private DateTime windowStartTime;
        private long currentCallCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottler"/> class.
        /// </summary>
        /// <param name="limit">Throttling limit</param>
        /// <param name="throttlingInterval">Throttling interval</param>
        public FixedWindowActorThrottler(long limit, TimeSpan throttlingInterval)
        {
            this.limit = limit;
            this.throttlingInterval = throttlingInterval;
            this.windowStartTime = DateTime.UtcNow;
            this.currentCallCount = 0;
        }

        /// <inheritdoc/>
        public bool ShouldThrottle()
        {
            lock (this.lockObject)
            {
                var currentTime = DateTime.UtcNow;
                var timeElapsed = currentTime - this.windowStartTime;
                if (timeElapsed > this.throttlingInterval)
                {
                    this.currentCallCount = 0;
                    this.windowStartTime = currentTime;
                }

                if (this.currentCallCount >= this.limit)
                {
                    // the call is throttled, reject
                    return true;
                }

                ++this.currentCallCount;

                // call accepted
                return false;
            }
        }
    }
}
