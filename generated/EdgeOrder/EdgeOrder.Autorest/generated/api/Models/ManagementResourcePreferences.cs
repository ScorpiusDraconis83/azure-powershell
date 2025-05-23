// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Management resource preference to link device</summary>
    public partial class ManagementResourcePreferences :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IManagementResourcePreferences,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IManagementResourcePreferencesInternal
    {

        /// <summary>Backing field for <see cref="PreferredManagementResourceId" /> property.</summary>
        private string _preferredManagementResourceId;

        /// <summary>Customer preferred Management resource ARM ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string PreferredManagementResourceId { get => this._preferredManagementResourceId; set => this._preferredManagementResourceId = value; }

        /// <summary>Creates an new <see cref="ManagementResourcePreferences" /> instance.</summary>
        public ManagementResourcePreferences()
        {

        }
    }
    /// Management resource preference to link device
    public partial interface IManagementResourcePreferences :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Customer preferred Management resource ARM ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Customer preferred Management resource ARM ID",
        SerializedName = @"preferredManagementResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PreferredManagementResourceId { get; set; }

    }
    /// Management resource preference to link device
    internal partial interface IManagementResourcePreferencesInternal

    {
        /// <summary>Customer preferred Management resource ARM ID</summary>
        string PreferredManagementResourceId { get; set; }

    }
}