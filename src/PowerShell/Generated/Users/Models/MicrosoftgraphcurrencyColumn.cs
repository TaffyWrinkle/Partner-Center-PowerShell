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
    /// currencyColumn
    /// </summary>
    public partial class MicrosoftgraphcurrencyColumn
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphcurrencyColumn
        /// class.
        /// </summary>
        public MicrosoftgraphcurrencyColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphcurrencyColumn
        /// class.
        /// </summary>
        public MicrosoftgraphcurrencyColumn(string locale = default(string))
        {
            Locale = locale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}