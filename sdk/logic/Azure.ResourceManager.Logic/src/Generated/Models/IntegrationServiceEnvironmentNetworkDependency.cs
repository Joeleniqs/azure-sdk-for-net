// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The azure async operation resource. </summary>
    public partial class IntegrationServiceEnvironmentNetworkDependency
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkDependency. </summary>
        internal IntegrationServiceEnvironmentNetworkDependency()
        {
            Endpoints = new ChangeTrackingList<IntegrationServiceEnvironmentNetworkEndpoint>();
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkDependency. </summary>
        /// <param name="category"> The network dependency category type. </param>
        /// <param name="displayName"> The display name. </param>
        /// <param name="endpoints"> The endpoints. </param>
        internal IntegrationServiceEnvironmentNetworkDependency(IntegrationServiceEnvironmentNetworkDependencyCategoryType? category, string displayName, IReadOnlyList<IntegrationServiceEnvironmentNetworkEndpoint> endpoints)
        {
            Category = category;
            DisplayName = displayName;
            Endpoints = endpoints;
        }

        /// <summary> The network dependency category type. </summary>
        public IntegrationServiceEnvironmentNetworkDependencyCategoryType? Category { get; }
        /// <summary> The display name. </summary>
        public string DisplayName { get; }
        /// <summary> The endpoints. </summary>
        public IReadOnlyList<IntegrationServiceEnvironmentNetworkEndpoint> Endpoints { get; }
    }
}
