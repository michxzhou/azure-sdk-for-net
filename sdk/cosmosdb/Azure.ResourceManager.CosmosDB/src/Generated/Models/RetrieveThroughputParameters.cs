// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB retrieve throughput parameters object. </summary>
    public partial class RetrieveThroughputParameters : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RetrieveThroughputParameters. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a resource throughput. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public RetrieveThroughputParameters(AzureLocation location, RetrieveThroughputPropertiesResource resource) : base(location)
        {
            Argument.AssertNotNull(resource, nameof(resource));

            Resource = resource;
        }

        /// <summary> Initializes a new instance of RetrieveThroughputParameters. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a resource throughput. </param>
        /// <param name="identity"> Identity for the resource. </param>
        internal RetrieveThroughputParameters(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RetrieveThroughputPropertiesResource resource, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Identity = identity;
        }

        /// <summary> The standard JSON format of a resource throughput. </summary>
        internal RetrieveThroughputPropertiesResource Resource { get; set; }
        /// <summary> Array of PhysicalPartitionId objects. </summary>
        public IList<WritableSubResource> ResourcePhysicalPartitionIds
        {
            get => Resource is null ? default : Resource.PhysicalPartitionIds;
            set => Resource = new RetrieveThroughputPropertiesResource(value);
        }

        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
