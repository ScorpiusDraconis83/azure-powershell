// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Details of storage account to be used for the Registry</summary>
    public partial class StorageAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetails,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetailsInternal
    {

        /// <summary>Internal Acessors for SystemCreatedStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccount Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetailsInternal.SystemCreatedStorageAccount { get => (this._systemCreatedStorageAccount = this._systemCreatedStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SystemCreatedStorageAccount()); set { {_systemCreatedStorageAccount = value;} } }

        /// <summary>Internal Acessors for SystemCreatedStorageAccountArmResourceId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IArmResourceId Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetailsInternal.SystemCreatedStorageAccountArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).ArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).ArmResourceId = value; }

        /// <summary>Internal Acessors for UserCreatedStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccount Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetailsInternal.UserCreatedStorageAccount { get => (this._userCreatedStorageAccount = this._userCreatedStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.UserCreatedStorageAccount()); set { {_userCreatedStorageAccount = value;} } }

        /// <summary>Internal Acessors for UserCreatedStorageAccountArmResourceId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IArmResourceId Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IStorageAccountDetailsInternal.UserCreatedStorageAccountArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccountInternal)UserCreatedStorageAccount).ArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccountInternal)UserCreatedStorageAccount).ArmResourceId = value; }

        /// <summary>Backing field for <see cref="SystemCreatedStorageAccount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccount _systemCreatedStorageAccount;

        /// <summary>Details of system created storage account to be used for the registry</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccount SystemCreatedStorageAccount { get => (this._systemCreatedStorageAccount = this._systemCreatedStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SystemCreatedStorageAccount()); set => this._systemCreatedStorageAccount = value; }

        /// <summary>Public blob access allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? SystemCreatedStorageAccountAllowBlobPublicAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).AllowBlobPublicAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).AllowBlobPublicAccess = value ?? default(bool); }

        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SystemCreatedStorageAccountArmResourceIdResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).ArmResourceIdResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).ArmResourceIdResourceId = value ?? null; }

        /// <summary>HNS enabled for storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? SystemCreatedStorageAccountHnsEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountHnsEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountHnsEnabled = value ?? default(bool); }

        /// <summary>Name of the storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SystemCreatedStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountName = value ?? null; }

        /// <summary>
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string SystemCreatedStorageAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccountInternal)SystemCreatedStorageAccount).StorageAccountType = value ?? null; }

        /// <summary>Backing field for <see cref="UserCreatedStorageAccount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccount _userCreatedStorageAccount;

        /// <summary>Details of user created storage account to be used for the registry</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccount UserCreatedStorageAccount { get => (this._userCreatedStorageAccount = this._userCreatedStorageAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.UserCreatedStorageAccount()); set => this._userCreatedStorageAccount = value; }

        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string UserCreatedStorageAccountArmResourceIdResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccountInternal)UserCreatedStorageAccount).ArmResourceIdResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccountInternal)UserCreatedStorageAccount).ArmResourceIdResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="StorageAccountDetails" /> instance.</summary>
        public StorageAccountDetails()
        {

        }
    }
    /// Details of storage account to be used for the Registry
    public partial interface IStorageAccountDetails :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Public blob access allowed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public blob access allowed",
        SerializedName = @"allowBlobPublicAccess",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemCreatedStorageAccountAllowBlobPublicAccess { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arm ResourceId is in the format ""/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}""
        or ""/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}""",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SystemCreatedStorageAccountArmResourceIdResourceId { get; set; }
        /// <summary>HNS enabled for storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HNS enabled for storage account",
        SerializedName = @"storageAccountHnsEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemCreatedStorageAccountHnsEnabled { get; set; }
        /// <summary>Name of the storage account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the storage account",
        SerializedName = @"storageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string SystemCreatedStorageAccountName { get; set; }
        /// <summary>
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allowed values:
        ""Standard_LRS"",
        ""Standard_GRS"",
        ""Standard_RAGRS"",
        ""Standard_ZRS"",
        ""Standard_GZRS"",
        ""Standard_RAGZRS"",
        ""Premium_LRS"",
        ""Premium_ZRS""",
        SerializedName = @"storageAccountType",
        PossibleTypes = new [] { typeof(string) })]
        string SystemCreatedStorageAccountType { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arm ResourceId is in the format ""/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}""
        or ""/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}""",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserCreatedStorageAccountArmResourceIdResourceId { get; set; }

    }
    /// Details of storage account to be used for the Registry
    internal partial interface IStorageAccountDetailsInternal

    {
        /// <summary>Details of system created storage account to be used for the registry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISystemCreatedStorageAccount SystemCreatedStorageAccount { get; set; }
        /// <summary>Public blob access allowed</summary>
        bool? SystemCreatedStorageAccountAllowBlobPublicAccess { get; set; }
        /// <summary>This is populated once the storage account is created.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IArmResourceId SystemCreatedStorageAccountArmResourceId { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        string SystemCreatedStorageAccountArmResourceIdResourceId { get; set; }
        /// <summary>HNS enabled for storage account</summary>
        bool? SystemCreatedStorageAccountHnsEnabled { get; set; }
        /// <summary>Name of the storage account</summary>
        string SystemCreatedStorageAccountName { get; set; }
        /// <summary>
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </summary>
        string SystemCreatedStorageAccountType { get; set; }
        /// <summary>Details of user created storage account to be used for the registry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IUserCreatedStorageAccount UserCreatedStorageAccount { get; set; }
        /// <summary>ARM ResourceId of a resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IArmResourceId UserCreatedStorageAccountArmResourceId { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        string UserCreatedStorageAccountArmResourceIdResourceId { get; set; }

    }
}