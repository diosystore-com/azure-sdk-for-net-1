// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a registry key entity. </summary>
    public partial class SecurityInsightsRegistryKeyEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of SecurityInsightsRegistryKeyEntity. </summary>
        public SecurityInsightsRegistryKeyEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = SecurityInsightsEntityKind.RegistryKey;
        }

        /// <summary> Initializes a new instance of SecurityInsightsRegistryKeyEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="hive"> the hive that holds the registry key. </param>
        /// <param name="key"> The registry key path. </param>
        internal SecurityInsightsRegistryKeyEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, SecurityInsightsRegistryHive? hive, string key) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            Hive = hive;
            Key = key;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> the hive that holds the registry key. </summary>
        public SecurityInsightsRegistryHive? Hive { get; }
        /// <summary> The registry key path. </summary>
        public string Key { get; }
    }
}
