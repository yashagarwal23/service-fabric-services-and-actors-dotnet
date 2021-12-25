// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Fixed window throttler fo actors.
    /// </summary>
    public class FixedWindowActorThrottler : IActorThrottler
    {
        private readonly object lockObject = new object();
        private readonly long limit;
        private readonly TimeSpan throttlingWindow;
        private DateTime windowStartTime;
        private long currentCallCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottler"/> class.
        /// </summary>
        /// <param name="settings">Throttling Settings</param>
        public FixedWindowActorThrottler(FixedWindowActorThrottlingSettings settings)
        {
            this.limit = settings.Limit;
            this.throttlingWindow = settings.Interval;
            this.windowStartTime = DateTime.UtcNow;
            this.currentCallCount = 0;
        }

        /// <inheritdoc/>
        public long Count
        {
            get { return this.currentCallCount; }
        }

        /// <inheritdoc/>
        public bool ShouldThrottle(out long count)
        {
            lock (this.lockObject)
            {
                var currentTime = DateTime.UtcNow;
                var timeElapsed = currentTime - this.windowStartTime;
                if (timeElapsed > this.throttlingWindow)
                {
                    this.currentCallCount = 0;
                    this.windowStartTime = currentTime;
                }

                if (this.currentCallCount >= this.limit)
                {
                    // the call is throttled, reject
                    count = this.currentCallCount;
                    return true;
                }

                // call accepted
                ++this.currentCallCount;
                count = this.currentCallCount;
                return false;
            }
        }
    }
}
