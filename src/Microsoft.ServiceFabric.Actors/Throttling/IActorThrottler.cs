// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Throttles the calls made to an actor.
    /// It includes both regular actor proxy calls and reminder calls.
    /// </summary>
    public interface IActorThrottler
    {
        /// <summary>
        /// Gets the current call count of the actor.
        /// </summary>
        long Count { get; }

        /// <summary>
        /// Should the actor call be throttled.
        /// </summary>
        /// <param name="count">the updated request count of the actor.</param>
        /// <returns>True, if the call is throttled. Otherwise, False</returns>
        bool ShouldThrottle(out long count);
    }
}
