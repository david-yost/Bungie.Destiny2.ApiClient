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
    /// DestinyComponentsCraftablesDestinyCraftableComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Craftables.DestinyCraftableComponent")]
    public partial class DestinyComponentsCraftablesDestinyCraftableComponent : IEquatable<DestinyComponentsCraftablesDestinyCraftableComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsCraftablesDestinyCraftableComponent" /> class.
        /// </summary>
        /// <param name="visible">visible.</param>
        /// <param name="failedRequirementIndexes">If the requirements are not met for crafting this item, these will index into the list of failure strings..</param>
        /// <param name="sockets">Plug item state for the crafting sockets..</param>
        public DestinyComponentsCraftablesDestinyCraftableComponent(bool visible = default(bool), List<int> failedRequirementIndexes = default(List<int>), List<DestinyComponentsCraftablesDestinyCraftableSocketComponent> sockets = default(List<DestinyComponentsCraftablesDestinyCraftableSocketComponent>))
        {
            this.Visible = visible;
            this.FailedRequirementIndexes = failedRequirementIndexes;
            this.Sockets = sockets;
        }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// If the requirements are not met for crafting this item, these will index into the list of failure strings.
        /// </summary>
        /// <value>If the requirements are not met for crafting this item, these will index into the list of failure strings.</value>
        [DataMember(Name = "failedRequirementIndexes", EmitDefaultValue = false)]
        public List<int> FailedRequirementIndexes { get; set; }

        /// <summary>
        /// Plug item state for the crafting sockets.
        /// </summary>
        /// <value>Plug item state for the crafting sockets.</value>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public List<DestinyComponentsCraftablesDestinyCraftableSocketComponent> Sockets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsCraftablesDestinyCraftableComponent {\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  FailedRequirementIndexes: ").Append(FailedRequirementIndexes).Append("\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
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
            return this.Equals(input as DestinyComponentsCraftablesDestinyCraftableComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsCraftablesDestinyCraftableComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsCraftablesDestinyCraftableComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsCraftablesDestinyCraftableComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Visible == input.Visible ||
                    this.Visible.Equals(input.Visible)
                ) && 
                (
                    this.FailedRequirementIndexes == input.FailedRequirementIndexes ||
                    this.FailedRequirementIndexes != null &&
                    input.FailedRequirementIndexes != null &&
                    this.FailedRequirementIndexes.SequenceEqual(input.FailedRequirementIndexes)
                ) && 
                (
                    this.Sockets == input.Sockets ||
                    this.Sockets != null &&
                    input.Sockets != null &&
                    this.Sockets.SequenceEqual(input.Sockets)
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
                hashCode = (hashCode * 59) + this.Visible.GetHashCode();
                if (this.FailedRequirementIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.FailedRequirementIndexes.GetHashCode();
                }
                if (this.Sockets != null)
                {
                    hashCode = (hashCode * 59) + this.Sockets.GetHashCode();
                }
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
