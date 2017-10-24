// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for ListOutputFiles operation.
    /// </summary>
    public partial class JobsListOutputFilesOptionsInner
    {
        /// <summary>
        /// Initializes a new instance of the JobsListOutputFilesOptionsInner
        /// class.
        /// </summary>
        public JobsListOutputFilesOptionsInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobsListOutputFilesOptionsInner
        /// class.
        /// </summary>
        /// <param name="outputdirectoryid">Id of the job output directory.
        /// This is the OutputDirectory--&gt;id parameter that is given by the
        /// user during Create Job.</param>
        /// <param name="linkexpiryinminutes">The number of minutes after which
        /// the download link will expire.</param>
        /// <param name="maxResults">The maximum number of items to return in
        /// the response. A maximum of 1000 files can be returned.</param>
        public JobsListOutputFilesOptionsInner(string outputdirectoryid, int? linkexpiryinminutes = default(int?), int? maxResults = default(int?))
        {
            Outputdirectoryid = outputdirectoryid;
            Linkexpiryinminutes = linkexpiryinminutes;
            MaxResults = maxResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the job output directory. This is the
        /// OutputDirectory--&amp;gt;id parameter that is given by the user
        /// during Create Job.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string Outputdirectoryid { get; set; }

        /// <summary>
        /// Gets or sets the number of minutes after which the download link
        /// will expire.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? Linkexpiryinminutes { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to return in the response.
        /// A maximum of 1000 files can be returned.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Outputdirectoryid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Outputdirectoryid");
            }
        }
    }
}
