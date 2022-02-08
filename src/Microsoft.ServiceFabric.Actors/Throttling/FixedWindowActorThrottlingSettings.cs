// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Settings for fixed window actor throttler
    /// </summary>
    public class FixedWindowActorThrottlingSettings : IActorThrottlingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="limit">Call Limit</param>
        /// <param name="throttlingWindow">Throttling Window</param>
        public FixedWindowActorThrottlingSettings(long limit, TimeSpan throttlingWindow)
        {
            if (limit <= 0)
            {
                throw new ArgumentException("Limit must be greater than 0");
            }

            if (throttlingWindow <= TimeSpan.Zero)
            {
                throw new ArgumentException("Throttling Window must be a positive time span duration.");
            }

            this.Limit = limit;
            this.Interval = throttlingWindow;
        }

        /// <inheritdoc/>
        public long Limit { get; private set; }

        /// <summary>
        /// Gets the throttling window.
        /// </summary>
        public TimeSpan Interval { get; private set; }
    }
}
