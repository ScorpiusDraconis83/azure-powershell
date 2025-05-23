// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment operation properties.
    /// </summary>
    public partial class WhatIfOperationProperties
    {
        /// <summary>
        /// Initializes a new instance of the WhatIfOperationProperties class.
        /// </summary>
        public WhatIfOperationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WhatIfOperationProperties class.
        /// </summary>

        /// <param name="changes">List of resource changes predicted by What-If operation.
        /// </param>

        /// <param name="potentialChanges">List of resource changes predicted by What-If operation.
        /// </param>

        /// <param name="diagnostics">List of resource diagnostics detected by What-If operation.
        /// </param>
        public WhatIfOperationProperties(System.Collections.Generic.IList<WhatIfChange> changes = default(System.Collections.Generic.IList<WhatIfChange>), System.Collections.Generic.IList<WhatIfChange> potentialChanges = default(System.Collections.Generic.IList<WhatIfChange>), System.Collections.Generic.IList<DeploymentDiagnosticsDefinition> diagnostics = default(System.Collections.Generic.IList<DeploymentDiagnosticsDefinition>))

        {
            this.Changes = changes;
            this.PotentialChanges = potentialChanges;
            this.Diagnostics = diagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of resource changes predicted by What-If operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "changes")]
        public System.Collections.Generic.IList<WhatIfChange> Changes {get; set; }

        /// <summary>
        /// Gets or sets list of resource changes predicted by What-If operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "potentialChanges")]
        public System.Collections.Generic.IList<WhatIfChange> PotentialChanges {get; set; }

        /// <summary>
        /// Gets list of resource diagnostics detected by What-If operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diagnostics")]
        public System.Collections.Generic.IList<DeploymentDiagnosticsDefinition> Diagnostics {get; private set; }
    }
}