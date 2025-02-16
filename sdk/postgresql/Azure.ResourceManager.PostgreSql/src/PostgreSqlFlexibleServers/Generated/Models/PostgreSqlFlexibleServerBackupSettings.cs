// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The settings for the long term backup. </summary>
    public partial class PostgreSqlFlexibleServerBackupSettings
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerBackupSettings. </summary>
        /// <param name="backupName"> Backup Name for the current backup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public PostgreSqlFlexibleServerBackupSettings(string backupName)
        {
            Argument.AssertNotNull(backupName, nameof(backupName));

            BackupName = backupName;
        }

        /// <summary> Backup Name for the current backup. </summary>
        public string BackupName { get; }
    }
}
