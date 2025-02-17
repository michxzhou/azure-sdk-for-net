// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure data lake store write settings. </summary>
    public partial class AzureDataLakeStoreWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreWriteSettings. </summary>
        public AzureDataLakeStoreWriteSettings()
        {
            StoreWriteSettingsType = "AzureDataLakeStoreWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreWriteSettings. </summary>
        /// <param name="storeWriteSettingsType"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="expiryDateTime"> Specifies the expiry time of the written files. The time is applied to the UTC time zone in the format of "2018-12-01T05:00:00Z". Default value is NULL. Type: string (or Expression with resultType string). </param>
        internal AzureDataLakeStoreWriteSettings(string storeWriteSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, DataFactoryElement<string> copyBehavior, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> expiryDateTime) : base(storeWriteSettingsType, maxConcurrentConnections, disableMetricsCollection, copyBehavior, additionalProperties)
        {
            ExpiryDateTime = expiryDateTime;
            StoreWriteSettingsType = storeWriteSettingsType ?? "AzureDataLakeStoreWriteSettings";
        }

        /// <summary> Specifies the expiry time of the written files. The time is applied to the UTC time zone in the format of "2018-12-01T05:00:00Z". Default value is NULL. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ExpiryDateTime { get; set; }
    }
}
