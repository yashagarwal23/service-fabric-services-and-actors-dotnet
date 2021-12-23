// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Settings for Fixed Window Actor Throttling
    /// </summary>
    public class FixedWindowActorThrottlingSettings : ActorThrottlingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="limit">Throttling limit</param>
        /// <param name="throttlingInterval">Throttling interval</param>
        public FixedWindowActorThrottlingSettings(long limit, TimeSpan throttlingInterval)
        {
            this.ThrottlerFactory = () => new FixedWindowActorThrottler(limit, throttlingInterval);
            this.Limit = limit;
            this.ThrottlingInterval = throttlingInterval;
        }

        internal FixedWindowActorThrottlingSettings(FixedWindowActorThrottlingSettings other)
            : this(other.Limit, other.ThrottlingInterval)
        {
        }

        /// <summary>
        /// Gets or sets the limit for fixed window actor throttling.
        /// </summary>
        public long Limit { get; set; }

        /// <summary>
        /// Gets or sets the throttling interval for fixed window actor throttling.
        /// </summary>
        public TimeSpan ThrottlingInterval { get; set; }
    }
}
