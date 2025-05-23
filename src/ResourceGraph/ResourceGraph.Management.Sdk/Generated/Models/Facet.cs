// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using System.Linq;

    /// <summary>
    /// A facet containing additional statistics on the response of a query. Can be
    /// either FacetResult or FacetError.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Facet")]
    public partial class Facet
    {
        /// <summary>
        /// Initializes a new instance of the Facet class.
        /// </summary>
        public Facet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Facet class.
        /// </summary>

        /// <param name="expression">Facet expression, same as in the corresponding facet request.
        /// </param>
        public Facet(string expression)

        {
            this.Expression = expression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets facet expression, same as in the corresponding facet request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expression")]
        public string Expression {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Expression == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Expression");
            }

        }
    }
}