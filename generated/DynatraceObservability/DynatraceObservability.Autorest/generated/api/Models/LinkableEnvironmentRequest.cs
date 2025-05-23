// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Extensions;

    /// <summary>Request for getting all the linkable environments for a user</summary>
    public partial class LinkableEnvironmentRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.ILinkableEnvironmentRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.ILinkableEnvironmentRequestInternal
    {

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>Azure region in which we want to link the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant Id of the user in which they want to link the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Backing field for <see cref="UserPrincipal" /> property.</summary>
        private string _userPrincipal;

        /// <summary>user principal id of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string UserPrincipal { get => this._userPrincipal; set => this._userPrincipal = value; }

        /// <summary>Creates an new <see cref="LinkableEnvironmentRequest" /> instance.</summary>
        public LinkableEnvironmentRequest()
        {

        }
    }
    /// Request for getting all the linkable environments for a user
    public partial interface ILinkableEnvironmentRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IJsonSerializable
    {
        /// <summary>Azure region in which we want to link the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure region in which we want to link the environment",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Tenant Id of the user in which they want to link the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant Id of the user in which they want to link the environment",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>user principal id of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"user principal id of the user",
        SerializedName = @"userPrincipal",
        PossibleTypes = new [] { typeof(string) })]
        string UserPrincipal { get; set; }

    }
    /// Request for getting all the linkable environments for a user
    internal partial interface ILinkableEnvironmentRequestInternal

    {
        /// <summary>Azure region in which we want to link the environment</summary>
        string Region { get; set; }
        /// <summary>Tenant Id of the user in which they want to link the environment</summary>
        string TenantId { get; set; }
        /// <summary>user principal id of the user</summary>
        string UserPrincipal { get; set; }

    }
}