// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SqlPoolsOperations
    /// </summary>
    public static partial class SqlPoolsOperationsExtensions
    {
        /// <summary>
        /// Get SQL pool properties
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Get(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).GetAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get SQL pool properties
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> GetAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Apply a partial update to a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Update(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolPatchInfo sqlPoolInfo)
        {
                return ((ISqlPoolsOperations)operations).UpdateAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Apply a partial update to a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> UpdateAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolPatchInfo sqlPoolInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Create(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPool sqlPoolInfo)
        {
                return ((ISqlPoolsOperations)operations).CreateAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> CreateAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPool sqlPoolInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Delete(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).DeleteAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> DeleteAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List all SQL pools
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPool> ListByWorkspace(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName)
        {
                return ((ISqlPoolsOperations)operations).ListByWorkspaceAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all SQL pools
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPool>> ListByWorkspaceAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Pause a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Pause(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).PauseAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pause a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> PauseAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.PauseWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Resume a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool Resume(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).ResumeAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Resume a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> ResumeAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ResumeWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Apply a partial update to a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool BeginUpdate(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolPatchInfo sqlPoolInfo)
        {
                return ((ISqlPoolsOperations)operations).BeginUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Apply a partial update to a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> BeginUpdateAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPoolPatchInfo sqlPoolInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool BeginCreate(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPool sqlPoolInfo)
        {
                return ((ISqlPoolsOperations)operations).BeginCreateAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> BeginCreateAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, SqlPool sqlPoolInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, sqlPoolInfo, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool BeginDelete(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).BeginDeleteAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> BeginDeleteAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Pause a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool BeginPause(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).BeginPauseAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pause a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> BeginPauseAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginPauseWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Resume a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        public static SqlPool BeginResume(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
                return ((ISqlPoolsOperations)operations).BeginResumeAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Resume a SQL pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> BeginResumeAsync(this ISqlPoolsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginResumeWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List all SQL pools
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPool> ListByWorkspaceNext(this ISqlPoolsOperations operations, string nextPageLink)
        {
                return ((ISqlPoolsOperations)operations).ListByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all SQL pools
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPool>> ListByWorkspaceNextAsync(this ISqlPoolsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
