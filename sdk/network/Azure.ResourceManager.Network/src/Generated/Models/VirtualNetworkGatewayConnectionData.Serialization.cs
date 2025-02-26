// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey"u8);
                writer.WriteStringValue(AuthorizationKey);
            }
            writer.WritePropertyName("virtualNetworkGateway1"u8);
            writer.WriteObjectValue(VirtualNetworkGateway1);
            if (Optional.IsDefined(VirtualNetworkGateway2))
            {
                writer.WritePropertyName("virtualNetworkGateway2"u8);
                writer.WriteObjectValue(VirtualNetworkGateway2);
            }
            if (Optional.IsDefined(LocalNetworkGateway2))
            {
                writer.WritePropertyName("localNetworkGateway2"u8);
                writer.WriteObjectValue(LocalNetworkGateway2);
            }
            if (Optional.IsCollectionDefined(IngressNatRules))
            {
                writer.WritePropertyName("ingressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in IngressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EgressNatRules))
            {
                writer.WritePropertyName("egressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("connectionType"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(ConnectionProtocol))
            {
                writer.WritePropertyName("connectionProtocol"u8);
                writer.WriteStringValue(ConnectionProtocol.Value.ToString());
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(DpdTimeoutSeconds))
            {
                writer.WritePropertyName("dpdTimeoutSeconds"u8);
                writer.WriteNumberValue(DpdTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(ConnectionMode))
            {
                writer.WritePropertyName("connectionMode"u8);
                writer.WriteStringValue(ConnectionMode.Value.ToString());
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(Peer))
            {
                writer.WritePropertyName("peer"u8);
                JsonSerializer.Serialize(writer, Peer);
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsDefined(UseLocalAzureIPAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress"u8);
                writer.WriteBooleanValue(UseLocalAzureIPAddress.Value);
            }
            if (Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors"u8);
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Optional.IsCollectionDefined(IPsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in IPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrafficSelectorPolicies))
            {
                writer.WritePropertyName("trafficSelectorPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in TrafficSelectorPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExpressRouteGatewayBypass))
            {
                writer.WritePropertyName("expressRouteGatewayBypass"u8);
                writer.WriteBooleanValue(ExpressRouteGatewayBypass.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGatewayConnectionData DeserializeVirtualNetworkGatewayConnectionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> authorizationKey = default;
            VirtualNetworkGatewayData virtualNetworkGateway1 = default;
            Optional<VirtualNetworkGatewayData> virtualNetworkGateway2 = default;
            Optional<LocalNetworkGatewayData> localNetworkGateway2 = default;
            Optional<IList<WritableSubResource>> ingressNatRules = default;
            Optional<IList<WritableSubResource>> egressNatRules = default;
            VirtualNetworkGatewayConnectionType connectionType = default;
            Optional<VirtualNetworkGatewayConnectionProtocol> connectionProtocol = default;
            Optional<int> routingWeight = default;
            Optional<int> dpdTimeoutSeconds = default;
            Optional<VirtualNetworkGatewayConnectionMode> connectionMode = default;
            Optional<string> sharedKey = default;
            Optional<VirtualNetworkGatewayConnectionStatus> connectionStatus = default;
            Optional<IReadOnlyList<TunnelConnectionHealth>> tunnelConnectionStatus = default;
            Optional<long> egressBytesTransferred = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<WritableSubResource> peer = default;
            Optional<bool> enableBgp = default;
            Optional<bool> useLocalAzureIPAddress = default;
            Optional<bool> usePolicyBasedTrafficSelectors = default;
            Optional<IList<IPsecPolicy>> ipsecPolicies = default;
            Optional<IList<TrafficSelectorPolicy>> trafficSelectorPolicies = default;
            Optional<Guid> resourceGuid = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<bool> expressRouteGatewayBypass = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authorizationKey"u8))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway1"u8))
                        {
                            virtualNetworkGateway1 = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkGateway2 = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("localNetworkGateway2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localNetworkGateway2 = LocalNetworkGatewayData.DeserializeLocalNetworkGatewayData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ingressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ingressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("egressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            egressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("connectionType"u8))
                        {
                            connectionType = new VirtualNetworkGatewayConnectionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProtocol = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dpdTimeoutSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dpdTimeoutSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionMode = new VirtualNetworkGatewayConnectionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VirtualNetworkGatewayConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tunnelConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TunnelConnectionHealth> array = new List<TunnelConnectionHealth>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TunnelConnectionHealth.DeserializeTunnelConnectionHealth(item));
                            }
                            tunnelConnectionStatus = array;
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peer = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficSelectorPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficSelectorPolicy> array = new List<TrafficSelectorPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficSelectorPolicy.DeserializeTrafficSelectorPolicy(item));
                            }
                            trafficSelectorPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGatewayBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGatewayBypass = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGatewayConnectionData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), authorizationKey.Value, virtualNetworkGateway1, virtualNetworkGateway2.Value, localNetworkGateway2.Value, Optional.ToList(ingressNatRules), Optional.ToList(egressNatRules), connectionType, Optional.ToNullable(connectionProtocol), Optional.ToNullable(routingWeight), Optional.ToNullable(dpdTimeoutSeconds), Optional.ToNullable(connectionMode), sharedKey.Value, Optional.ToNullable(connectionStatus), Optional.ToList(tunnelConnectionStatus), Optional.ToNullable(egressBytesTransferred), Optional.ToNullable(ingressBytesTransferred), peer, Optional.ToNullable(enableBgp), Optional.ToNullable(useLocalAzureIPAddress), Optional.ToNullable(usePolicyBasedTrafficSelectors), Optional.ToList(ipsecPolicies), Optional.ToList(trafficSelectorPolicies), Optional.ToNullable(resourceGuid), Optional.ToNullable(provisioningState), Optional.ToNullable(expressRouteGatewayBypass));
        }
    }
}
