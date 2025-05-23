// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Extensions;

    /// <summary>Describes the virtual machines used to build and validate images</summary>
    public partial class ImageTemplateVMProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateVMProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateVMProfileInternal
    {

        /// <summary>Internal Acessors for VnetConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfig Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IImageTemplateVMProfileInternal.VnetConfig { get => (this._vnetConfig = this._vnetConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.VirtualNetworkConfig()); set { {_vnetConfig = value;} } }

        /// <summary>Backing field for <see cref="OSDiskSizeGb" /> property.</summary>
        private int? _oSDiskSizeGb;

        /// <summary>
        /// Size of the OS disk in GB. Omit or specify 0 to use Azure's default OS disk size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public int? OSDiskSizeGb { get => this._oSDiskSizeGb; set => this._oSDiskSizeGb = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private System.Collections.Generic.List<string> _userAssignedIdentity;

        /// <summary>
        /// Optional array of resource IDs of user assigned managed identities to be configured on the build VM and validation VM.
        /// This may include the identity of the image template.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UserAssignedIdentity { get => this._userAssignedIdentity; set => this._userAssignedIdentity = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        /// <summary>
        /// Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default
        /// (Standard_D1_v2 for Gen1 images and Standard_D2ds_v4 for Gen2 images).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Backing field for <see cref="VnetConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfig _vnetConfig;

        /// <summary>
        /// Optional configuration of the virtual network to use to deploy the build VM and validation VM in. Omit if no specific
        /// virtual network needs to be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfig VnetConfig { get => (this._vnetConfig = this._vnetConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.VirtualNetworkConfig()); set => this._vnetConfig = value; }

        /// <summary>
        /// Size of the proxy virtual machine used to pass traffic to the build VM and validation VM. Omit or specify empty string
        /// to use the default (Standard_A1_v2).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Inlined)]
        public string VnetConfigProxyVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfigInternal)VnetConfig).ProxyVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfigInternal)VnetConfig).ProxyVMSize = value ?? null; }

        /// <summary>Resource id of a pre-existing subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Inlined)]
        public string VnetConfigSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfigInternal)VnetConfig).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfigInternal)VnetConfig).SubnetId = value ?? null; }

        /// <summary>Creates an new <see cref="ImageTemplateVMProfile" /> instance.</summary>
        public ImageTemplateVMProfile()
        {

        }
    }
    /// Describes the virtual machines used to build and validate images
    public partial interface IImageTemplateVMProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Size of the OS disk in GB. Omit or specify 0 to use Azure's default OS disk size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of the OS disk in GB. Omit or specify 0 to use Azure's default OS disk size.",
        SerializedName = @"osDiskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? OSDiskSizeGb { get; set; }
        /// <summary>
        /// Optional array of resource IDs of user assigned managed identities to be configured on the build VM and validation VM.
        /// This may include the identity of the image template.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional array of resource IDs of user assigned managed identities to be configured on the build VM and validation VM. This may include the identity of the image template.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UserAssignedIdentity { get; set; }
        /// <summary>
        /// Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default
        /// (Standard_D1_v2 for Gen1 images and Standard_D2ds_v4 for Gen2 images).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default (Standard_D1_v2 for Gen1 images and Standard_D2ds_v4 for Gen2 images).",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VMSize { get; set; }
        /// <summary>
        /// Size of the proxy virtual machine used to pass traffic to the build VM and validation VM. Omit or specify empty string
        /// to use the default (Standard_A1_v2).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of the proxy virtual machine used to pass traffic to the build VM and validation VM. Omit or specify empty string to use the default (Standard_A1_v2).",
        SerializedName = @"proxyVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigProxyVMSize { get; set; }
        /// <summary>Resource id of a pre-existing subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource id of a pre-existing subnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string VnetConfigSubnetId { get; set; }

    }
    /// Describes the virtual machines used to build and validate images
    internal partial interface IImageTemplateVMProfileInternal

    {
        /// <summary>
        /// Size of the OS disk in GB. Omit or specify 0 to use Azure's default OS disk size.
        /// </summary>
        int? OSDiskSizeGb { get; set; }
        /// <summary>
        /// Optional array of resource IDs of user assigned managed identities to be configured on the build VM and validation VM.
        /// This may include the identity of the image template.
        /// </summary>
        System.Collections.Generic.List<string> UserAssignedIdentity { get; set; }
        /// <summary>
        /// Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default
        /// (Standard_D1_v2 for Gen1 images and Standard_D2ds_v4 for Gen2 images).
        /// </summary>
        string VMSize { get; set; }
        /// <summary>
        /// Optional configuration of the virtual network to use to deploy the build VM and validation VM in. Omit if no specific
        /// virtual network needs to be used.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.IVirtualNetworkConfig VnetConfig { get; set; }
        /// <summary>
        /// Size of the proxy virtual machine used to pass traffic to the build VM and validation VM. Omit or specify empty string
        /// to use the default (Standard_A1_v2).
        /// </summary>
        string VnetConfigProxyVMSize { get; set; }
        /// <summary>Resource id of a pre-existing subnet.</summary>
        string VnetConfigSubnetId { get; set; }

    }
}