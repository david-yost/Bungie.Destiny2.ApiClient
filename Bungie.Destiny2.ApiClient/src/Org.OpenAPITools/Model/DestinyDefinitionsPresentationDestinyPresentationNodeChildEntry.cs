/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Presentation.DestinyPresentationNodeChildEntry")]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry : IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry" /> class.
        /// </summary>
        /// <param name="presentationNodeHash">presentationNodeHash.</param>
        /// <param name="nodeDisplayPriority">Use this value to sort the presentation node children in ascending order..</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry(int presentationNodeHash = default(int), int nodeDisplayPriority = default(int))
        {
            this.PresentationNodeHash = presentationNodeHash;
            this.NodeDisplayPriority = nodeDisplayPriority;
        }

        /// <summary>
        /// Gets or Sets PresentationNodeHash
        /// </summary>
        [DataMember(Name = "presentationNodeHash", EmitDefaultValue = false)]
        public int PresentationNodeHash { get; set; }

        /// <summary>
        /// Use this value to sort the presentation node children in ascending order.
        /// </summary>
        /// <value>Use this value to sort the presentation node children in ascending order.</value>
        [DataMember(Name = "nodeDisplayPriority", EmitDefaultValue = false)]
        public int NodeDisplayPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry {\n");
            sb.Append("  PresentationNodeHash: ").Append(PresentationNodeHash).Append("\n");
            sb.Append("  NodeDisplayPriority: ").Append(NodeDisplayPriority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PresentationNodeHash == input.PresentationNodeHash ||
                    this.PresentationNodeHash.Equals(input.PresentationNodeHash)
                ) && 
                (
                    this.NodeDisplayPriority == input.NodeDisplayPriority ||
                    this.NodeDisplayPriority.Equals(input.NodeDisplayPriority)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.PresentationNodeHash.GetHashCode();
                hashCode = (hashCode * 59) + this.NodeDisplayPriority.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
