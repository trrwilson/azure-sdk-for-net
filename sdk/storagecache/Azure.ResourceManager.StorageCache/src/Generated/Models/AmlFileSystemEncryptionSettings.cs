// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> AML file system encryption settings. </summary>
    internal partial class AmlFileSystemEncryptionSettings
    {
        /// <summary> Initializes a new instance of AmlFileSystemEncryptionSettings. </summary>
        public AmlFileSystemEncryptionSettings()
        {
        }

        /// <summary> Initializes a new instance of AmlFileSystemEncryptionSettings. </summary>
        /// <param name="keyEncryptionKey"> Specifies the location of the encryption key in Key Vault. </param>
        internal AmlFileSystemEncryptionSettings(StorageCacheEncryptionKeyVaultKeyReference keyEncryptionKey)
        {
            KeyEncryptionKey = keyEncryptionKey;
        }

        /// <summary> Specifies the location of the encryption key in Key Vault. </summary>
        public StorageCacheEncryptionKeyVaultKeyReference KeyEncryptionKey { get; set; }
    }
}
