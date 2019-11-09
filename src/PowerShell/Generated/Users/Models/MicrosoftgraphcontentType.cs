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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphcontentType
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphcontentType class.
        /// </summary>
        public MicrosoftgraphcontentType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphcontentType class.
        /// </summary>
        public MicrosoftgraphcontentType(string id = default(string), string description = default(string), string group = default(string), bool? hidden = default(bool?), MicrosoftgraphitemReference inheritedFrom = default(MicrosoftgraphitemReference), string name = default(string), MicrosoftgraphcontentTypeOrder order = default(MicrosoftgraphcontentTypeOrder), string parentId = default(string), bool? readOnlyProperty = default(bool?), bool? sealedProperty = default(bool?), IList<MicrosoftgraphcolumnLink> columnLinks = default(IList<MicrosoftgraphcolumnLink>))
        {
            Id = id;
            Description = description;
            Group = group;
            Hidden = hidden;
            InheritedFrom = inheritedFrom;
            Name = name;
            Order = order;
            ParentId = parentId;
            ReadOnlyProperty = readOnlyProperty;
            SealedProperty = sealedProperty;
            ColumnLinks = columnLinks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inheritedFrom")]
        public MicrosoftgraphitemReference InheritedFrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public MicrosoftgraphcontentTypeOrder Order { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sealed")]
        public bool? SealedProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnLinks")]
        public IList<MicrosoftgraphcolumnLink> ColumnLinks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Order != null)
            {
                Order.Validate();
            }
        }
    }
}