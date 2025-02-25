// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SpringAppDiscovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SummaryResource" /> and their operations.
    /// Each <see cref="SummaryResource" /> in the collection will belong to the same instance of <see cref="SpringbootsitesModelResource" />.
    /// To get a <see cref="SummaryCollection" /> instance call the GetSummaries method from an instance of <see cref="SpringbootsitesModelResource" />.
    /// </summary>
    public partial class SummaryCollection : ArmCollection, IEnumerable<SummaryResource>, IAsyncEnumerable<SummaryResource>
    {
        private readonly ClientDiagnostics _summaryClientDiagnostics;
        private readonly SummariesRestOperations _summaryRestClient;

        /// <summary> Initializes a new instance of the <see cref="SummaryCollection"/> class for mocking. </summary>
        protected SummaryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SummaryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SummaryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _summaryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SpringAppDiscovery", SummaryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SummaryResource.ResourceType, out string summaryApiVersion);
            _summaryRestClient = new SummariesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, summaryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SpringbootsitesModelResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SpringbootsitesModelResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Puts the Summaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="data"> The Summary of discovered springbootsites. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SummaryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string summaryName, SummaryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _summaryRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SpringAppDiscoveryArmOperation<SummaryResource>(Response.FromValue(new SummaryResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Puts the Summaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="data"> The Summary of discovered springbootsites. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SummaryResource> CreateOrUpdate(WaitUntil waitUntil, string summaryName, SummaryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _summaryRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, data, cancellationToken);
                var operation = new SpringAppDiscoveryArmOperation<SummaryResource>(Response.FromValue(new SummaryResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Summaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> is null. </exception>
        public virtual async Task<Response<SummaryResource>> GetAsync(string summaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.Get");
            scope.Start();
            try
            {
                var response = await _summaryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Summaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> is null. </exception>
        public virtual Response<SummaryResource> Get(string summaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.Get");
            scope.Start();
            try
            {
                var response = _summaryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Summaries resource in springbootsites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_ListBySite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SummaryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SummaryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _summaryRestClient.CreateListBySiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _summaryRestClient.CreateListBySiteNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SummaryResource(Client, SummaryData.DeserializeSummaryData(e)), _summaryClientDiagnostics, Pipeline, "SummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Summaries resource in springbootsites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_ListBySite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SummaryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SummaryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _summaryRestClient.CreateListBySiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _summaryRestClient.CreateListBySiteNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SummaryResource(Client, SummaryData.DeserializeSummaryData(e)), _summaryClientDiagnostics, Pipeline, "SummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string summaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _summaryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/Summaries/{summaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Summaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="summaryName"> The name of summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="summaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryName"/> is null. </exception>
        public virtual Response<bool> Exists(string summaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(summaryName, nameof(summaryName));

            using var scope = _summaryClientDiagnostics.CreateScope("SummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = _summaryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, summaryName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SummaryResource> IEnumerable<SummaryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SummaryResource> IAsyncEnumerable<SummaryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
