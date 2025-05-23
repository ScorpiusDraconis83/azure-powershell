// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Extensions;

    /// <summary>Domain Security Settings</summary>
    public partial class DomainSecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IDomainSecuritySettings,
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IDomainSecuritySettingsInternal
    {

        /// <summary>Backing field for <see cref="NtlmV1" /> property.</summary>
        private string _ntlmV1;

        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string NtlmV1 { get => this._ntlmV1; set => this._ntlmV1 = value; }

        /// <summary>Backing field for <see cref="SyncKerberosPassword" /> property.</summary>
        private string _syncKerberosPassword;

        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string SyncKerberosPassword { get => this._syncKerberosPassword; set => this._syncKerberosPassword = value; }

        /// <summary>Backing field for <see cref="SyncNtlmPassword" /> property.</summary>
        private string _syncNtlmPassword;

        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string SyncNtlmPassword { get => this._syncNtlmPassword; set => this._syncNtlmPassword = value; }

        /// <summary>Backing field for <see cref="SyncOnPremPassword" /> property.</summary>
        private string _syncOnPremPassword;

        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string SyncOnPremPassword { get => this._syncOnPremPassword; set => this._syncOnPremPassword = value; }

        /// <summary>Backing field for <see cref="TlsV1" /> property.</summary>
        private string _tlsV1;

        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string TlsV1 { get => this._tlsV1; set => this._tlsV1 = value; }

        /// <summary>Creates an new <see cref="DomainSecuritySettings" /> instance.</summary>
        public DomainSecuritySettings()
        {

        }
    }
    /// Domain Security Settings
    public partial interface IDomainSecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.IJsonSerializable
    {
        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag to determine whether or not NtlmV1 is enabled or disabled.",
        SerializedName = @"ntlmV1",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string NtlmV1 { get; set; }
        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.",
        SerializedName = @"syncKerberosPasswords",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncKerberosPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.",
        SerializedName = @"syncNtlmPasswords",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncNtlmPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.",
        SerializedName = @"syncOnPremPasswords",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncOnPremPassword { get; set; }
        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A flag to determine whether or not TlsV1 is enabled or disabled.",
        SerializedName = @"tlsV1",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string TlsV1 { get; set; }

    }
    /// Domain Security Settings
    internal partial interface IDomainSecuritySettingsInternal

    {
        /// <summary>A flag to determine whether or not NtlmV1 is enabled or disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string NtlmV1 { get; set; }
        /// <summary>
        /// A flag to determine whether or not SyncKerberosPasswords is enabled or disabled.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncKerberosPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncNtlmPasswords is enabled or disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncNtlmPassword { get; set; }
        /// <summary>A flag to determine whether or not SyncOnPremPasswords is enabled or disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string SyncOnPremPassword { get; set; }
        /// <summary>A flag to determine whether or not TlsV1 is enabled or disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string TlsV1 { get; set; }

    }
}