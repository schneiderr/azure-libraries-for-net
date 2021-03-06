// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The image update trigger that caused a build.
    /// </summary>
    public partial class ImageUpdateTrigger
    {
        /// <summary>
        /// Initializes a new instance of the ImageUpdateTrigger class.
        /// </summary>
        public ImageUpdateTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageUpdateTrigger class.
        /// </summary>
        /// <param name="id">The unique ID of the trigger.</param>
        /// <param name="timestamp">The timestamp when the image update
        /// happened.</param>
        /// <param name="images">The list of image updates that caused the
        /// build.</param>
        public ImageUpdateTrigger(string id = default(string), System.DateTime? timestamp = default(System.DateTime?), IList<ImageDescriptor> images = default(IList<ImageDescriptor>))
        {
            Id = id;
            Timestamp = timestamp;
            Images = images;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID of the trigger.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the image update happened.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the list of image updates that caused the build.
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<ImageDescriptor> Images { get; set; }

    }
}
