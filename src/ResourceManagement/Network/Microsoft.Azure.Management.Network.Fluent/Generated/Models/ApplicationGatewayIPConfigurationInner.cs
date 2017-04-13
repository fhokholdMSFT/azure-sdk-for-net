// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IP configuration of an application gateway. Currently 1 public and 1
    /// private IP configuration is allowed.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayIPConfigurationInner : Microsoft.Azure.Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayIPConfigurationInner class.
        /// </summary>
        public ApplicationGatewayIPConfigurationInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayIPConfigurationInner class.
        /// </summary>
        /// <param name="subnet">Reference of the subnet resource. A subnet
        /// from where application gateway gets its private address.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// application gateway subnet resource. Possible values are:
        /// 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayIPConfigurationInner(string id = default(string), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource subnet = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Subnet = subnet;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference of the subnet resource. A subnet from where
        /// application gateway gets its private address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the application gateway subnet
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}