// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.SpringAppDiscovery.Tests
{
    public class SpringAppDiscoveryManagementTestBase : ManagementRecordedTestBase<SpringAppDiscoveryManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }
        public ResourceGroupResource resourceGroupResource { get; set; }

        protected SpringAppDiscoveryManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected SpringAppDiscoveryManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        public async Task init(string rgName, AzureLocation location)
        {
            resourceGroupResource = await DefaultSubscription.GetResourceGroups().GetAsync(rgName);
        }
        [OneTimeTearDown]
        public void Cleanup()
        {
            CleanupResourceGroups();
        }
    }
}
