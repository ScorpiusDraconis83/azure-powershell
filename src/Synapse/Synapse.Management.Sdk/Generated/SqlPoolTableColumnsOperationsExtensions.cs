// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SqlPoolTableColumnsOperations
    /// </summary>
    public static partial class SqlPoolTableColumnsOperationsExtensions
    {
        /// <summary>
        /// Gets columns in a given table in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
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
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPoolColumn> ListByTableName(this ISqlPoolTableColumnsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolColumn> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolColumn>))
        {
                return ((ISqlPoolTableColumnsOperations)operations).ListByTableNameAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets columns in a given table in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
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
        /// <param name='schemaName'>
        /// The name of the schema.
        /// </param>
        /// <param name='tableName'>
        /// The name of the table.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPoolColumn>> ListByTableNameAsync(this ISqlPoolTableColumnsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolColumn> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<SqlPoolColumn>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByTableNameWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets columns in a given table in a SQL pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<SqlPoolColumn> ListByTableNameNext(this ISqlPoolTableColumnsOperations operations, string nextPageLink)
        {
                return ((ISqlPoolTableColumnsOperations)operations).ListByTableNameNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets columns in a given table in a SQL pool.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<SqlPoolColumn>> ListByTableNameNextAsync(this ISqlPoolTableColumnsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByTableNameNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
