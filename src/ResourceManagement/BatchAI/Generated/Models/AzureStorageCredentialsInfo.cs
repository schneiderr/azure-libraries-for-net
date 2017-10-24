// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Credentials to access Azure File Share.
    /// </summary>
    public partial class AzureStorageCredentialsInfo
    {
        /// <summary>
        /// Initializes a new instance of the AzureStorageCredentialsInfo
        /// class.
        /// </summary>
        public AzureStorageCredentialsInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageCredentialsInfo
        /// class.
        /// </summary>
        /// <param name="accountKey">Storage account key.</param>
        /// <param name="accountKeySecretReference">Specifies the location of
        /// the storage account key, which is a Key Vault Secret.</param>
        public AzureStorageCredentialsInfo(string accountKey = default(string), KeyVaultSecretReference accountKeySecretReference = default(KeyVaultSecretReference))
        {
            AccountKey = accountKey;
            AccountKeySecretReference = accountKeySecretReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage account key.
        /// </summary>
        /// <remarks>
        /// One of accountKey or accountKeySecretReference must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }

        /// <summary>
        /// Gets or sets specifies the location of the storage account key,
        /// which is a Key Vault Secret.
        /// </summary>
        /// <remarks>
        /// Users can store their secrets in Azure KeyVault and pass it to the
        /// Batch AI Service to integrate with KeyVault. One of accountKey or
        /// accountKeySecretReference must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "accountKeySecretReference")]
        public KeyVaultSecretReference AccountKeySecretReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountKeySecretReference != null)
            {
                AccountKeySecretReference.Validate();
            }
        }
    }
}
