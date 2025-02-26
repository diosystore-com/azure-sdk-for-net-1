// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationAppliance
    {
        internal static ReplicationAppliance DeserializeReplicationAppliance(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReplicationApplianceProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ReplicationApplianceProperties.DeserializeReplicationApplianceProperties(property.Value);
                    continue;
                }
            }
            return new ReplicationAppliance(properties.Value);
        }
    }
}
