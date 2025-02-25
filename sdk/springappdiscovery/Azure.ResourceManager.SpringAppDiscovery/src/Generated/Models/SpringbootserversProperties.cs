// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary> The springbootservers resource definition. </summary>
    public partial class SpringbootserversProperties
    {
        /// <summary> Initializes a new instance of SpringbootserversProperties. </summary>
        /// <param name="server"> Server is the target server name or ip address to discover of SpringBootServer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> is null. </exception>
        public SpringbootserversProperties(string server)
        {
            Argument.AssertNotNull(server, nameof(server));

            Server = server;
            FqdnAndIPAddressList = new ChangeTrackingList<string>();
            Errors = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of SpringbootserversProperties. </summary>
        /// <param name="port"> Target server port for remote login. </param>
        /// <param name="server"> Server is the target server name or ip address to discover of SpringBootServer. </param>
        /// <param name="fqdnAndIPAddressList"> The alternative FQDN or IP addresses to discover for this server. </param>
        /// <param name="machineArmId"> The machine Id from ARM. </param>
        /// <param name="totalApps"> The total number of apps been discovered. </param>
        /// <param name="springBootApps"> The total number of spring boot apps been discovered. </param>
        /// <param name="errors"> The list of errors. </param>
        /// <param name="provisioningState"> The resource provisioning state. </param>
        internal SpringbootserversProperties(int? port, string server, IList<string> fqdnAndIPAddressList, string machineArmId, int? totalApps, int? springBootApps, IList<Error> errors, ProvisioningState? provisioningState)
        {
            Port = port;
            Server = server;
            FqdnAndIPAddressList = fqdnAndIPAddressList;
            MachineArmId = machineArmId;
            TotalApps = totalApps;
            SpringBootApps = springBootApps;
            Errors = errors;
            ProvisioningState = provisioningState;
        }

        /// <summary> Target server port for remote login. </summary>
        public int? Port { get; set; }
        /// <summary> Server is the target server name or ip address to discover of SpringBootServer. </summary>
        public string Server { get; set; }
        /// <summary> The alternative FQDN or IP addresses to discover for this server. </summary>
        public IList<string> FqdnAndIPAddressList { get; }
        /// <summary> The machine Id from ARM. </summary>
        public string MachineArmId { get; set; }
        /// <summary> The total number of apps been discovered. </summary>
        public int? TotalApps { get; set; }
        /// <summary> The total number of spring boot apps been discovered. </summary>
        public int? SpringBootApps { get; set; }
        /// <summary> The list of errors. </summary>
        public IList<Error> Errors { get; }
        /// <summary> The resource provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
    }
}
