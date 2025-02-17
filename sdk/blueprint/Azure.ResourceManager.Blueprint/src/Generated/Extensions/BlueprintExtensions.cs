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
using Azure.ResourceManager.Blueprint.Mocking;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Blueprint. </summary>
    public static partial class BlueprintExtensions
    {
        private static MockableBlueprintArmClient GetMockableBlueprintArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableBlueprintArmClient(client0));
        }

        /// <summary>
        /// Gets a collection of BlueprintResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprints(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of BlueprintResources and their operations over a BlueprintResource. </returns>
        public static BlueprintCollection GetBlueprints(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetBlueprints(scope);
        }

        /// <summary>
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprintAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BlueprintResource>> GetBlueprintAsync(this ArmClient client, ResourceIdentifier scope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableBlueprintArmClient(client).GetBlueprintAsync(scope, blueprintName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Blueprints_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprint(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<BlueprintResource> GetBlueprint(this ArmClient client, ResourceIdentifier scope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetBlueprint(scope, blueprintName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of AssignmentResources in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetAssignments(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> An object representing collection of AssignmentResources and their operations over a AssignmentResource. </returns>
        public static AssignmentCollection GetAssignments(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetAssignments(scope);
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetAssignmentAsync(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AssignmentResource>> GetAssignmentAsync(this ArmClient client, ResourceIdentifier scope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return await GetMockableBlueprintArmClient(client).GetAssignmentAsync(scope, assignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetAssignment(ResourceIdentifier,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> or <paramref name="assignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AssignmentResource> GetAssignment(this ArmClient client, ResourceIdentifier scope, string assignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetAssignment(scope, assignmentName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlueprintResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprintResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BlueprintResource" /> object. </returns>
        public static BlueprintResource GetBlueprintResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetBlueprintResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlueprintArtifactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintArtifactResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintArtifactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprintArtifactResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BlueprintArtifactResource" /> object. </returns>
        public static BlueprintArtifactResource GetBlueprintArtifactResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetBlueprintArtifactResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BlueprintVersionArtifactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintVersionArtifactResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintVersionArtifactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetBlueprintVersionArtifactResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BlueprintVersionArtifactResource" /> object. </returns>
        public static BlueprintVersionArtifactResource GetBlueprintVersionArtifactResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetBlueprintVersionArtifactResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PublishedBlueprintResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PublishedBlueprintResource.CreateResourceIdentifier" /> to create a <see cref="PublishedBlueprintResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetPublishedBlueprintResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PublishedBlueprintResource" /> object. </returns>
        public static PublishedBlueprintResource GetPublishedBlueprintResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetPublishedBlueprintResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssignmentResource.CreateResourceIdentifier" /> to create an <see cref="AssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetAssignmentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AssignmentResource" /> object. </returns>
        public static AssignmentResource GetAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetAssignmentResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AssignmentOperationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssignmentOperationResource.CreateResourceIdentifier" /> to create an <see cref="AssignmentOperationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableBlueprintArmClient.GetAssignmentOperationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AssignmentOperationResource" /> object. </returns>
        public static AssignmentOperationResource GetAssignmentOperationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableBlueprintArmClient(client).GetAssignmentOperationResource(id);
        }
    }
}
