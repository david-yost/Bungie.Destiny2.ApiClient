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
    /// DestinyDefinitionsSocialDestinySocialCommendationDefinition
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Social.DestinySocialCommendationDefinition")]
    public partial class DestinyDefinitionsSocialDestinySocialCommendationDefinition : IEquatable<DestinyDefinitionsSocialDestinySocialCommendationDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsSocialDestinySocialCommendationDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="cardImagePath">cardImagePath.</param>
        /// <param name="color">color.</param>
        /// <param name="displayPriority">displayPriority.</param>
        /// <param name="activityGivingLimit">activityGivingLimit.</param>
        /// <param name="parentCommendationNodeHash">parentCommendationNodeHash.</param>
        /// <param name="displayActivities">The display properties for the the activities that this commendation is available in..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsSocialDestinySocialCommendationDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string cardImagePath = default(string), DestinyMiscDestinyColor color = default(DestinyMiscDestinyColor), int displayPriority = default(int), int activityGivingLimit = default(int), int parentCommendationNodeHash = default(int), List<DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition> displayActivities = default(List<DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.CardImagePath = cardImagePath;
            this.Color = color;
            this.DisplayPriority = displayPriority;
            this.ActivityGivingLimit = activityGivingLimit;
            this.ParentCommendationNodeHash = parentCommendationNodeHash;
            this.DisplayActivities = displayActivities;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets CardImagePath
        /// </summary>
        [DataMember(Name = "cardImagePath", EmitDefaultValue = false)]
        public string CardImagePath { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public DestinyMiscDestinyColor Color { get; set; }

        /// <summary>
        /// Gets or Sets DisplayPriority
        /// </summary>
        [DataMember(Name = "displayPriority", EmitDefaultValue = false)]
        public int DisplayPriority { get; set; }

        /// <summary>
        /// Gets or Sets ActivityGivingLimit
        /// </summary>
        [DataMember(Name = "activityGivingLimit", EmitDefaultValue = false)]
        public int ActivityGivingLimit { get; set; }

        /// <summary>
        /// Gets or Sets ParentCommendationNodeHash
        /// </summary>
        [DataMember(Name = "parentCommendationNodeHash", EmitDefaultValue = false)]
        public int ParentCommendationNodeHash { get; set; }

        /// <summary>
        /// The display properties for the the activities that this commendation is available in.
        /// </summary>
        /// <value>The display properties for the the activities that this commendation is available in.</value>
        [DataMember(Name = "displayActivities", EmitDefaultValue = false)]
        public List<DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition> DisplayActivities { get; set; }

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
            sb.Append("class DestinyDefinitionsSocialDestinySocialCommendationDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  CardImagePath: ").Append(CardImagePath).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  DisplayPriority: ").Append(DisplayPriority).Append("\n");
            sb.Append("  ActivityGivingLimit: ").Append(ActivityGivingLimit).Append("\n");
            sb.Append("  ParentCommendationNodeHash: ").Append(ParentCommendationNodeHash).Append("\n");
            sb.Append("  DisplayActivities: ").Append(DisplayActivities).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsSocialDestinySocialCommendationDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsSocialDestinySocialCommendationDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsSocialDestinySocialCommendationDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsSocialDestinySocialCommendationDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.CardImagePath == input.CardImagePath ||
                    (this.CardImagePath != null &&
                    this.CardImagePath.Equals(input.CardImagePath))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.DisplayPriority == input.DisplayPriority ||
                    this.DisplayPriority.Equals(input.DisplayPriority)
                ) && 
                (
                    this.ActivityGivingLimit == input.ActivityGivingLimit ||
                    this.ActivityGivingLimit.Equals(input.ActivityGivingLimit)
                ) && 
                (
                    this.ParentCommendationNodeHash == input.ParentCommendationNodeHash ||
                    this.ParentCommendationNodeHash.Equals(input.ParentCommendationNodeHash)
                ) && 
                (
                    this.DisplayActivities == input.DisplayActivities ||
                    this.DisplayActivities != null &&
                    input.DisplayActivities != null &&
                    this.DisplayActivities.SequenceEqual(input.DisplayActivities)
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
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                if (this.CardImagePath != null)
                {
                    hashCode = (hashCode * 59) + this.CardImagePath.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayPriority.GetHashCode();
                hashCode = (hashCode * 59) + this.ActivityGivingLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.ParentCommendationNodeHash.GetHashCode();
                if (this.DisplayActivities != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayActivities.GetHashCode();
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
