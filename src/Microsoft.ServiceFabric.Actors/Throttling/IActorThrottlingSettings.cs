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
        /// Gets the call limit.
        /// </summary>
        long Limit { get; }

        /// <summary>
        /// Gets the throttling interval.
        /// </summary>
        TimeSpan Interval { get; }
    }
}
