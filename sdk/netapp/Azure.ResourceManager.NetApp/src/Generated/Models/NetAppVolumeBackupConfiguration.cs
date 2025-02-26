// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume Backup Properties. </summary>
    public partial class NetAppVolumeBackupConfiguration
    {
        /// <summary> Initializes a new instance of NetAppVolumeBackupConfiguration. </summary>
        public NetAppVolumeBackupConfiguration()
        {
        }

        /// <summary> Initializes a new instance of NetAppVolumeBackupConfiguration. </summary>
        /// <param name="backupPolicyId"> Backup Policy Resource ID. </param>
        /// <param name="isPolicyEnforced"> Policy Enforced. </param>
        /// <param name="isBackupEnabled"> Backup Enabled. </param>
        internal NetAppVolumeBackupConfiguration(ResourceIdentifier backupPolicyId, bool? isPolicyEnforced, bool? isBackupEnabled)
        {
            BackupPolicyId = backupPolicyId;
            IsPolicyEnforced = isPolicyEnforced;
            IsBackupEnabled = isBackupEnabled;
        }

        /// <summary> Backup Policy Resource ID. </summary>
        public ResourceIdentifier BackupPolicyId { get; set; }
        /// <summary> Policy Enforced. </summary>
        public bool? IsPolicyEnforced { get; set; }
        /// <summary> Backup Enabled. </summary>
        public bool? IsBackupEnabled { get; set; }
    }
}
