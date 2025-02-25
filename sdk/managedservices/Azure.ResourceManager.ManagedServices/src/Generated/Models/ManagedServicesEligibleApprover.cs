// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> Defines the Azure Active Directory principal that can approve any just-in-time access requests by the principal defined in the EligibleAuthorization. </summary>
    public partial class ManagedServicesEligibleApprover
    {
        /// <summary> Initializes a new instance of ManagedServicesEligibleApprover. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        public ManagedServicesEligibleApprover(Guid principalId)
        {
            PrincipalId = principalId;
        }

        /// <summary> Initializes a new instance of ManagedServicesEligibleApprover. </summary>
        /// <param name="principalId"> The identifier of the Azure Active Directory principal. </param>
        /// <param name="principalIdDisplayName"> The display name of the Azure Active Directory principal. </param>
        internal ManagedServicesEligibleApprover(Guid principalId, string principalIdDisplayName)
        {
            PrincipalId = principalId;
            PrincipalIdDisplayName = principalIdDisplayName;
        }

        /// <summary> The identifier of the Azure Active Directory principal. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The display name of the Azure Active Directory principal. </summary>
        public string PrincipalIdDisplayName { get; set; }
    }
}
