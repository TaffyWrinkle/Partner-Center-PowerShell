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

    public partial class MicrosoftgraphopenShift
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphopenShift class.
        /// </summary>
        public MicrosoftgraphopenShift()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphopenShift class.
        /// </summary>
        public MicrosoftgraphopenShift(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), MicrosoftgraphidentitySet lastModifiedBy = default(MicrosoftgraphidentitySet), MicrosoftgraphopenShiftItem sharedOpenShift = default(MicrosoftgraphopenShiftItem), MicrosoftgraphopenShiftItem draftOpenShift = default(MicrosoftgraphopenShiftItem), string schedulingGroupId = default(string))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            SharedOpenShift = sharedOpenShift;
            DraftOpenShift = draftOpenShift;
            SchedulingGroupId = schedulingGroupId;
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
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public MicrosoftgraphidentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharedOpenShift")]
        public MicrosoftgraphopenShiftItem SharedOpenShift { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "draftOpenShift")]
        public MicrosoftgraphopenShiftItem DraftOpenShift { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SharedOpenShift != null)
            {
                SharedOpenShift.Validate();
            }
            if (DraftOpenShift != null)
            {
                DraftOpenShift.Validate();
            }
        }
    }
}