// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.SpringAppDiscovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SpringAppDiscovery.Tests.Tests
{
    [TestFixture]
    public class SpringBootSitesCRUDTests : SpringAppDiscoveryManagementTestBase
    {
        public const string rgNamePrefix = "springboot-sites-crud-rgname";
        public const string siteName = "springboot-sites-crud-siteName";
        public const string migrationProject = "springboot-sites-crud-migrationprj";
        public AzureLocation DefaultResourceLocation = AzureLocation.EastUS;

        public SpringBootSitesCRUDTests() : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await CreateCommonClient();
                await init(rgNamePrefix, DefaultResourceLocation);
            }
        }

        private SpringbootsitesProperties getSpringbootsitesProperties()
        {
            return new SpringbootsitesProperties(siteName, migrationProject, null);
        }

        private SpringbootsitesModelExtendedLocation getExtendedLocation()
        {
            return new SpringbootsitesModelExtendedLocation("type","name");
        }

        [TestCase]
        public async Task TestSitesCRUDOperations()
        {
            SpringbootsitesModelCollection springbootsitesModelCollection = resourceGroupResource.GetSpringbootsitesModels();
            SpringbootsitesModelData springbootsitesModelData = new(DefaultResourceLocation)
            {
                Properties = getSpringbootsitesProperties(),
                ExtendedLocation = getExtendedLocation()
            };

            var createSpringbootsitesOperation = await springbootsitesModelCollection.CreateOrUpdateAsync(WaitUntil.Completed, siteName, springbootsitesModelData);
            await createSpringbootsitesOperation.WaitForCompletionAsync();
            Assert.IsTrue(createSpringbootsitesOperation.HasCompleted);
            Assert.IsTrue(createSpringbootsitesOperation.HasValue);

            Response<SpringbootsitesModelResource> siteResponse = await springbootsitesModelCollection.GetAsync(siteName);
            Assert.IsNotNull(siteResponse.Value);
        }
    }
}
