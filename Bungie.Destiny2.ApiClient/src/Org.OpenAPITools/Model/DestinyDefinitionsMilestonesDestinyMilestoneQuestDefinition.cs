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
    /// Any data we need to figure out whether this Quest Item is the currently active one for the conceptual Milestone. Even just typing this description, I already regret it.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Milestones.DestinyMilestoneQuestDefinition")]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition : IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition" /> class.
        /// </summary>
        /// <param name="questItemHash">The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data..</param>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="overrideImage">If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone..</param>
        /// <param name="questRewards">questRewards.</param>
        /// <param name="activities">The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition..</param>
        /// <param name="destinationHash">Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future..</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition(int questItemHash = default(int), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string overrideImage = default(string), DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition questRewards = default(DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition), Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> activities = default(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition>), int? destinationHash = default(int?))
        {
            this.QuestItemHash = questItemHash;
            this.DisplayProperties = displayProperties;
            this.OverrideImage = overrideImage;
            this.QuestRewards = questRewards;
            this.Activities = activities;
            this.DestinationHash = destinationHash;
        }

        /// <summary>
        /// The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.
        /// </summary>
        /// <value>The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.</value>
        [DataMember(Name = "questItemHash", EmitDefaultValue = false)]
        public int QuestItemHash { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.
        /// </summary>
        /// <value>If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.</value>
        [DataMember(Name = "overrideImage", EmitDefaultValue = false)]
        public string OverrideImage { get; set; }

        /// <summary>
        /// Gets or Sets QuestRewards
        /// </summary>
        [DataMember(Name = "questRewards", EmitDefaultValue = false)]
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition QuestRewards { get; set; }

        /// <summary>
        /// The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.
        /// </summary>
        /// <value>The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.</value>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> Activities { get; set; }

        /// <summary>
        /// Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future.
        /// </summary>
        /// <value>Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future.</value>
        [DataMember(Name = "destinationHash", EmitDefaultValue = true)]
        public int? DestinationHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition {\n");
            sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  OverrideImage: ").Append(OverrideImage).Append("\n");
            sb.Append("  QuestRewards: ").Append(QuestRewards).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuestItemHash == input.QuestItemHash ||
                    this.QuestItemHash.Equals(input.QuestItemHash)
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.OverrideImage == input.OverrideImage ||
                    (this.OverrideImage != null &&
                    this.OverrideImage.Equals(input.OverrideImage))
                ) && 
                (
                    this.QuestRewards == input.QuestRewards ||
                    (this.QuestRewards != null &&
                    this.QuestRewards.Equals(input.QuestRewards))
                ) && 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    input.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
                ) && 
                (
                    this.DestinationHash == input.DestinationHash ||
                    (this.DestinationHash != null &&
                    this.DestinationHash.Equals(input.DestinationHash))
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
                hashCode = (hashCode * 59) + this.QuestItemHash.GetHashCode();
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                if (this.OverrideImage != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideImage.GetHashCode();
                }
                if (this.QuestRewards != null)
                {
                    hashCode = (hashCode * 59) + this.QuestRewards.GetHashCode();
                }
                if (this.Activities != null)
                {
                    hashCode = (hashCode * 59) + this.Activities.GetHashCode();
                }
                if (this.DestinationHash != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationHash.GetHashCode();
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
