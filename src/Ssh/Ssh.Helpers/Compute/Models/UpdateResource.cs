// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// The Update Resource model definition.
    /// </summary>
    public partial class UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the UpdateResource class.
        /// </summary>
        public UpdateResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateResource class.
        /// </summary>

        /// <param name="tags">Resource tags
        /// </param>
        public UpdateResource(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }
    }
}