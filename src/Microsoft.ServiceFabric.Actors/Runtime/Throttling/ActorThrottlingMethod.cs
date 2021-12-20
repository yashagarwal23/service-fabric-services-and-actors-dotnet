// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime.Throttling
{
    /// <summary>
    /// Represents the Actor throttling method used.
    /// </summary>
    public enum ActorThrottlingMethod
    {
        /// <summary>
        /// No actor throttling used.
        /// </summary>
        NONE = 1,

        /// <summary>
        /// fixed window actor throttling
        /// </summary>
        FIXED_WINDOW = 2,

        /// <summary>
        /// user's custom actor throttling
        /// </summary>
        CUSTOM = 3,
    }
}
