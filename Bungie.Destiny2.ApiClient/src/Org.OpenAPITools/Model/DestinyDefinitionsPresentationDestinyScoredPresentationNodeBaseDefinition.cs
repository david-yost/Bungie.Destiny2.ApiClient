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
    /// DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Presentation.DestinyScoredPresentationNodeBaseDefinition")]
    public partial class DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition : IEquatable<DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition" /> class.
        /// </summary>
        /// <param name="maxCategoryRecordScore">maxCategoryRecordScore.</param>
        /// <param name="presentationNodeType">presentationNodeType.</param>
        /// <param name="traitIds">traitIds.</param>
        /// <param name="traitHashes">traitHashes.</param>
        /// <param name="parentNodeHashes">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition(int maxCategoryRecordScore = default(int), int presentationNodeType = default(int), List<string> traitIds = default(List<string>), List<int> traitHashes = default(List<int>), List<int> parentNodeHashes = default(List<int>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.MaxCategoryRecordScore = maxCategoryRecordScore;
            this.PresentationNodeType = presentationNodeType;
            this.TraitIds = traitIds;
            this.TraitHashes = traitHashes;
            this.ParentNodeHashes = parentNodeHashes;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }

        /// <summary>
        /// Gets or Sets MaxCategoryRecordScore
        /// </summary>
        [DataMember(Name = "maxCategoryRecordScore", EmitDefaultValue = false)]
        public int MaxCategoryRecordScore { get; set; }

        /// <summary>
        /// Gets or Sets PresentationNodeType
        /// </summary>
        [DataMember(Name = "presentationNodeType", EmitDefaultValue = false)]
        public int PresentationNodeType { get; set; }

        /// <summary>
        /// Gets or Sets TraitIds
        /// </summary>
        [DataMember(Name = "traitIds", EmitDefaultValue = false)]
        public List<string> TraitIds { get; set; }

        /// <summary>
        /// Gets or Sets TraitHashes
        /// </summary>
        [DataMember(Name = "traitHashes", EmitDefaultValue = false)]
        public List<int> TraitHashes { get; set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        /// <value>A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</value>
        [DataMember(Name = "parentNodeHashes", EmitDefaultValue = false)]
        public List<int> ParentNodeHashes { get; set; }

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
            sb.Append("class DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition {\n");
            sb.Append("  MaxCategoryRecordScore: ").Append(MaxCategoryRecordScore).Append("\n");
            sb.Append("  PresentationNodeType: ").Append(PresentationNodeType).Append("\n");
            sb.Append("  TraitIds: ").Append(TraitIds).Append("\n");
            sb.Append("  TraitHashes: ").Append(TraitHashes).Append("\n");
            sb.Append("  ParentNodeHashes: ").Append(ParentNodeHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyScoredPresentationNodeBaseDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxCategoryRecordScore == input.MaxCategoryRecordScore ||
                    this.MaxCategoryRecordScore.Equals(input.MaxCategoryRecordScore)
                ) && 
                (
                    this.PresentationNodeType == input.PresentationNodeType ||
                    this.PresentationNodeType.Equals(input.PresentationNodeType)
                ) && 
                (
                    this.TraitIds == input.TraitIds ||
                    this.TraitIds != null &&
                    input.TraitIds != null &&
                    this.TraitIds.SequenceEqual(input.TraitIds)
                ) && 
                (
                    this.TraitHashes == input.TraitHashes ||
                    this.TraitHashes != null &&
                    input.TraitHashes != null &&
                    this.TraitHashes.SequenceEqual(input.TraitHashes)
                ) && 
                (
                    this.ParentNodeHashes == input.ParentNodeHashes ||
                    this.ParentNodeHashes != null &&
                    input.ParentNodeHashes != null &&
                    this.ParentNodeHashes.SequenceEqual(input.ParentNodeHashes)
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
                hashCode = (hashCode * 59) + this.MaxCategoryRecordScore.GetHashCode();
                hashCode = (hashCode * 59) + this.PresentationNodeType.GetHashCode();
                if (this.TraitIds != null)
                {
                    hashCode = (hashCode * 59) + this.TraitIds.GetHashCode();
                }
                if (this.TraitHashes != null)
                {
                    hashCode = (hashCode * 59) + this.TraitHashes.GetHashCode();
                }
                if (this.ParentNodeHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ParentNodeHashes.GetHashCode();
                }
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
