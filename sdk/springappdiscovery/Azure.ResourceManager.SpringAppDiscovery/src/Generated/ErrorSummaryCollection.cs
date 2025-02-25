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
    /// A class representing a collection of <see cref="ErrorSummaryResource" /> and their operations.
    /// Each <see cref="ErrorSummaryResource" /> in the collection will belong to the same instance of <see cref="SpringbootsitesModelResource" />.
    /// To get an <see cref="ErrorSummaryCollection" /> instance call the GetErrorSummaries method from an instance of <see cref="SpringbootsitesModelResource" />.
    /// </summary>
    public partial class ErrorSummaryCollection : ArmCollection, IEnumerable<ErrorSummaryResource>, IAsyncEnumerable<ErrorSummaryResource>
    {
        private readonly ClientDiagnostics _errorSummaryClientDiagnostics;
        private readonly ErrorSummariesRestOperations _errorSummaryRestClient;

        /// <summary> Initializes a new instance of the <see cref="ErrorSummaryCollection"/> class for mocking. </summary>
        protected ErrorSummaryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ErrorSummaryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ErrorSummaryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _errorSummaryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SpringAppDiscovery", ErrorSummaryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ErrorSummaryResource.ResourceType, out string errorSummaryApiVersion);
            _errorSummaryRestClient = new ErrorSummariesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, errorSummaryApiVersion);
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
        /// Puts the ErrorSummaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="data"> The ErrorSummaries of discovered springbootsites. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ErrorSummaryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string errorSummaryName, ErrorSummaryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _errorSummaryRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SpringAppDiscoveryArmOperation<ErrorSummaryResource>(Response.FromValue(new ErrorSummaryResource(Client, response), response.GetRawResponse()));
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
        /// Puts the ErrorSummaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="data"> The ErrorSummaries of discovered springbootsites. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ErrorSummaryResource> CreateOrUpdate(WaitUntil waitUntil, string errorSummaryName, ErrorSummaryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _errorSummaryRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, data, cancellationToken);
                var operation = new SpringAppDiscoveryArmOperation<ErrorSummaryResource>(Response.FromValue(new ErrorSummaryResource(Client, response), response.GetRawResponse()));
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
        /// Gets the ErrorSummaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> is null. </exception>
        public virtual async Task<Response<ErrorSummaryResource>> GetAsync(string errorSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = await _errorSummaryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ErrorSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ErrorSummaries resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> is null. </exception>
        public virtual Response<ErrorSummaryResource> Get(string errorSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = _errorSummaryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ErrorSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the ErrorSummaries resource in springbootsites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_ListBySite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ErrorSummaryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ErrorSummaryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _errorSummaryRestClient.CreateListBySiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _errorSummaryRestClient.CreateListBySiteNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ErrorSummaryResource(Client, ErrorSummaryData.DeserializeErrorSummaryData(e)), _errorSummaryClientDiagnostics, Pipeline, "ErrorSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the ErrorSummaries resource in springbootsites.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_ListBySite</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ErrorSummaryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ErrorSummaryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _errorSummaryRestClient.CreateListBySiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _errorSummaryRestClient.CreateListBySiteNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ErrorSummaryResource(Client, ErrorSummaryData.DeserializeErrorSummaryData(e)), _errorSummaryClientDiagnostics, Pipeline, "ErrorSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string errorSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _errorSummaryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/ErrorSummaries/{errorSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ErrorSummaries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="errorSummaryName"> The name of error summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="errorSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="errorSummaryName"/> is null. </exception>
        public virtual Response<bool> Exists(string errorSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(errorSummaryName, nameof(errorSummaryName));

            using var scope = _errorSummaryClientDiagnostics.CreateScope("ErrorSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = _errorSummaryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, errorSummaryName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ErrorSummaryResource> IEnumerable<ErrorSummaryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ErrorSummaryResource> IAsyncEnumerable<ErrorSummaryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
