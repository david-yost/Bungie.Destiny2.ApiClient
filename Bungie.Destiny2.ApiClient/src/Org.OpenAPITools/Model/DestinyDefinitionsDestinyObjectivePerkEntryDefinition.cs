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
    /// Defines the conditions under which an intrinsic perk is applied while participating in an Objective.  These perks will generally not be benefit-granting perks, but rather a perk that modifies gameplay in some interesting way.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyObjectivePerkEntryDefinition")]
    public partial class DestinyDefinitionsDestinyObjectivePerkEntryDefinition : IEquatable<DestinyDefinitionsDestinyObjectivePerkEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyObjectivePerkEntryDefinition" /> class.
        /// </summary>
        /// <param name="perkHash">The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character..</param>
        /// <param name="style">An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed..</param>
        public DestinyDefinitionsDestinyObjectivePerkEntryDefinition(int perkHash = default(int), int style = default(int))
        {
            this.PerkHash = perkHash;
            this.Style = style;
        }

        /// <summary>
        /// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.
        /// </summary>
        /// <value>The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.</value>
        [DataMember(Name = "perkHash", EmitDefaultValue = false)]
        public int PerkHash { get; set; }

        /// <summary>
        /// An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.
        /// </summary>
        /// <value>An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.</value>
        [DataMember(Name = "style", EmitDefaultValue = false)]
        public int Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyObjectivePerkEntryDefinition {\n");
            sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyObjectivePerkEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyObjectivePerkEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyObjectivePerkEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyObjectivePerkEntryDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PerkHash == input.PerkHash ||
                    this.PerkHash.Equals(input.PerkHash)
                ) && 
                (
                    this.Style == input.Style ||
                    this.Style.Equals(input.Style)
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
                hashCode = (hashCode * 59) + this.PerkHash.GetHashCode();
                hashCode = (hashCode * 59) + this.Style.GetHashCode();
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
