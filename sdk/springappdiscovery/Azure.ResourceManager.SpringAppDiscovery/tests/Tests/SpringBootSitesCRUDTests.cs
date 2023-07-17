// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.SpringAppDiscovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SpringAppDiscovery.Tests.Tests
{
    [TestFixture]
    public class SpringBootSitesCRUDTests : SpringAppDiscoveryManagementTestBase
    {
        public const string rgName = "Shopizer-Migration";
        public const string siteName = "springboot-sites-crud-siteName";
        public const string migrationProject = "springboot-sites-crud-migrationprj";
        public AzureLocation DefaultResourceLocation = AzureLocation.SoutheastAsia;

        public SpringBootSitesCRUDTests() : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await CreateCommonClient();
                await init(rgName, DefaultResourceLocation);
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

        /// <summary>
        /// Test CRUD for spring discovery
        /// </summary>
        /// <returns></returns>
        [TestCase]
        public async Task TestSitesCRUDOperations()
        {
            SpringbootsitesModelCollection springbootsitesModelCollection = resourceGroupResource.GetSpringbootsitesModels();

            bool hasSite = false;
            await foreach (SpringbootsitesModelResource site in springbootsitesModelCollection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringbootsitesModelData siteData = site.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on site id: {siteData.Id}");
                hasSite = true;
                SpringbootserversModelCollection springbootserversModelCollection = site.GetSpringbootserversModels();

                var serverCount = 0;
                SpringbootserversModelData serverData = new SpringbootserversModelData();
                var serverName ="";
                await foreach (SpringbootserversModelResource server in springbootserversModelCollection.GetAllAsync())
                {
                    // the variable item is a resource, you could call other operations on this instance as well
                    // but just for demo, we get its data from this resource instance
                    serverData = server.Data;
                    // for demo we just print out the id
                    serverName = serverData.Properties.Server;
                    Console.WriteLine($"Succeeded add server with serverName: {serverName}");
                    serverCount++;
                }
                Console.WriteLine($"Succeeded Discovery server count: {serverCount}");
                Assert.IsTrue(serverCount > 0);
                // Test Create
                serverName = "backendtest";
                serverData.Properties.Server = serverName;
                try
                {
                    ResourceIdentifier deleteServerId = SpringbootserversModelResource.CreateResourceIdentifier("a4ab3025-1b32-4394-92e0-d07c1ebf3787", rgName, siteData.Name, serverName);
                    SpringbootserversModelResource deleteServerModel = Client.GetSpringbootserversModelResource(deleteServerId);
                    ArmOperation<SpringbootserversModelResource> deleteResource = await deleteServerModel.DeleteAsync(WaitUntil.Completed);
                } catch (NullReferenceException e)
                {
                    Console.WriteLine(serverName + " is already deleted:"+e.Message);
                }
                ArmOperation<SpringbootserversModelResource> lro = await springbootserversModelCollection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, serverData);
                SpringbootserversModelResource result = lro.Value;
                Assert.IsNotNull(result);
                while (true)
                {
                    Response<SpringbootserversModelResource> newServer = await result.GetAsync();
                    SpringbootserversModelResource newResult = newServer.Value;
                    if (newResult != null)
                    {
                        lro = await result.DeleteAsync(WaitUntil.Completed);
                        result = lro.Value;
                        Assert.IsNotNull(result);
                        break;
                    }
                }

                var appCount = 0;
                SpringbootappsModelCollection springbootappsModelCollection = site.GetSpringbootappsModels();
                await foreach (SpringbootappsModelResource app in springbootappsModelCollection.GetAllAsync())
                {
                    // the variable item is a resource, you could call other operations on this instance as well
                    // but just for demo, we get its data from this resource instance
                    SpringbootappsModelData appData = app.Data;
                    // for demo we just print out the id
                    Console.WriteLine($"Succeeded on appData id: {appData.Id}");
                    appCount++;
                }
                Console.WriteLine($"Succeeded Discovery appCount count: {appCount}");
                Assert.IsTrue(appCount > 0);

                ErrorSummaryCollection errorSummaryCollection = site.GetErrorSummaries();
                await foreach (ErrorSummaryResource errorSummaryResource in errorSummaryCollection.GetAllAsync())
                {
                    // the variable item is a resource, you could call other operations on this instance as well
                    // but just for demo, we get its data from this resource instance
                    ErrorSummaryData errorSummaryData = errorSummaryResource.Data;
                    // for demo we just print out the id
                    Console.WriteLine($"Succeeded on errorSummaryData id: {errorSummaryData.Id}");
                    Assert.IsTrue(errorSummaryData.Properties.Errors.Count == 0);
                }
                SummaryCollection summaryCollection = site.GetSummaries();
                var summaryCount = 0;
                await foreach (SummaryResource summaryResource in summaryCollection.GetAllAsync())
                {
                    // the variable item is a resource, you could call other operations on this instance as well
                    // but just for demo, we get its data from this resource instance
                    SummaryData summaryData = summaryResource.Data;
                    // for demo we just print out the id
                    Console.WriteLine($"Succeeded on summaryData id: {summaryData.Id}");
                    summaryCount++;
                }
                Assert.IsTrue(summaryCount > 0);
            }
            Assert.IsTrue(hasSite);
        }
    }
}
