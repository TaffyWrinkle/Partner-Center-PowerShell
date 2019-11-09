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
    /// personName
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphPersonnameallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphPersonnameallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphPersonnameallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphPersonnameallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphPersonnameallof1(string displayName = default(string), string first = default(string), string initials = default(string), string last = default(string), string languageTag = default(string), string maiden = default(string), string middle = default(string), string nickname = default(string), string suffix = default(string), string title = default(string), MicrosoftgraphyomiPersonName pronunciation = default(MicrosoftgraphyomiPersonName))
        {
            DisplayName = displayName;
            First = first;
            Initials = initials;
            Last = last;
            LanguageTag = languageTag;
            Maiden = maiden;
            Middle = middle;
            Nickname = nickname;
            Suffix = suffix;
            Title = title;
            Pronunciation = pronunciation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "first")]
        public string First { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "initials")]
        public string Initials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last")]
        public string Last { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "languageTag")]
        public string LanguageTag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maiden")]
        public string Maiden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "middle")]
        public string Middle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pronunciation")]
        public MicrosoftgraphyomiPersonName Pronunciation { get; set; }

    }
}