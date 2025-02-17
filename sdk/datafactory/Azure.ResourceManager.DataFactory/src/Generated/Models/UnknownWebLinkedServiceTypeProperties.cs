// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownWebLinkedServiceTypeProperties. </summary>
    internal partial class UnknownWebLinkedServiceTypeProperties : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of UnknownWebLinkedServiceTypeProperties. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        internal UnknownWebLinkedServiceTypeProperties(DataFactoryElement<string> uri, WebAuthenticationType authenticationType) : base(uri, authenticationType)
        {
            AuthenticationType = authenticationType;
        }
    }
}
