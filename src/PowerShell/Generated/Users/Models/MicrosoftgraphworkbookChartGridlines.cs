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

    public partial class MicrosoftgraphworkbookChartGridlines
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphworkbookChartGridlines class.
        /// </summary>
        public MicrosoftgraphworkbookChartGridlines()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphworkbookChartGridlines class.
        /// </summary>
        public MicrosoftgraphworkbookChartGridlines(string id = default(string), bool? visible = default(bool?), MicrosoftgraphworkbookChartGridlinesFormat format = default(MicrosoftgraphworkbookChartGridlinesFormat))
        {
            Id = id;
            Visible = visible;
            Format = format;
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
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public MicrosoftgraphworkbookChartGridlinesFormat Format { get; set; }

    }
}