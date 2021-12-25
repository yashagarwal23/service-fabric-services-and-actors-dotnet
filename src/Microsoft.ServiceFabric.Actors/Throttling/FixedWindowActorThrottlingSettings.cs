// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Settings for fixed window actor throttling
    /// </summary>
    public class FixedWindowActorThrottlingSettings : IActorThrottlingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedWindowActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="limit">Request Limit</param>
        /// <param name="throttlingWindow">Throttling Window</param>
        public FixedWindowActorThrottlingSettings(long limit, TimeSpan throttlingWindow)
        {
            this.Limit = limit;
            this.Interval = throttlingWindow;
        }

        /// <inheritdoc/>
        public long Limit { get; set; }

        /// <inheritdoc/>
        public TimeSpan Interval { get; set; }
    }
}
