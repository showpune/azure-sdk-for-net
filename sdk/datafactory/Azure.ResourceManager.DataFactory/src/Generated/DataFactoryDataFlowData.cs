// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing the DataFactoryDataFlow data model.
    /// Data flow resource type.
    /// </summary>
    public partial class DataFactoryDataFlowData : ResourceData
    {
        /// <summary> Initializes a new instance of DataFactoryDataFlowData. </summary>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletDefinition"/>, <see cref="DataFactoryMappingDataFlowDefinition"/> and <see cref="DataFactoryWranglingDataFlowDefinition"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFactoryDataFlowData(DataFactoryDataFlowDefinition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFactoryDataFlowData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletDefinition"/>, <see cref="DataFactoryMappingDataFlowDefinition"/> and <see cref="DataFactoryWranglingDataFlowDefinition"/>.
        /// </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal DataFactoryDataFlowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataFactoryDataFlowDefinition properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary>
        /// Data flow properties.
        /// Please note <see cref="DataFactoryDataFlowDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactoryFlowletDefinition"/>, <see cref="DataFactoryMappingDataFlowDefinition"/> and <see cref="DataFactoryWranglingDataFlowDefinition"/>.
        /// </summary>
        public DataFactoryDataFlowDefinition Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}
