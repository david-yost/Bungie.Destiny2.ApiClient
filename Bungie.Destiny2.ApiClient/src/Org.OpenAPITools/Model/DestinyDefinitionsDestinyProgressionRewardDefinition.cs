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
    /// Inventory Items can reward progression when actions are performed on them. A common example of this in Destiny 1 was Bounties, which would reward Experience on your Character and the like when you completed the bounty.  Note that this maps to a DestinyProgressionMappingDefinition, and *not* a DestinyProgressionDefinition directly. This is apparently so that multiple progressions can be granted progression points/experience at the same time.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyProgressionRewardDefinition")]
    public partial class DestinyDefinitionsDestinyProgressionRewardDefinition : IEquatable<DestinyDefinitionsDestinyProgressionRewardDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyProgressionRewardDefinition" /> class.
        /// </summary>
        /// <param name="progressionMappingHash">The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied..</param>
        /// <param name="amount">The amount of experience to give to each of the mapped progressions..</param>
        /// <param name="applyThrottles">If true, the game&#39;s internal mechanisms to throttle progression should be applied..</param>
        public DestinyDefinitionsDestinyProgressionRewardDefinition(int progressionMappingHash = default(int), int amount = default(int), bool applyThrottles = default(bool))
        {
            this.ProgressionMappingHash = progressionMappingHash;
            this.Amount = amount;
            this.ApplyThrottles = applyThrottles;
        }

        /// <summary>
        /// The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.
        /// </summary>
        /// <value>The hash identifier of the DestinyProgressionMappingDefinition that contains the progressions for which experience should be applied.</value>
        [DataMember(Name = "progressionMappingHash", EmitDefaultValue = false)]
        public int ProgressionMappingHash { get; set; }

        /// <summary>
        /// The amount of experience to give to each of the mapped progressions.
        /// </summary>
        /// <value>The amount of experience to give to each of the mapped progressions.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// If true, the game&#39;s internal mechanisms to throttle progression should be applied.
        /// </summary>
        /// <value>If true, the game&#39;s internal mechanisms to throttle progression should be applied.</value>
        [DataMember(Name = "applyThrottles", EmitDefaultValue = true)]
        public bool ApplyThrottles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyProgressionRewardDefinition {\n");
            sb.Append("  ProgressionMappingHash: ").Append(ProgressionMappingHash).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplyThrottles: ").Append(ApplyThrottles).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyProgressionRewardDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyProgressionRewardDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyProgressionRewardDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyProgressionRewardDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProgressionMappingHash == input.ProgressionMappingHash ||
                    this.ProgressionMappingHash.Equals(input.ProgressionMappingHash)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.ApplyThrottles == input.ApplyThrottles ||
                    this.ApplyThrottles.Equals(input.ApplyThrottles)
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
                hashCode = (hashCode * 59) + this.ProgressionMappingHash.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyThrottles.GetHashCode();
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