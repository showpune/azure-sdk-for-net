// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary> ErrorSummary model. </summary>
    public partial class ErrorSummaryModel
    {
        /// <summary> Initializes a new instance of ErrorSummaryModel. </summary>
        public ErrorSummaryModel()
        {
        }

        /// <summary> Initializes a new instance of ErrorSummaryModel. </summary>
        /// <param name="affectedResourceType"> The type of Object. </param>
        /// <param name="affectedObjectsCount"> The count. </param>
        internal ErrorSummaryModel(string affectedResourceType, int? affectedObjectsCount)
        {
            AffectedResourceType = affectedResourceType;
            AffectedObjectsCount = affectedObjectsCount;
        }

        /// <summary> The type of Object. </summary>
        public string AffectedResourceType { get; set; }
        /// <summary> The count. </summary>
        public int? AffectedObjectsCount { get; set; }
    }
}
