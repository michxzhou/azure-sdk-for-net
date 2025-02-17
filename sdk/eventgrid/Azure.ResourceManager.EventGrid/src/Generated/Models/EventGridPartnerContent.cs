// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the partner. </summary>
    public partial class EventGridPartnerContent
    {
        /// <summary> Initializes a new instance of EventGridPartnerContent. </summary>
        public EventGridPartnerContent()
        {
        }

        /// <summary> Initializes a new instance of EventGridPartnerContent. </summary>
        /// <param name="partnerRegistrationImmutableId"> The immutableId of the corresponding partner registration. </param>
        /// <param name="partnerName"> The partner name. </param>
        /// <param name="authorizationExpireOn">
        /// Expiration time of the partner authorization. If this timer expires, any request from this partner to create, update or delete resources in subscriber's
        /// context will fail. If specified, the allowed values are between 1 to the value of defaultMaximumExpirationTimeInDays specified in PartnerConfiguration.
        /// If not specified, the default value will be the value of defaultMaximumExpirationTimeInDays specified in PartnerConfiguration or 7 if this value is not specified.
        /// </param>
        internal EventGridPartnerContent(Guid? partnerRegistrationImmutableId, string partnerName, DateTimeOffset? authorizationExpireOn)
        {
            PartnerRegistrationImmutableId = partnerRegistrationImmutableId;
            PartnerName = partnerName;
            AuthorizationExpireOn = authorizationExpireOn;
        }

        /// <summary> The immutableId of the corresponding partner registration. </summary>
        public Guid? PartnerRegistrationImmutableId { get; set; }
        /// <summary> The partner name. </summary>
        public string PartnerName { get; set; }
        /// <summary>
        /// Expiration time of the partner authorization. If this timer expires, any request from this partner to create, update or delete resources in subscriber's
        /// context will fail. If specified, the allowed values are between 1 to the value of defaultMaximumExpirationTimeInDays specified in PartnerConfiguration.
        /// If not specified, the default value will be the value of defaultMaximumExpirationTimeInDays specified in PartnerConfiguration or 7 if this value is not specified.
        /// </summary>
        public DateTimeOffset? AuthorizationExpireOn { get; set; }
    }
}
