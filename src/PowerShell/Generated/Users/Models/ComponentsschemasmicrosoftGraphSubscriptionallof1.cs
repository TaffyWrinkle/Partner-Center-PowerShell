// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// subscription
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphSubscriptionallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphSubscriptionallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphSubscriptionallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphSubscriptionallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphSubscriptionallof1(string resource = default(string), string changeType = default(string), string clientState = default(string), string notificationUrl = default(string), System.DateTime? expirationDateTime = default(System.DateTime?), string applicationId = default(string), string creatorId = default(string), bool? includeProperties = default(bool?), bool? includeResourceData = default(bool?), string lifecycleNotificationUrl = default(string), string encryptionCertificate = default(string), string encryptionCertificateId = default(string))
        {
            Resource = resource;
            ChangeType = changeType;
            ClientState = clientState;
            NotificationUrl = notificationUrl;
            ExpirationDateTime = expirationDateTime;
            ApplicationId = applicationId;
            CreatorId = creatorId;
            IncludeProperties = includeProperties;
            IncludeResourceData = includeResourceData;
            LifecycleNotificationUrl = lifecycleNotificationUrl;
            EncryptionCertificate = encryptionCertificate;
            EncryptionCertificateId = encryptionCertificateId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "changeType")]
        public string ChangeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientState")]
        public string ClientState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notificationUrl")]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationDateTime")]
        public System.DateTime? ExpirationDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creatorId")]
        public string CreatorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "includeProperties")]
        public bool? IncludeProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "includeResourceData")]
        public bool? IncludeResourceData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lifecycleNotificationUrl")]
        public string LifecycleNotificationUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "encryptionCertificate")]
        public string EncryptionCertificate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "encryptionCertificateId")]
        public string EncryptionCertificateId { get; set; }

    }
}