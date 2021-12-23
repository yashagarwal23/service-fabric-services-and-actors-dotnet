// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Throttling
{
    using System;

    /// <summary>
    /// Throttling settings for actors.
    /// </summary>
    public class ActorThrottlingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActorThrottlingSettings"/> class.
        /// </summary>
        public ActorThrottlingSettings()
        {
            this.ThrottlerFactory = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorThrottlingSettings"/> class.
        /// </summary>
        /// <param name="throttlerFactory">Throttler Factory</param>
        public ActorThrottlingSettings(Func<IActorThrottler> throttlerFactory)
        {
            this.ThrottlerFactory = throttlerFactory;
        }

        internal ActorThrottlingSettings(ActorThrottlingSettings other)
        {
            this.ThrottlerFactory = other.ThrottlerFactory;
        }

        /// <summary>
        /// Gets or sets the Throttler Factory
        /// </summary>
        public Func<IActorThrottler> ThrottlerFactory { get; set;  }
    }
}
