// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure-SSIS integration runtime outbound network dependency endpoints for one category. </summary>
    public partial class IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint. </summary>
        internal IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint()
        {
            Endpoints = new ChangeTrackingList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint. </summary>
        /// <param name="category"> The category of outbound network dependency. </param>
        /// <param name="endpoints"> The endpoints for outbound network dependency. </param>
        internal IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(string category, IReadOnlyList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint> endpoints)
        {
            Category = category;
            Endpoints = endpoints;
        }

        /// <summary> The category of outbound network dependency. </summary>
        public string Category { get; }
        /// <summary> The endpoints for outbound network dependency. </summary>
        public IReadOnlyList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint> Endpoints { get; }
    }
}
