// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Interface for actor throttler.
    /// </summary>
    public interface IActorThrottler
    {
        /// <summary>
        /// Method to throttle actor calls
        /// </summary>
        /// <returns>Returns true if the call should be throttled</returns>
        bool ShouldThrottle();
    }
}
