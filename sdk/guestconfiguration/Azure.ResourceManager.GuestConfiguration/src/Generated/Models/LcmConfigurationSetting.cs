// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Configuration setting of LCM (Local Configuration Manager). </summary>
    public partial class LcmConfigurationSetting
    {
        /// <summary> Initializes a new instance of LcmConfigurationSetting. </summary>
        internal LcmConfigurationSetting()
        {
        }

        /// <summary> Initializes a new instance of LcmConfigurationSetting. </summary>
        /// <param name="configurationMode"> Specifies how the LCM(Local Configuration Manager) actually applies the configuration to the target nodes. Possible values are ApplyOnly, ApplyAndMonitor, and ApplyAndAutoCorrect. </param>
        /// <param name="isModuleOverwriteAllowed"> If true - new configurations downloaded from the pull service are allowed to overwrite the old ones on the target node. Otherwise, false. </param>
        /// <param name="actionAfterReboot"> Specifies what happens after a reboot during the application of a configuration. The possible values are ContinueConfiguration and StopConfiguration. </param>
        /// <param name="refreshFrequencyInMins"> The time interval, in minutes, at which the LCM checks a pull service to get updated configurations. This value is ignored if the LCM is not configured in pull mode. The default value is 30. </param>
        /// <param name="rebootIfNeeded"> Set this to true to automatically reboot the node after a configuration that requires reboot is applied. Otherwise, you will have to manually reboot the node for any configuration that requires it. The default value is false. To use this setting when a reboot condition is enacted by something other than DSC (such as Windows Installer), combine this setting with the xPendingReboot module. </param>
        /// <param name="configurationModeFrequencyInMins"> How often, in minutes, the current configuration is checked and applied. This property is ignored if the ConfigurationMode property is set to ApplyOnly. The default value is 15. </param>
        internal LcmConfigurationSetting(LcmConfigurationMode? configurationMode, bool? isModuleOverwriteAllowed, ActionAfterReboot? actionAfterReboot, float? refreshFrequencyInMins, bool? rebootIfNeeded, float? configurationModeFrequencyInMins)
        {
            ConfigurationMode = configurationMode;
            IsModuleOverwriteAllowed = isModuleOverwriteAllowed;
            ActionAfterReboot = actionAfterReboot;
            RefreshFrequencyInMins = refreshFrequencyInMins;
            RebootIfNeeded = rebootIfNeeded;
            ConfigurationModeFrequencyInMins = configurationModeFrequencyInMins;
        }

        /// <summary> Specifies how the LCM(Local Configuration Manager) actually applies the configuration to the target nodes. Possible values are ApplyOnly, ApplyAndMonitor, and ApplyAndAutoCorrect. </summary>
        public LcmConfigurationMode? ConfigurationMode { get; }
        /// <summary> If true - new configurations downloaded from the pull service are allowed to overwrite the old ones on the target node. Otherwise, false. </summary>
        public bool? IsModuleOverwriteAllowed { get; }
        /// <summary> Specifies what happens after a reboot during the application of a configuration. The possible values are ContinueConfiguration and StopConfiguration. </summary>
        public ActionAfterReboot? ActionAfterReboot { get; }
        /// <summary> The time interval, in minutes, at which the LCM checks a pull service to get updated configurations. This value is ignored if the LCM is not configured in pull mode. The default value is 30. </summary>
        public float? RefreshFrequencyInMins { get; }
        /// <summary> Set this to true to automatically reboot the node after a configuration that requires reboot is applied. Otherwise, you will have to manually reboot the node for any configuration that requires it. The default value is false. To use this setting when a reboot condition is enacted by something other than DSC (such as Windows Installer), combine this setting with the xPendingReboot module. </summary>
        public bool? RebootIfNeeded { get; }
        /// <summary> How often, in minutes, the current configuration is checked and applied. This property is ignored if the ConfigurationMode property is set to ApplyOnly. The default value is 15. </summary>
        public float? ConfigurationModeFrequencyInMins { get; }
    }
}
