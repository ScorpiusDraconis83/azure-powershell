// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Query parameter to enumerate jobs.
    /// </summary>
    public partial class JobQueryParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>
        public JobQueryParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>

        /// <param name="startTime">Date time to get jobs from.
        /// </param>

        /// <param name="endTime">Date time to get jobs upto.
        /// </param>

        /// <param name="fabricId">The Id of the fabric to search jobs under.
        /// </param>

        /// <param name="affectedObjectTypes">The type of objects.
        /// </param>

        /// <param name="jobStatus">The states of the job to be filtered can be in.
        /// </param>

        /// <param name="jobOutputType">The output type of the jobs.
        /// Possible values include: &#39;Json&#39;, &#39;Xml&#39;, &#39;Excel&#39;</param>

        /// <param name="jobName">The job Name.
        /// </param>

        /// <param name="timezoneOffset">The timezone offset for the location of the request (in minutes).
        /// </param>
        public JobQueryParameter(string startTime = default(string), string endTime = default(string), string fabricId = default(string), string affectedObjectTypes = default(string), string jobStatus = default(string), string jobOutputType = default(string), string jobName = default(string), double? timezoneOffset = default(double?))

        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.FabricId = fabricId;
            this.AffectedObjectTypes = affectedObjectTypes;
            this.JobStatus = jobStatus;
            this.JobOutputType = jobOutputType;
            this.JobName = jobName;
            this.TimezoneOffset = timezoneOffset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets date time to get jobs from.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public string StartTime {get; set; }

        /// <summary>
        /// Gets or sets date time to get jobs upto.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public string EndTime {get; set; }

        /// <summary>
        /// Gets or sets the Id of the fabric to search jobs under.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricId")]
        public string FabricId {get; set; }

        /// <summary>
        /// Gets or sets the type of objects.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affectedObjectTypes")]
        public string AffectedObjectTypes {get; set; }

        /// <summary>
        /// Gets or sets the states of the job to be filtered can be in.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobStatus")]
        public string JobStatus {get; set; }

        /// <summary>
        /// Gets or sets the output type of the jobs. Possible values include: &#39;Json&#39;, &#39;Xml&#39;, &#39;Excel&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobOutputType")]
        public string JobOutputType {get; set; }

        /// <summary>
        /// Gets or sets the job Name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobName")]
        public string JobName {get; set; }

        /// <summary>
        /// Gets or sets the timezone offset for the location of the request (in
        /// minutes).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timezoneOffset")]
        public double? TimezoneOffset {get; set; }
    }
}