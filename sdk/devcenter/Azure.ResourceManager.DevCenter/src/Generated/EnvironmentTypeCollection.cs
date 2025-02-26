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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="EnvironmentTypeResource" /> and their operations.
    /// Each <see cref="EnvironmentTypeResource" /> in the collection will belong to the same instance of <see cref="DevCenterResource" />.
    /// To get an <see cref="EnvironmentTypeCollection" /> instance call the GetEnvironmentTypes method from an instance of <see cref="DevCenterResource" />.
    /// </summary>
    public partial class EnvironmentTypeCollection : ArmCollection, IEnumerable<EnvironmentTypeResource>, IAsyncEnumerable<EnvironmentTypeResource>
    {
        private readonly ClientDiagnostics _environmentTypeClientDiagnostics;
        private readonly EnvironmentTypesRestOperations _environmentTypeRestClient;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentTypeCollection"/> class for mocking. </summary>
        protected EnvironmentTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EnvironmentTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", EnvironmentTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EnvironmentTypeResource.ResourceType, out string environmentTypeApiVersion);
            _environmentTypeRestClient = new EnvironmentTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, environmentTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="data"> Represents an Environment Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EnvironmentTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string environmentTypeName, EnvironmentTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _environmentTypeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<EnvironmentTypeResource>(Response.FromValue(new EnvironmentTypeResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="data"> Represents an Environment Type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EnvironmentTypeResource> CreateOrUpdate(WaitUntil waitUntil, string environmentTypeName, EnvironmentTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _environmentTypeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, data, cancellationToken);
                var operation = new DevCenterArmOperation<EnvironmentTypeResource>(Response.FromValue(new EnvironmentTypeResource(Client, response), response.GetRawResponse()));
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
        /// Gets an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<EnvironmentTypeResource>> GetAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _environmentTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<EnvironmentTypeResource> Get(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _environmentTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists environment types for the devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnvironmentTypeResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _environmentTypeRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _environmentTypeRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EnvironmentTypeResource(Client, EnvironmentTypeData.DeserializeEnvironmentTypeData(e)), _environmentTypeClientDiagnostics, Pipeline, "EnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists environment types for the devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_ListByDevCenter</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnvironmentTypeResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _environmentTypeRestClient.CreateListByDevCenterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _environmentTypeRestClient.CreateListByDevCenterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EnvironmentTypeResource(Client, EnvironmentTypeData.DeserializeEnvironmentTypeData(e)), _environmentTypeClientDiagnostics, Pipeline, "EnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _environmentTypeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/environmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _environmentTypeClientDiagnostics.CreateScope("EnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _environmentTypeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EnvironmentTypeResource> IEnumerable<EnvironmentTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EnvironmentTypeResource> IAsyncEnumerable<EnvironmentTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
