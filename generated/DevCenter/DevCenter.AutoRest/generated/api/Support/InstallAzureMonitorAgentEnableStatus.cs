// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support
{

    /// <summary>
    /// Setting to be used when determining whether to install the Azure Monitor Agent service on Dev Boxes that belong to this
    /// dev center.
    /// </summary>
    public partial struct InstallAzureMonitorAgentEnableStatus :
        System.IEquatable<InstallAzureMonitorAgentEnableStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus Enabled = @"Enabled";

        /// <summary>
        /// the value for an instance of the <see cref="InstallAzureMonitorAgentEnableStatus" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to InstallAzureMonitorAgentEnableStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InstallAzureMonitorAgentEnableStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new InstallAzureMonitorAgentEnableStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type InstallAzureMonitorAgentEnableStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type InstallAzureMonitorAgentEnableStatus (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is InstallAzureMonitorAgentEnableStatus && Equals((InstallAzureMonitorAgentEnableStatus)obj);
        }

        /// <summary>Returns hashCode for enum InstallAzureMonitorAgentEnableStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="InstallAzureMonitorAgentEnableStatus"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private InstallAzureMonitorAgentEnableStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for InstallAzureMonitorAgentEnableStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to InstallAzureMonitorAgentEnableStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="InstallAzureMonitorAgentEnableStatus" />.</param>

        public static implicit operator InstallAzureMonitorAgentEnableStatus(string value)
        {
            return new InstallAzureMonitorAgentEnableStatus(value);
        }

        /// <summary>Implicit operator to convert InstallAzureMonitorAgentEnableStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="InstallAzureMonitorAgentEnableStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum InstallAzureMonitorAgentEnableStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum InstallAzureMonitorAgentEnableStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.InstallAzureMonitorAgentEnableStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}