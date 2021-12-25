// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Represents the settings for actor throttler.
    /// </summary>
    public interface IActorThrottlingSettings
    {
        /// <summary>
        /// Gets or sets the request limit.
        /// </summary>
        long Limit { get; set; }

        /// <summary>
        /// Gets or sets the throttling interval.
        /// </summary>
        TimeSpan Interval { get; set; }
    }
}
