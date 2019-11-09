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
    /// plannerCategoryDescriptions
    /// </summary>
    public partial class MicrosoftgraphplannerCategoryDescriptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphplannerCategoryDescriptions class.
        /// </summary>
        public MicrosoftgraphplannerCategoryDescriptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphplannerCategoryDescriptions class.
        /// </summary>
        public MicrosoftgraphplannerCategoryDescriptions(string category1 = default(string), string category2 = default(string), string category3 = default(string), string category4 = default(string), string category5 = default(string), string category6 = default(string))
        {
            Category1 = category1;
            Category2 = category2;
            Category3 = category3;
            Category4 = category4;
            Category5 = category5;
            Category6 = category6;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category1")]
        public string Category1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category2")]
        public string Category2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category3")]
        public string Category3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category4")]
        public string Category4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category5")]
        public string Category5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category6")]
        public string Category6 { get; set; }

    }
}