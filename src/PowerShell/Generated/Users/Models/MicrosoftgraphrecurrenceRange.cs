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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// recurrenceRange
    /// </summary>
    public partial class MicrosoftgraphrecurrenceRange
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphrecurrenceRange
        /// class.
        /// </summary>
        public MicrosoftgraphrecurrenceRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphrecurrenceRange
        /// class.
        /// </summary>
        /// <param name="type">Possible values include: 'endDate', 'noEnd',
        /// 'numbered'</param>
        public MicrosoftgraphrecurrenceRange(string type = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string recurrenceTimeZone = default(string), int? numberOfOccurrences = default(int?))
        {
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            RecurrenceTimeZone = recurrenceTimeZone;
            NumberOfOccurrences = numberOfOccurrences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'endDate', 'noEnd',
        /// 'numbered'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrenceTimeZone")]
        public string RecurrenceTimeZone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "numberOfOccurrences")]
        public int? NumberOfOccurrences { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NumberOfOccurrences > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "NumberOfOccurrences", 2147483647);
            }
            if (NumberOfOccurrences < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "NumberOfOccurrences", -2147483648);
            }
        }
    }
}