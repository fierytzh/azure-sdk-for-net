// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// The policy definition.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PolicyAssignment : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment() { }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        /// <param name="displayName">The display name of the policy
        /// assignment.</param>
        /// <param name="policyDefinitionId">The ID of the policy
        /// definition.</param>
        /// <param name="scope">The scope for the policy assignment.</param>
        /// <param name="id">The ID of the policy assignment.</param>
        /// <param name="type">The type of the policy assignment.</param>
        /// <param name="name">The name of the policy assignment.</param>
        public PolicyAssignment(string displayName = default(string), string policyDefinitionId = default(string), string scope = default(string), string id = default(string), string type = default(string), string name = default(string))
        {
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            Id = id;
            Type = type;
            Name = name;
        }

        /// <summary>
        /// Gets or sets the display name of the policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the policy definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.policyDefinitionId")]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the scope for the policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the ID of the policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}