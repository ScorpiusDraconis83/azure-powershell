// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.HDInsight
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for LocationsOperations
    /// </summary>
    public static partial class LocationsOperationsExtensions
    {
        /// <summary>
        /// Gets the capabilities for the specified location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        public static CapabilitiesResult GetCapabilities(this ILocationsOperations operations, string location)
        {
                return ((ILocationsOperations)operations).GetCapabilitiesAsync(location).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the capabilities for the specified location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapabilitiesResult> GetCapabilitiesAsync(this ILocationsOperations operations, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetCapabilitiesWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the usages for the specified location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        public static UsagesListResult ListUsages(this ILocationsOperations operations, string location)
        {
                return ((ILocationsOperations)operations).ListUsagesAsync(location).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the usages for the specified location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<UsagesListResult> ListUsagesAsync(this ILocationsOperations operations, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListUsagesWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the billingSpecs for the specified subscription and location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        public static BillingResponseListResult ListBillingSpecs(this ILocationsOperations operations, string location)
        {
                return ((ILocationsOperations)operations).ListBillingSpecsAsync(location).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the billingSpecs for the specified subscription and location.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<BillingResponseListResult> ListBillingSpecsAsync(this ILocationsOperations operations, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBillingSpecsWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get the async operation status.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='operationId'>
        /// The long running operation id.
        /// </param>
        public static AsyncOperationResult GetAzureAsyncOperationStatus(this ILocationsOperations operations, string location, string operationId)
        {
                return ((ILocationsOperations)operations).GetAzureAsyncOperationStatusAsync(location, operationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the async operation status.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='operationId'>
        /// The long running operation id.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<AsyncOperationResult> GetAzureAsyncOperationStatusAsync(this ILocationsOperations operations, string location, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetAzureAsyncOperationStatusWithHttpMessagesAsync(location, operationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Check the cluster name is available or not.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        public static NameAvailabilityCheckResult CheckNameAvailability(this ILocationsOperations operations, string location, string name = default(string), string type = default(string))
        {
                return ((ILocationsOperations)operations).CheckNameAvailabilityAsync(location, name, type).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check the cluster name is available or not.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NameAvailabilityCheckResult> CheckNameAvailabilityAsync(this ILocationsOperations operations, string location, string name = default(string), string type = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, name, type, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Validate the cluster create request spec is valid or not.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        public static ClusterCreateValidationResult ValidateClusterCreateRequest(this ILocationsOperations operations, string location, ClusterCreateRequestValidationParameters parameters)
        {
                return ((ILocationsOperations)operations).ValidateClusterCreateRequestAsync(location, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Validate the cluster create request spec is valid or not.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='location'>
        /// The Azure location (region) for which to make the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ClusterCreateValidationResult> ValidateClusterCreateRequestAsync(this ILocationsOperations operations, string location, ClusterCreateRequestValidationParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ValidateClusterCreateRequestWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
