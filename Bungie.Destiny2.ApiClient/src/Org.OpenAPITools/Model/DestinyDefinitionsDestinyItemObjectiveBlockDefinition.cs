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
    /// An item can have objectives on it. In practice, these are the exclusive purview of \&quot;Quest Step\&quot; items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.  Quest steps have 1:M objectives that we end up processing and returning in live data as DestinyQuestStatus data, and other useful information.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemObjectiveBlockDefinition")]
    public partial class DestinyDefinitionsDestinyItemObjectiveBlockDefinition : IEquatable<DestinyDefinitionsDestinyItemObjectiveBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemObjectiveBlockDefinition" /> class.
        /// </summary>
        /// <param name="objectiveHashes">The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered..</param>
        /// <param name="displayActivityHashes">For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future..</param>
        /// <param name="requireFullObjectiveCompletion">If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed..</param>
        /// <param name="questlineItemHash">The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs..</param>
        /// <param name="narrative">The localized string for narrative text related to this quest step, if any..</param>
        /// <param name="objectiveVerbName">The localized string describing an action to be performed associated with the objectives, if any..</param>
        /// <param name="questTypeIdentifier">The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet..</param>
        /// <param name="questTypeHash">A hashed value for the questTypeIdentifier, because apparently I like to be redundant..</param>
        /// <param name="perObjectiveDisplayProperties">One entry per Objective on the item, it will have related display information..</param>
        /// <param name="displayAsStatTracker">displayAsStatTracker.</param>
        public DestinyDefinitionsDestinyItemObjectiveBlockDefinition(List<int> objectiveHashes = default(List<int>), List<int> displayActivityHashes = default(List<int>), bool requireFullObjectiveCompletion = default(bool), int questlineItemHash = default(int), string narrative = default(string), string objectiveVerbName = default(string), string questTypeIdentifier = default(string), int questTypeHash = default(int), List<DestinyDefinitionsDestinyObjectiveDisplayProperties> perObjectiveDisplayProperties = default(List<DestinyDefinitionsDestinyObjectiveDisplayProperties>), bool displayAsStatTracker = default(bool))
        {
            this.ObjectiveHashes = objectiveHashes;
            this.DisplayActivityHashes = displayActivityHashes;
            this.RequireFullObjectiveCompletion = requireFullObjectiveCompletion;
            this.QuestlineItemHash = questlineItemHash;
            this.Narrative = narrative;
            this.ObjectiveVerbName = objectiveVerbName;
            this.QuestTypeIdentifier = questTypeIdentifier;
            this.QuestTypeHash = questTypeHash;
            this.PerObjectiveDisplayProperties = perObjectiveDisplayProperties;
            this.DisplayAsStatTracker = displayAsStatTracker;
        }

        /// <summary>
        /// The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.
        /// </summary>
        /// <value>The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.</value>
        [DataMember(Name = "objectiveHashes", EmitDefaultValue = false)]
        public List<int> ObjectiveHashes { get; set; }

        /// <summary>
        /// For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.
        /// </summary>
        /// <value>For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.</value>
        [DataMember(Name = "displayActivityHashes", EmitDefaultValue = false)]
        public List<int> DisplayActivityHashes { get; set; }

        /// <summary>
        /// If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.
        /// </summary>
        /// <value>If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.</value>
        [DataMember(Name = "requireFullObjectiveCompletion", EmitDefaultValue = true)]
        public bool RequireFullObjectiveCompletion { get; set; }

        /// <summary>
        /// The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
        /// </summary>
        /// <value>The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.</value>
        [DataMember(Name = "questlineItemHash", EmitDefaultValue = false)]
        public int QuestlineItemHash { get; set; }

        /// <summary>
        /// The localized string for narrative text related to this quest step, if any.
        /// </summary>
        /// <value>The localized string for narrative text related to this quest step, if any.</value>
        [DataMember(Name = "narrative", EmitDefaultValue = false)]
        public string Narrative { get; set; }

        /// <summary>
        /// The localized string describing an action to be performed associated with the objectives, if any.
        /// </summary>
        /// <value>The localized string describing an action to be performed associated with the objectives, if any.</value>
        [DataMember(Name = "objectiveVerbName", EmitDefaultValue = false)]
        public string ObjectiveVerbName { get; set; }

        /// <summary>
        /// The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.
        /// </summary>
        /// <value>The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.</value>
        [DataMember(Name = "questTypeIdentifier", EmitDefaultValue = false)]
        public string QuestTypeIdentifier { get; set; }

        /// <summary>
        /// A hashed value for the questTypeIdentifier, because apparently I like to be redundant.
        /// </summary>
        /// <value>A hashed value for the questTypeIdentifier, because apparently I like to be redundant.</value>
        [DataMember(Name = "questTypeHash", EmitDefaultValue = false)]
        public int QuestTypeHash { get; set; }

        /// <summary>
        /// One entry per Objective on the item, it will have related display information.
        /// </summary>
        /// <value>One entry per Objective on the item, it will have related display information.</value>
        [DataMember(Name = "perObjectiveDisplayProperties", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyObjectiveDisplayProperties> PerObjectiveDisplayProperties { get; set; }

        /// <summary>
        /// Gets or Sets DisplayAsStatTracker
        /// </summary>
        [DataMember(Name = "displayAsStatTracker", EmitDefaultValue = true)]
        public bool DisplayAsStatTracker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemObjectiveBlockDefinition {\n");
            sb.Append("  ObjectiveHashes: ").Append(ObjectiveHashes).Append("\n");
            sb.Append("  DisplayActivityHashes: ").Append(DisplayActivityHashes).Append("\n");
            sb.Append("  RequireFullObjectiveCompletion: ").Append(RequireFullObjectiveCompletion).Append("\n");
            sb.Append("  QuestlineItemHash: ").Append(QuestlineItemHash).Append("\n");
            sb.Append("  Narrative: ").Append(Narrative).Append("\n");
            sb.Append("  ObjectiveVerbName: ").Append(ObjectiveVerbName).Append("\n");
            sb.Append("  QuestTypeIdentifier: ").Append(QuestTypeIdentifier).Append("\n");
            sb.Append("  QuestTypeHash: ").Append(QuestTypeHash).Append("\n");
            sb.Append("  PerObjectiveDisplayProperties: ").Append(PerObjectiveDisplayProperties).Append("\n");
            sb.Append("  DisplayAsStatTracker: ").Append(DisplayAsStatTracker).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemObjectiveBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemObjectiveBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemObjectiveBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemObjectiveBlockDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectiveHashes == input.ObjectiveHashes ||
                    this.ObjectiveHashes != null &&
                    input.ObjectiveHashes != null &&
                    this.ObjectiveHashes.SequenceEqual(input.ObjectiveHashes)
                ) && 
                (
                    this.DisplayActivityHashes == input.DisplayActivityHashes ||
                    this.DisplayActivityHashes != null &&
                    input.DisplayActivityHashes != null &&
                    this.DisplayActivityHashes.SequenceEqual(input.DisplayActivityHashes)
                ) && 
                (
                    this.RequireFullObjectiveCompletion == input.RequireFullObjectiveCompletion ||
                    this.RequireFullObjectiveCompletion.Equals(input.RequireFullObjectiveCompletion)
                ) && 
                (
                    this.QuestlineItemHash == input.QuestlineItemHash ||
                    this.QuestlineItemHash.Equals(input.QuestlineItemHash)
                ) && 
                (
                    this.Narrative == input.Narrative ||
                    (this.Narrative != null &&
                    this.Narrative.Equals(input.Narrative))
                ) && 
                (
                    this.ObjectiveVerbName == input.ObjectiveVerbName ||
                    (this.ObjectiveVerbName != null &&
                    this.ObjectiveVerbName.Equals(input.ObjectiveVerbName))
                ) && 
                (
                    this.QuestTypeIdentifier == input.QuestTypeIdentifier ||
                    (this.QuestTypeIdentifier != null &&
                    this.QuestTypeIdentifier.Equals(input.QuestTypeIdentifier))
                ) && 
                (
                    this.QuestTypeHash == input.QuestTypeHash ||
                    this.QuestTypeHash.Equals(input.QuestTypeHash)
                ) && 
                (
                    this.PerObjectiveDisplayProperties == input.PerObjectiveDisplayProperties ||
                    this.PerObjectiveDisplayProperties != null &&
                    input.PerObjectiveDisplayProperties != null &&
                    this.PerObjectiveDisplayProperties.SequenceEqual(input.PerObjectiveDisplayProperties)
                ) && 
                (
                    this.DisplayAsStatTracker == input.DisplayAsStatTracker ||
                    this.DisplayAsStatTracker.Equals(input.DisplayAsStatTracker)
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
                if (this.ObjectiveHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectiveHashes.GetHashCode();
                }
                if (this.DisplayActivityHashes != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayActivityHashes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequireFullObjectiveCompletion.GetHashCode();
                hashCode = (hashCode * 59) + this.QuestlineItemHash.GetHashCode();
                if (this.Narrative != null)
                {
                    hashCode = (hashCode * 59) + this.Narrative.GetHashCode();
                }
                if (this.ObjectiveVerbName != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectiveVerbName.GetHashCode();
                }
                if (this.QuestTypeIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.QuestTypeIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.QuestTypeHash.GetHashCode();
                if (this.PerObjectiveDisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.PerObjectiveDisplayProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayAsStatTracker.GetHashCode();
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
