// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridCompute.Mocking;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridCompute. </summary>
    public static partial class HybridComputeExtensions
    {
        private static MockableHybridComputeArmClient GetMockableHybridComputeArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHybridComputeArmClient(client0));
        }

        private static MockableHybridComputeResourceGroupResource GetMockableHybridComputeResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHybridComputeResourceGroupResource(client, resource.Id));
        }

        private static MockableHybridComputeSubscriptionResource GetMockableHybridComputeSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHybridComputeSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetHybridComputeMachineResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridComputeMachineResource" /> object. </returns>
        public static HybridComputeMachineResource GetHybridComputeMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetHybridComputeMachineResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineExtensionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetHybridComputeMachineExtensionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridComputeMachineExtensionResource" /> object. </returns>
        public static HybridComputeMachineExtensionResource GetHybridComputeMachineExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetHybridComputeMachineExtensionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExtensionValueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExtensionValueResource.CreateResourceIdentifier" /> to create an <see cref="ExtensionValueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetExtensionValueResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ExtensionValueResource" /> object. </returns>
        public static ExtensionValueResource GetExtensionValueResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetExtensionValueResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkScopeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkScopeResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkScopeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetHybridComputePrivateLinkScopeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkScopeResource" /> object. </returns>
        public static HybridComputePrivateLinkScopeResource GetHybridComputePrivateLinkScopeResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetHybridComputePrivateLinkScopeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetHybridComputePrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkResource" /> object. </returns>
        public static HybridComputePrivateLinkResource GetHybridComputePrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetHybridComputePrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeArmClient.GetHybridComputePrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridComputePrivateEndpointConnectionResource" /> object. </returns>
        public static HybridComputePrivateEndpointConnectionResource GetHybridComputePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridComputeArmClient(client).GetHybridComputePrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of HybridComputeMachineResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputeMachines()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HybridComputeMachineResources and their operations over a HybridComputeMachineResource. </returns>
        public static HybridComputeMachineCollection GetHybridComputeMachines(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputeMachines();
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputeMachineAsync(string,InstanceViewType?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="machineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HybridComputeMachineResource>> GetHybridComputeMachineAsync(this ResourceGroupResource resourceGroupResource, string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputeMachineAsync(machineName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputeMachine(string,InstanceViewType?,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="machineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HybridComputeMachineResource> GetHybridComputeMachine(this ResourceGroupResource resourceGroupResource, string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputeMachine(machineName, expand, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of HybridComputePrivateLinkScopeResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputePrivateLinkScopes()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HybridComputePrivateLinkScopeResources and their operations over a HybridComputePrivateLinkScopeResource. </returns>
        public static HybridComputePrivateLinkScopeCollection GetHybridComputePrivateLinkScopes(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputePrivateLinkScopes();
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputePrivateLinkScopeAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HybridComputePrivateLinkScopeResource>> GetHybridComputePrivateLinkScopeAsync(this ResourceGroupResource resourceGroupResource, string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputePrivateLinkScopeAsync(scopeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeResourceGroupResource.GetHybridComputePrivateLinkScope(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScope(this ResourceGroupResource resourceGroupResource, string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridComputeResourceGroupResource(resourceGroupResource).GetHybridComputePrivateLinkScope(scopeName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of ExtensionValueResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetExtensionValues(AzureLocation,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <param name="extensionType"> The extensionType of the Extension being received. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/>, <paramref name="publisher"/> or <paramref name="extensionType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisher"/> or <paramref name="extensionType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of ExtensionValueResources and their operations over a ExtensionValueResource. </returns>
        public static ExtensionValueCollection GetExtensionValues(this SubscriptionResource subscriptionResource, AzureLocation location, string publisher, string extensionType)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetExtensionValues(location, publisher, extensionType);
        }

        /// <summary>
        /// Gets an Extension Metadata based on location, publisher, extensionType and version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetExtensionValueAsync(AzureLocation,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <param name="extensionType"> The extensionType of the Extension being received. </param>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/>, <paramref name="publisher"/>, <paramref name="extensionType"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisher"/>, <paramref name="extensionType"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ExtensionValueResource>> GetExtensionValueAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string publisher, string extensionType, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetExtensionValueAsync(location, publisher, extensionType, version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an Extension Metadata based on location, publisher, extensionType and version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetExtensionValue(AzureLocation,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <param name="extensionType"> The extensionType of the Extension being received. </param>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/>, <paramref name="publisher"/>, <paramref name="extensionType"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisher"/>, <paramref name="extensionType"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ExtensionValueResource> GetExtensionValue(this SubscriptionResource subscriptionResource, AzureLocation location, string publisher, string extensionType, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetExtensionValue(location, publisher, extensionType, version, cancellationToken);
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetHybridComputeMachines(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HybridComputeMachineResource> GetHybridComputeMachinesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetHybridComputeMachinesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified subscription. Use the nextLink property in the response to get the next page of hybrid machines.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/machines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetHybridComputeMachines(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HybridComputeMachineResource> GetHybridComputeMachines(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetHybridComputeMachines(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetHybridComputePrivateLinkScopes(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetHybridComputePrivateLinkScopesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Azure Arc PrivateLinkScopes within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetHybridComputePrivateLinkScopes(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetHybridComputePrivateLinkScopes(cancellationToken);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope's validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetValidationDetailsPrivateLinkScope(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkScopeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="privateLinkScopeId"/> is null. </exception>
        public static async Task<Response<PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetValidationDetailsPrivateLinkScopeAsync(location, privateLinkScopeId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope's validation details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/privateLinkScopes/{privateLinkScopeId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_GetValidationDetails</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridComputeSubscriptionResource.GetValidationDetailsPrivateLinkScope(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the target resource. </param>
        /// <param name="privateLinkScopeId"> The id (Guid) of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkScopeId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="privateLinkScopeId"/> is null. </exception>
        public static Response<PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(this SubscriptionResource subscriptionResource, AzureLocation location, string privateLinkScopeId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridComputeSubscriptionResource(subscriptionResource).GetValidationDetailsPrivateLinkScope(location, privateLinkScopeId, cancellationToken);
        }
    }
}
