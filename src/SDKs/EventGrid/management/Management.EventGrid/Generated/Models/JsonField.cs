// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This is used to express the source of an input schema mapping for a
    /// single target field in the Event Grid Event schema. This is currently
    /// used in the mappings for the 'id','topic' and 'eventtime' properties.
    /// This represents a field in the input event schema.
    /// </summary>
    public partial class JsonField
    {
        /// <summary>
        /// Initializes a new instance of the JsonField class.
        /// </summary>
        public JsonField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonField class.
        /// </summary>
        /// <param name="sourceField">Name of a field in the input event schema
        /// that's to be used as the source of a mapping.</param>
        public JsonField(string sourceField = default(string))
        {
            SourceField = sourceField;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a field in the input event schema that's to be
        /// used as the source of a mapping.
        /// </summary>
        [JsonProperty(PropertyName = "sourceField")]
        public string SourceField { get; set; }

    }
}
