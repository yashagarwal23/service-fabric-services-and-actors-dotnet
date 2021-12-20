// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime.Throttling
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
        /// <returns>returns true/false depicting the call is accepted or rejected.</returns>
        bool Throttle();
    }
}
