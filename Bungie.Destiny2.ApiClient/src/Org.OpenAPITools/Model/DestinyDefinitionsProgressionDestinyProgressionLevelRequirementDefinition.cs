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
    /// These are pre-constructed collections of data that can be used to determine the Level Requirement for an item given a Progression to be tested (such as the Character&#39;s level).  For instance, say a character receives a new Auto Rifle, and that Auto Rifle&#39;s DestinyInventoryItemDefinition.quality.progressionLevelRequirementHash property is pointing at one of these DestinyProgressionLevelRequirementDefinitions. Let&#39;s pretend also that the progressionHash it is pointing at is the Character Level progression. In that situation, the character&#39;s level will be used to interpolate a value in the requirementCurve property. The value picked up from that interpolation will be the required level for the item.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Progression.DestinyProgressionLevelRequirementDefinition")]
    public partial class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition : IEquatable<DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition" /> class.
        /// </summary>
        /// <param name="requirementCurve">A curve of level requirements, weighted by the related progressions&#39; level.  Interpolate against this curve with the character&#39;s progression level to determine what the level requirement of the generated item that is using this data will be..</param>
        /// <param name="progressionHash">The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition(List<InterpolationInterpolationPointFloat> requirementCurve = default(List<InterpolationInterpolationPointFloat>), int progressionHash = default(int), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.RequirementCurve = requirementCurve;
            this.ProgressionHash = progressionHash;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }

        /// <summary>
        /// A curve of level requirements, weighted by the related progressions&#39; level.  Interpolate against this curve with the character&#39;s progression level to determine what the level requirement of the generated item that is using this data will be.
        /// </summary>
        /// <value>A curve of level requirements, weighted by the related progressions&#39; level.  Interpolate against this curve with the character&#39;s progression level to determine what the level requirement of the generated item that is using this data will be.</value>
        [DataMember(Name = "requirementCurve", EmitDefaultValue = false)]
        public List<InterpolationInterpolationPointFloat> RequirementCurve { get; set; }

        /// <summary>
        /// The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.
        /// </summary>
        /// <value>The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.</value>
        [DataMember(Name = "progressionHash", EmitDefaultValue = false)]
        public int ProgressionHash { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public int Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name = "redacted", EmitDefaultValue = true)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition {\n");
            sb.Append("  RequirementCurve: ").Append(RequirementCurve).Append("\n");
            sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequirementCurve == input.RequirementCurve ||
                    this.RequirementCurve != null &&
                    input.RequirementCurve != null &&
                    this.RequirementCurve.SequenceEqual(input.RequirementCurve)
                ) && 
                (
                    this.ProgressionHash == input.ProgressionHash ||
                    this.ProgressionHash.Equals(input.ProgressionHash)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.RequirementCurve != null)
                {
                    hashCode = (hashCode * 59) + this.RequirementCurve.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProgressionHash.GetHashCode();
                hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Redacted.GetHashCode();
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
