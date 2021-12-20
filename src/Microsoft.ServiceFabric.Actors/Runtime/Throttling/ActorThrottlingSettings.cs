// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime.Throttling
{
    using System;

    /// <summary>
    /// Settings used by the Actor throttler.
    /// </summary>
    public abstract class ActorThrottlingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="throttlingMethod">Throttling Method.</param>
        public ActorThrottlingSettings(ActorThrottlingMethod throttlingMethod)
        {
            this.ThrottlingMethod = throttlingMethod;
        }

        /// <summary>
        /// Gets or sets the actor throttling method used.
        /// </summary>
        public ActorThrottlingMethod ThrottlingMethod { get; set; }

        /// <summary>
        /// Get the actor throttler.
        /// </summary>
        /// <returns>Returns an instance of Actor throttler.</returns>
        public abstract IActorThrottler GetThrottler();
    }
}
