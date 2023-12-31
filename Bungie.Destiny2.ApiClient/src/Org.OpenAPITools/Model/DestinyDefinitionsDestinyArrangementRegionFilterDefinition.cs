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
    /// DestinyDefinitionsDestinyArrangementRegionFilterDefinition
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyArrangementRegionFilterDefinition")]
    public partial class DestinyDefinitionsDestinyArrangementRegionFilterDefinition : IEquatable<DestinyDefinitionsDestinyArrangementRegionFilterDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyArrangementRegionFilterDefinition" /> class.
        /// </summary>
        /// <param name="artArrangementRegionHash">artArrangementRegionHash.</param>
        /// <param name="artArrangementRegionIndex">artArrangementRegionIndex.</param>
        /// <param name="statHash">statHash.</param>
        /// <param name="arrangementIndexByStatValue">arrangementIndexByStatValue.</param>
        public DestinyDefinitionsDestinyArrangementRegionFilterDefinition(int artArrangementRegionHash = default(int), int artArrangementRegionIndex = default(int), int statHash = default(int), Dictionary<string, int> arrangementIndexByStatValue = default(Dictionary<string, int>))
        {
            this.ArtArrangementRegionHash = artArrangementRegionHash;
            this.ArtArrangementRegionIndex = artArrangementRegionIndex;
            this.StatHash = statHash;
            this.ArrangementIndexByStatValue = arrangementIndexByStatValue;
        }

        /// <summary>
        /// Gets or Sets ArtArrangementRegionHash
        /// </summary>
        [DataMember(Name = "artArrangementRegionHash", EmitDefaultValue = false)]
        public int ArtArrangementRegionHash { get; set; }

        /// <summary>
        /// Gets or Sets ArtArrangementRegionIndex
        /// </summary>
        [DataMember(Name = "artArrangementRegionIndex", EmitDefaultValue = false)]
        public int ArtArrangementRegionIndex { get; set; }

        /// <summary>
        /// Gets or Sets StatHash
        /// </summary>
        [DataMember(Name = "statHash", EmitDefaultValue = false)]
        public int StatHash { get; set; }

        /// <summary>
        /// Gets or Sets ArrangementIndexByStatValue
        /// </summary>
        [DataMember(Name = "arrangementIndexByStatValue", EmitDefaultValue = false)]
        public Dictionary<string, int> ArrangementIndexByStatValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyArrangementRegionFilterDefinition {\n");
            sb.Append("  ArtArrangementRegionHash: ").Append(ArtArrangementRegionHash).Append("\n");
            sb.Append("  ArtArrangementRegionIndex: ").Append(ArtArrangementRegionIndex).Append("\n");
            sb.Append("  StatHash: ").Append(StatHash).Append("\n");
            sb.Append("  ArrangementIndexByStatValue: ").Append(ArrangementIndexByStatValue).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyArrangementRegionFilterDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyArrangementRegionFilterDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyArrangementRegionFilterDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyArrangementRegionFilterDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArtArrangementRegionHash == input.ArtArrangementRegionHash ||
                    this.ArtArrangementRegionHash.Equals(input.ArtArrangementRegionHash)
                ) && 
                (
                    this.ArtArrangementRegionIndex == input.ArtArrangementRegionIndex ||
                    this.ArtArrangementRegionIndex.Equals(input.ArtArrangementRegionIndex)
                ) && 
                (
                    this.StatHash == input.StatHash ||
                    this.StatHash.Equals(input.StatHash)
                ) && 
                (
                    this.ArrangementIndexByStatValue == input.ArrangementIndexByStatValue ||
                    this.ArrangementIndexByStatValue != null &&
                    input.ArrangementIndexByStatValue != null &&
                    this.ArrangementIndexByStatValue.SequenceEqual(input.ArrangementIndexByStatValue)
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
                hashCode = (hashCode * 59) + this.ArtArrangementRegionHash.GetHashCode();
                hashCode = (hashCode * 59) + this.ArtArrangementRegionIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.StatHash.GetHashCode();
                if (this.ArrangementIndexByStatValue != null)
                {
                    hashCode = (hashCode * 59) + this.ArrangementIndexByStatValue.GetHashCode();
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
