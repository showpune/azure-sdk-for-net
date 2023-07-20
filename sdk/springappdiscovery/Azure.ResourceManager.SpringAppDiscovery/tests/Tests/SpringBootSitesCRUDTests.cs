// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
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
                SpringbootsitesModelData siteData = site.Data;
                Console.WriteLine($"Succeeded on site id: {siteData.Id}");
                hasSite = true;
                SpringbootserversModelCollection springbootserversModelCollection = site.GetSpringbootserversModels();
                await site.TriggerRefreshSiteAsync(WaitUntil.Completed);
                var serverCount = 0;
                SpringbootserversModelData serverData = new SpringbootserversModelData();
                var serverName ="";
                await foreach (SpringbootserversModelResource server in springbootserversModelCollection.GetAllAsync())
                {
                    serverName = server.Data.Properties.Server;
                    if (serverName == "backend")
                    {
                        serverData = server.Data;
                    }
                    Console.WriteLine($"Succeeded find server with serverName: {serverName}");
                    serverCount++;
                }
                Console.WriteLine($"Succeeded Discovery server count: {serverCount}");
                Assert.IsTrue(serverCount >= 2);
                var appCount = 0;
                SpringbootappsModelCollection springbootappsModelCollection = site.GetSpringbootappsModels();
                await foreach (SpringbootappsModelResource app in springbootappsModelCollection.GetAllAsync())
                {
                    SpringbootappsModelData appData = app.Data;
                    Console.WriteLine($"Succeeded on appData id: {appData.Properties.AppName}");
                    if (appData.Properties.Servers.Count > 0)
                    {
                        appCount++;
                    }
                    else
                    {
                        Console.WriteLine($"appData {appData.Properties.AppName} is not bound to any server, ignore it");
                    }
                }
                Console.WriteLine($"Succeeded Discovery appCount count: {appCount}");
                Assert.IsTrue(appCount == 1);

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

                //start change
                // Test Create
                serverName = "backendtest";
                serverData.Properties.Server = serverName;
                serverData.Properties.ProvisioningState = ProvisioningState.Accepted;
                ArmOperation<SpringbootserversModelResource> lro = await springbootserversModelCollection.CreateOrUpdateAsync(WaitUntil.Completed, serverName, serverData);
                SpringbootserversModelResource result = lro.Value;
                Console.WriteLine($"New Server added with server name: {serverName}");
                Assert.IsNotNull(result);
                await site.TriggerRefreshSiteAsync(WaitUntil.Completed);
                Console.WriteLine($"Refresh succeedded");
                Response<SpringbootserversModelResource> newServer = await result.GetAsync();
                SpringbootserversModelResource newResult = newServer.Value;
                int retryTimes = 0;
                while (true)
                {
                    Console.WriteLine($"Try {retryTimes} time(s)");
                    if (newResult.Data.Properties.ProvisioningState == ProvisioningState.Succeeded|| retryTimes>10)
                    {
                        Console.WriteLine($"Find {newResult.Data.Properties.TotalApps} app(s) in server {serverName}");
                        Assert.IsTrue(newResult.Data.Properties.TotalApps == 1);
                        await newResult.DeleteAsync(WaitUntil.Completed);
                        Console.WriteLine($"{serverName} is deleted");
                        break;
                    }
                    retryTimes++;
                    Thread.Sleep(10000);
                }
            }
            Assert.IsTrue(hasSite);
        }
    }
}
