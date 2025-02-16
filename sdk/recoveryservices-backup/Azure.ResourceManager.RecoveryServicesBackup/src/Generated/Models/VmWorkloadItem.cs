// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Azure VM workload-specific workload item.
    /// Please note <see cref="VmWorkloadItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="VmWorkloadSapAseDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapAseSystemWorkloadItem"/>, <see cref="VmWorkloadSapHanaDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapHanaSystemWorkloadItem"/>, <see cref="VmWorkloadSqlDatabaseWorkloadItem"/> and <see cref="VmWorkloadSqlInstanceWorkloadItem"/>.
    /// </summary>
    public partial class VmWorkloadItem : WorkloadItem
    {
        /// <summary> Initializes a new instance of VmWorkloadItem. </summary>
        public VmWorkloadItem()
        {
            WorkloadItemType = "AzureVmWorkloadItem";
        }

        /// <summary> Initializes a new instance of VmWorkloadItem. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="workloadItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        /// <param name="parentName"> Name for instance or AG. </param>
        /// <param name="serverName"> Host/Cluster Name for instance or AG. </param>
        /// <param name="isAutoProtectable"> Indicates if workload item is auto-protectable. </param>
        /// <param name="subInquiredItemCount"> For instance or AG, indicates number of DB's present. </param>
        /// <param name="subWorkloadItemCount"> For instance or AG, indicates number of DB's to be protected. </param>
        internal VmWorkloadItem(string backupManagementType, string workloadType, string workloadItemType, string friendlyName, BackupProtectionStatus? protectionState, string parentName, string serverName, bool? isAutoProtectable, int? subInquiredItemCount, int? subWorkloadItemCount) : base(backupManagementType, workloadType, workloadItemType, friendlyName, protectionState)
        {
            ParentName = parentName;
            ServerName = serverName;
            IsAutoProtectable = isAutoProtectable;
            SubInquiredItemCount = subInquiredItemCount;
            SubWorkloadItemCount = subWorkloadItemCount;
            WorkloadItemType = workloadItemType ?? "AzureVmWorkloadItem";
        }

        /// <summary> Name for instance or AG. </summary>
        public string ParentName { get; set; }
        /// <summary> Host/Cluster Name for instance or AG. </summary>
        public string ServerName { get; set; }
        /// <summary> Indicates if workload item is auto-protectable. </summary>
        public bool? IsAutoProtectable { get; set; }
        /// <summary> For instance or AG, indicates number of DB's present. </summary>
        public int? SubInquiredItemCount { get; set; }
        /// <summary> For instance or AG, indicates number of DB's to be protected. </summary>
        public int? SubWorkloadItemCount { get; set; }
    }
}
