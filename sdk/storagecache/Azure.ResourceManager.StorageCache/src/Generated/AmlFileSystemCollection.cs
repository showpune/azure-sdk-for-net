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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing a collection of <see cref="AmlFileSystemResource" /> and their operations.
    /// Each <see cref="AmlFileSystemResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="AmlFileSystemCollection" /> instance call the GetAmlFileSystems method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class AmlFileSystemCollection : ArmCollection, IEnumerable<AmlFileSystemResource>, IAsyncEnumerable<AmlFileSystemResource>
    {
        private readonly ClientDiagnostics _amlFileSystemamlFilesystemsClientDiagnostics;
        private readonly AmlFilesystemsRestOperations _amlFileSystemamlFilesystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AmlFileSystemCollection"/> class for mocking. </summary>
        protected AmlFileSystemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AmlFileSystemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AmlFileSystemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _amlFileSystemamlFilesystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageCache", AmlFileSystemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AmlFileSystemResource.ResourceType, out string amlFileSystemamlFilesystemsApiVersion);
            _amlFileSystemamlFilesystemsRestClient = new AmlFilesystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, amlFileSystemamlFilesystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="data"> Object containing the user-selectable properties of the AML file system. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AmlFileSystemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string amlFileSystemName, AmlFileSystemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _amlFileSystemamlFilesystemsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageCacheArmOperation<AmlFileSystemResource>(new AmlFileSystemOperationSource(Client), _amlFileSystemamlFilesystemsClientDiagnostics, Pipeline, _amlFileSystemamlFilesystemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="data"> Object containing the user-selectable properties of the AML file system. If read-only properties are included, they must match the existing values of those properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AmlFileSystemResource> CreateOrUpdate(WaitUntil waitUntil, string amlFileSystemName, AmlFileSystemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _amlFileSystemamlFilesystemsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, data, cancellationToken);
                var operation = new StorageCacheArmOperation<AmlFileSystemResource>(new AmlFileSystemOperationSource(Client), _amlFileSystemamlFilesystemsClientDiagnostics, Pipeline, _amlFileSystemamlFilesystemsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        public virtual async Task<Response<AmlFileSystemResource>> GetAsync(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.Get");
            scope.Start();
            try
            {
                var response = await _amlFileSystemamlFilesystemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AmlFileSystemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns an AML file system.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        public virtual Response<AmlFileSystemResource> Get(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.Get");
            scope.Start();
            try
            {
                var response = _amlFileSystemamlFilesystemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AmlFileSystemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AmlFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AmlFileSystemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _amlFileSystemamlFilesystemsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _amlFileSystemamlFilesystemsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AmlFileSystemResource(Client, AmlFileSystemData.DeserializeAmlFileSystemData(e)), _amlFileSystemamlFilesystemsClientDiagnostics, Pipeline, "AmlFileSystemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AmlFileSystemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AmlFileSystemResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _amlFileSystemamlFilesystemsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _amlFileSystemamlFilesystemsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AmlFileSystemResource(Client, AmlFileSystemData.DeserializeAmlFileSystemData(e)), _amlFileSystemamlFilesystemsClientDiagnostics, Pipeline, "AmlFileSystemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _amlFileSystemamlFilesystemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageCache/amlFilesystems/{amlFilesystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="amlFileSystemName"> Name for the AML file system. Allows alphanumerics, underscores, and hyphens. Start and end with alphanumeric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="amlFileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="amlFileSystemName"/> is null. </exception>
        public virtual Response<bool> Exists(string amlFileSystemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(amlFileSystemName, nameof(amlFileSystemName));

            using var scope = _amlFileSystemamlFilesystemsClientDiagnostics.CreateScope("AmlFileSystemCollection.Exists");
            scope.Start();
            try
            {
                var response = _amlFileSystemamlFilesystemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, amlFileSystemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AmlFileSystemResource> IEnumerable<AmlFileSystemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AmlFileSystemResource> IAsyncEnumerable<AmlFileSystemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
