// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Developer.DevCenter
{
    /// <summary> Client options for Azure.Developer.DevCenter library clients. </summary>
    public partial class AzureDeveloperDevCenterClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_04_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2023-04-01". </summary>
            V2023_04_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AzureDeveloperDevCenterClientOptions. </summary>
        public AzureDeveloperDevCenterClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_04_01 => "2023-04-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
