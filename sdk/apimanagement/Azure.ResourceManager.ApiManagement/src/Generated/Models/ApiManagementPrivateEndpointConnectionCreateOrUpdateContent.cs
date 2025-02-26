// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> A request to approve or reject a private endpoint connection. </summary>
    public partial class ApiManagementPrivateEndpointConnectionCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of ApiManagementPrivateEndpointConnectionCreateOrUpdateContent. </summary>
        public ApiManagementPrivateEndpointConnectionCreateOrUpdateContent()
        {
        }

        /// <summary> Private Endpoint Connection Resource Id. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The connection state of the private endpoint connection. </summary>
        internal PrivateEndpointConnectionRequestProperties Properties { get; set; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public ApiManagementPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState
        {
            get => Properties is null ? default : Properties.PrivateLinkServiceConnectionState;
            set
            {
                if (Properties is null)
                    Properties = new PrivateEndpointConnectionRequestProperties();
                Properties.PrivateLinkServiceConnectionState = value;
            }
        }
    }
}
