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
    /// DestinyComponentsRecordsDestinyRecordComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Records.DestinyRecordComponent")]
    public partial class DestinyComponentsRecordsDestinyRecordComponent : IEquatable<DestinyComponentsRecordsDestinyRecordComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsRecordsDestinyRecordComponent" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="objectives">objectives.</param>
        /// <param name="intervalObjectives">intervalObjectives.</param>
        /// <param name="intervalsRedeemedCount">intervalsRedeemedCount.</param>
        /// <param name="completedCount">If available, this is the number of times this record has been completed. For example, the number of times a seal title has been gilded..</param>
        /// <param name="rewardVisibilty">If available, a list that describes which reward rewards should be shown (true) or hidden (false). This property is for regular record rewards, and not for interval objective rewards..</param>
        public DestinyComponentsRecordsDestinyRecordComponent(int state = default(int), List<DestinyQuestsDestinyObjectiveProgress> objectives = default(List<DestinyQuestsDestinyObjectiveProgress>), List<DestinyQuestsDestinyObjectiveProgress> intervalObjectives = default(List<DestinyQuestsDestinyObjectiveProgress>), int intervalsRedeemedCount = default(int), int? completedCount = default(int?), List<bool> rewardVisibilty = default(List<bool>))
        {
            this.State = state;
            this.Objectives = objectives;
            this.IntervalObjectives = intervalObjectives;
            this.IntervalsRedeemedCount = intervalsRedeemedCount;
            this.CompletedCount = completedCount;
            this.RewardVisibilty = rewardVisibilty;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public int State { get; set; }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public List<DestinyQuestsDestinyObjectiveProgress> Objectives { get; set; }

        /// <summary>
        /// Gets or Sets IntervalObjectives
        /// </summary>
        [DataMember(Name = "intervalObjectives", EmitDefaultValue = false)]
        public List<DestinyQuestsDestinyObjectiveProgress> IntervalObjectives { get; set; }

        /// <summary>
        /// Gets or Sets IntervalsRedeemedCount
        /// </summary>
        [DataMember(Name = "intervalsRedeemedCount", EmitDefaultValue = false)]
        public int IntervalsRedeemedCount { get; set; }

        /// <summary>
        /// If available, this is the number of times this record has been completed. For example, the number of times a seal title has been gilded.
        /// </summary>
        /// <value>If available, this is the number of times this record has been completed. For example, the number of times a seal title has been gilded.</value>
        [DataMember(Name = "completedCount", EmitDefaultValue = true)]
        public int? CompletedCount { get; set; }

        /// <summary>
        /// If available, a list that describes which reward rewards should be shown (true) or hidden (false). This property is for regular record rewards, and not for interval objective rewards.
        /// </summary>
        /// <value>If available, a list that describes which reward rewards should be shown (true) or hidden (false). This property is for regular record rewards, and not for interval objective rewards.</value>
        [DataMember(Name = "rewardVisibilty", EmitDefaultValue = false)]
        public List<bool> RewardVisibilty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsRecordsDestinyRecordComponent {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  IntervalObjectives: ").Append(IntervalObjectives).Append("\n");
            sb.Append("  IntervalsRedeemedCount: ").Append(IntervalsRedeemedCount).Append("\n");
            sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
            sb.Append("  RewardVisibilty: ").Append(RewardVisibilty).Append("\n");
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
            return this.Equals(input as DestinyComponentsRecordsDestinyRecordComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsRecordsDestinyRecordComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsRecordsDestinyRecordComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsRecordsDestinyRecordComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Objectives == input.Objectives ||
                    this.Objectives != null &&
                    input.Objectives != null &&
                    this.Objectives.SequenceEqual(input.Objectives)
                ) && 
                (
                    this.IntervalObjectives == input.IntervalObjectives ||
                    this.IntervalObjectives != null &&
                    input.IntervalObjectives != null &&
                    this.IntervalObjectives.SequenceEqual(input.IntervalObjectives)
                ) && 
                (
                    this.IntervalsRedeemedCount == input.IntervalsRedeemedCount ||
                    this.IntervalsRedeemedCount.Equals(input.IntervalsRedeemedCount)
                ) && 
                (
                    this.CompletedCount == input.CompletedCount ||
                    (this.CompletedCount != null &&
                    this.CompletedCount.Equals(input.CompletedCount))
                ) && 
                (
                    this.RewardVisibilty == input.RewardVisibilty ||
                    this.RewardVisibilty != null &&
                    input.RewardVisibilty != null &&
                    this.RewardVisibilty.SequenceEqual(input.RewardVisibilty)
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
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Objectives != null)
                {
                    hashCode = (hashCode * 59) + this.Objectives.GetHashCode();
                }
                if (this.IntervalObjectives != null)
                {
                    hashCode = (hashCode * 59) + this.IntervalObjectives.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IntervalsRedeemedCount.GetHashCode();
                if (this.CompletedCount != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedCount.GetHashCode();
                }
                if (this.RewardVisibilty != null)
                {
                    hashCode = (hashCode * 59) + this.RewardVisibilty.GetHashCode();
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