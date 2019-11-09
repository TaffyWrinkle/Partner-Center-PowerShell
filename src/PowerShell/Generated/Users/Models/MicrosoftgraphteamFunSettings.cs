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
    /// teamFunSettings
    /// </summary>
    public partial class MicrosoftgraphteamFunSettings
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphteamFunSettings
        /// class.
        /// </summary>
        public MicrosoftgraphteamFunSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphteamFunSettings
        /// class.
        /// </summary>
        /// <param name="giphyContentRating">Possible values include:
        /// 'moderate', 'strict', 'unknownFutureValue'</param>
        public MicrosoftgraphteamFunSettings(bool? allowGiphy = default(bool?), string giphyContentRating = default(string), bool? allowStickersAndMemes = default(bool?), bool? allowCustomMemes = default(bool?))
        {
            AllowGiphy = allowGiphy;
            GiphyContentRating = giphyContentRating;
            AllowStickersAndMemes = allowStickersAndMemes;
            AllowCustomMemes = allowCustomMemes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowGiphy")]
        public bool? AllowGiphy { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'moderate', 'strict',
        /// 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "giphyContentRating")]
        public string GiphyContentRating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowStickersAndMemes")]
        public bool? AllowStickersAndMemes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowCustomMemes")]
        public bool? AllowCustomMemes { get; set; }

    }
}