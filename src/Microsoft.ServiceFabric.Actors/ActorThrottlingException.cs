// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Runtime.Throttling
{
    using System;
    using System.Collections.Generic;
    using System.Fabric;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Exception thrown when actor throttler rejects a call.
    /// </summary>
    [Serializable]
    public sealed class ActorThrottlingException : FabricException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActorThrottlingException"/> class.
        /// </summary>
        public ActorThrottlingException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorThrottlingException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public ActorThrottlingException(string message)
            : base(message)
        {
        }
    }
}
