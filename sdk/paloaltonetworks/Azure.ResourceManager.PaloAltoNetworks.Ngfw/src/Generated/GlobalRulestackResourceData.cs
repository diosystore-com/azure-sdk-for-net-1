// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the GlobalRulestackResource data model.
    /// PaloAltoNetworks GlobalRulestack
    /// </summary>
    public partial class GlobalRulestackResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of GlobalRulestackResourceData. </summary>
        /// <param name="location"> Global Location. </param>
        public GlobalRulestackResourceData(AzureLocation location)
        {
            Location = location;
            AssociatedSubscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GlobalRulestackResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Global Location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="panETag"> PanEtag info. </param>
        /// <param name="panLocation"> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </param>
        /// <param name="scope"> Rulestack Type. </param>
        /// <param name="associatedSubscriptions"> subscription scope of global rulestack. </param>
        /// <param name="description"> rulestack description. </param>
        /// <param name="defaultMode"> Mode for default rules creation. </param>
        /// <param name="minAppIdVersion"> minimum version. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="securityServices"> Security Profile. </param>
        internal GlobalRulestackResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, AzureResourceManagerManagedIdentityProperties identity, string panETag, string panLocation, ScopeType? scope, IList<string> associatedSubscriptions, string description, DefaultMode? defaultMode, string minAppIdVersion, ProvisioningState? provisioningState, SecurityServices securityServices) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Identity = identity;
            PanETag = panETag;
            PanLocation = panLocation;
            Scope = scope;
            AssociatedSubscriptions = associatedSubscriptions;
            Description = description;
            DefaultMode = defaultMode;
            MinAppIdVersion = minAppIdVersion;
            ProvisioningState = provisioningState;
            SecurityServices = securityServices;
        }

        /// <summary> Global Location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> The managed service identities assigned to this resource. </summary>
        public AzureResourceManagerManagedIdentityProperties Identity { get; set; }
        /// <summary> PanEtag info. </summary>
        public string PanETag { get; set; }
        /// <summary> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </summary>
        public string PanLocation { get; set; }
        /// <summary> Rulestack Type. </summary>
        public ScopeType? Scope { get; set; }
        /// <summary> subscription scope of global rulestack. </summary>
        public IList<string> AssociatedSubscriptions { get; }
        /// <summary> rulestack description. </summary>
        public string Description { get; set; }
        /// <summary> Mode for default rules creation. </summary>
        public DefaultMode? DefaultMode { get; set; }
        /// <summary> minimum version. </summary>
        public string MinAppIdVersion { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Security Profile. </summary>
        public SecurityServices SecurityServices { get; set; }
    }
}
