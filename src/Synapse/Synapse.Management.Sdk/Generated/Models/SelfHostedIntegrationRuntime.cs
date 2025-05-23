// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Self-hosted integration runtime.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SelfHosted")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SelfHostedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary>
        /// Initializes a new instance of the SelfHostedIntegrationRuntime class.
        /// </summary>
        public SelfHostedIntegrationRuntime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelfHostedIntegrationRuntime class.
        /// </summary>

        /// <param name="additionalProperties">Azure Synapse nested object which serves as a compute resource for
        /// activities.
        /// </param>

        /// <param name="description">Integration runtime description.
        /// </param>

        /// <param name="linkedInfo">Linked integration runtime type from data factory
        /// </param>

        /// <param name="selfContainedInteractiveAuthoringEnabled">An alternative option to ensure interactive authoring function when your
        /// self-hosted integration runtime is unable to establish a connection with
        /// Azure Relay.
        /// Possible values include: &#39;true&#39;, &#39;false&#39;</param>
        public SelfHostedIntegrationRuntime(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), LinkedIntegrationRuntimeType linkedInfo = default(LinkedIntegrationRuntimeType), bool? selfContainedInteractiveAuthoringEnabled = default(bool?))

        : base(additionalProperties, description)
        {
            this.LinkedInfo = linkedInfo;
            this.SelfContainedInteractiveAuthoringEnabled = selfContainedInteractiveAuthoringEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets linked integration runtime type from data factory
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.linkedInfo")]
        public LinkedIntegrationRuntimeType LinkedInfo {get; set; }

        /// <summary>
        /// Gets or sets an alternative option to ensure interactive authoring function
        /// when your self-hosted integration runtime is unable to establish a
        /// connection with Azure Relay. Possible values include: &#39;true&#39;, &#39;false&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.selfContainedInteractiveAuthoringEnabled")]
        public bool? SelfContainedInteractiveAuthoringEnabled {get; set; }
    }
}