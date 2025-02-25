// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication.JobRouter;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Policy governing how jobs are distributed to workers. </summary>
    public partial class DistributionPolicy
    {
        /// <summary> Initializes a new instance of DistributionPolicy. </summary>
        /// <param name="id"> The unique identifier of the policy. </param>
        /// <param name="name"> The human readable name of the policy. </param>
        /// <param name="offerExpiresAfterSeconds"> The number of seconds after which any offers created under this policy will be expired. </param>
        /// <param name="mode">
        /// Abstract base class for defining a distribution mode
        /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
        /// </param>
        internal DistributionPolicy(string id, string name, double? offerExpiresAfterSeconds, DistributionMode mode)
        {
            Id = id;
            Name = name;
            _offerExpiresAfterSeconds = offerExpiresAfterSeconds;
            Mode = mode;
        }

        /// <summary> The unique identifier of the policy. </summary>
        public string Id { get; }
        /// <summary> The human readable name of the policy. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Abstract base class for defining a distribution mode
        /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
        /// </summary>
        public DistributionMode Mode { get; set; }
    }
}
