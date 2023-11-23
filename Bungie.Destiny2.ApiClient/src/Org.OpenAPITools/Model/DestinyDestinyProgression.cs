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
    /// Information about a current character&#39;s status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this \&quot;live\&quot; data with the related DestinyProgressionDefinition for a full picture of the Progression.
    /// </summary>
    [DataContract(Name = "Destiny.DestinyProgression")]
    public partial class DestinyDestinyProgression : IEquatable<DestinyDestinyProgression>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDestinyProgression" /> class.
        /// </summary>
        /// <param name="progressionHash">The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data..</param>
        /// <param name="dailyProgress">The amount of progress earned today for this progression..</param>
        /// <param name="dailyLimit">If this progression has a daily limit, this is that limit..</param>
        /// <param name="weeklyProgress">The amount of progress earned toward this progression in the current week..</param>
        /// <param name="weeklyLimit">If this progression has a weekly limit, this is that limit..</param>
        /// <param name="currentProgress">This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned).</param>
        /// <param name="level">This is the level of the progression (for instance, the Character Level)..</param>
        /// <param name="levelCap">This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable).</param>
        /// <param name="stepIndex">Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.).</param>
        /// <param name="progressToNextLevel">The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word..</param>
        /// <param name="nextLevelAt">The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level..</param>
        /// <param name="currentResetCount">The number of resets of this progression you&#39;ve executed this season, if applicable to this progression..</param>
        /// <param name="seasonResets">Information about historical resets of this progression, if there is any data for it..</param>
        /// <param name="rewardItemStates">Information about historical rewards for this progression, if there is any data for it..</param>
        public DestinyDestinyProgression(int progressionHash = default(int), int dailyProgress = default(int), int dailyLimit = default(int), int weeklyProgress = default(int), int weeklyLimit = default(int), int currentProgress = default(int), int level = default(int), int levelCap = default(int), int stepIndex = default(int), int progressToNextLevel = default(int), int nextLevelAt = default(int), int? currentResetCount = default(int?), List<DestinyDestinyProgressionResetEntry> seasonResets = default(List<DestinyDestinyProgressionResetEntry>), List<int> rewardItemStates = default(List<int>))
        {
            this.ProgressionHash = progressionHash;
            this.DailyProgress = dailyProgress;
            this.DailyLimit = dailyLimit;
            this.WeeklyProgress = weeklyProgress;
            this.WeeklyLimit = weeklyLimit;
            this.CurrentProgress = currentProgress;
            this.Level = level;
            this.LevelCap = levelCap;
            this.StepIndex = stepIndex;
            this.ProgressToNextLevel = progressToNextLevel;
            this.NextLevelAt = nextLevelAt;
            this.CurrentResetCount = currentResetCount;
            this.SeasonResets = seasonResets;
            this.RewardItemStates = rewardItemStates;
        }

        /// <summary>
        /// The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.
        /// </summary>
        /// <value>The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.</value>
        [DataMember(Name = "progressionHash", EmitDefaultValue = false)]
        public int ProgressionHash { get; set; }

        /// <summary>
        /// The amount of progress earned today for this progression.
        /// </summary>
        /// <value>The amount of progress earned today for this progression.</value>
        [DataMember(Name = "dailyProgress", EmitDefaultValue = false)]
        public int DailyProgress { get; set; }

        /// <summary>
        /// If this progression has a daily limit, this is that limit.
        /// </summary>
        /// <value>If this progression has a daily limit, this is that limit.</value>
        [DataMember(Name = "dailyLimit", EmitDefaultValue = false)]
        public int DailyLimit { get; set; }

        /// <summary>
        /// The amount of progress earned toward this progression in the current week.
        /// </summary>
        /// <value>The amount of progress earned toward this progression in the current week.</value>
        [DataMember(Name = "weeklyProgress", EmitDefaultValue = false)]
        public int WeeklyProgress { get; set; }

        /// <summary>
        /// If this progression has a weekly limit, this is that limit.
        /// </summary>
        /// <value>If this progression has a weekly limit, this is that limit.</value>
        [DataMember(Name = "weeklyLimit", EmitDefaultValue = false)]
        public int WeeklyLimit { get; set; }

        /// <summary>
        /// This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)
        /// </summary>
        /// <value>This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)</value>
        [DataMember(Name = "currentProgress", EmitDefaultValue = false)]
        public int CurrentProgress { get; set; }

        /// <summary>
        /// This is the level of the progression (for instance, the Character Level).
        /// </summary>
        /// <value>This is the level of the progression (for instance, the Character Level).</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }

        /// <summary>
        /// This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)
        /// </summary>
        /// <value>This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)</value>
        [DataMember(Name = "levelCap", EmitDefaultValue = false)]
        public int LevelCap { get; set; }

        /// <summary>
        /// Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)
        /// </summary>
        /// <value>Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)</value>
        [DataMember(Name = "stepIndex", EmitDefaultValue = false)]
        public int StepIndex { get; set; }

        /// <summary>
        /// The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.
        /// </summary>
        /// <value>The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.</value>
        [DataMember(Name = "progressToNextLevel", EmitDefaultValue = false)]
        public int ProgressToNextLevel { get; set; }

        /// <summary>
        /// The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level.
        /// </summary>
        /// <value>The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level.</value>
        [DataMember(Name = "nextLevelAt", EmitDefaultValue = false)]
        public int NextLevelAt { get; set; }

        /// <summary>
        /// The number of resets of this progression you&#39;ve executed this season, if applicable to this progression.
        /// </summary>
        /// <value>The number of resets of this progression you&#39;ve executed this season, if applicable to this progression.</value>
        [DataMember(Name = "currentResetCount", EmitDefaultValue = true)]
        public int? CurrentResetCount { get; set; }

        /// <summary>
        /// Information about historical resets of this progression, if there is any data for it.
        /// </summary>
        /// <value>Information about historical resets of this progression, if there is any data for it.</value>
        [DataMember(Name = "seasonResets", EmitDefaultValue = false)]
        public List<DestinyDestinyProgressionResetEntry> SeasonResets { get; set; }

        /// <summary>
        /// Information about historical rewards for this progression, if there is any data for it.
        /// </summary>
        /// <value>Information about historical rewards for this progression, if there is any data for it.</value>
        [DataMember(Name = "rewardItemStates", EmitDefaultValue = false)]
        public List<int> RewardItemStates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDestinyProgression {\n");
            sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
            sb.Append("  DailyProgress: ").Append(DailyProgress).Append("\n");
            sb.Append("  DailyLimit: ").Append(DailyLimit).Append("\n");
            sb.Append("  WeeklyProgress: ").Append(WeeklyProgress).Append("\n");
            sb.Append("  WeeklyLimit: ").Append(WeeklyLimit).Append("\n");
            sb.Append("  CurrentProgress: ").Append(CurrentProgress).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LevelCap: ").Append(LevelCap).Append("\n");
            sb.Append("  StepIndex: ").Append(StepIndex).Append("\n");
            sb.Append("  ProgressToNextLevel: ").Append(ProgressToNextLevel).Append("\n");
            sb.Append("  NextLevelAt: ").Append(NextLevelAt).Append("\n");
            sb.Append("  CurrentResetCount: ").Append(CurrentResetCount).Append("\n");
            sb.Append("  SeasonResets: ").Append(SeasonResets).Append("\n");
            sb.Append("  RewardItemStates: ").Append(RewardItemStates).Append("\n");
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
            return this.Equals(input as DestinyDestinyProgression);
        }

        /// <summary>
        /// Returns true if DestinyDestinyProgression instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDestinyProgression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDestinyProgression input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProgressionHash == input.ProgressionHash ||
                    this.ProgressionHash.Equals(input.ProgressionHash)
                ) && 
                (
                    this.DailyProgress == input.DailyProgress ||
                    this.DailyProgress.Equals(input.DailyProgress)
                ) && 
                (
                    this.DailyLimit == input.DailyLimit ||
                    this.DailyLimit.Equals(input.DailyLimit)
                ) && 
                (
                    this.WeeklyProgress == input.WeeklyProgress ||
                    this.WeeklyProgress.Equals(input.WeeklyProgress)
                ) && 
                (
                    this.WeeklyLimit == input.WeeklyLimit ||
                    this.WeeklyLimit.Equals(input.WeeklyLimit)
                ) && 
                (
                    this.CurrentProgress == input.CurrentProgress ||
                    this.CurrentProgress.Equals(input.CurrentProgress)
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.LevelCap == input.LevelCap ||
                    this.LevelCap.Equals(input.LevelCap)
                ) && 
                (
                    this.StepIndex == input.StepIndex ||
                    this.StepIndex.Equals(input.StepIndex)
                ) && 
                (
                    this.ProgressToNextLevel == input.ProgressToNextLevel ||
                    this.ProgressToNextLevel.Equals(input.ProgressToNextLevel)
                ) && 
                (
                    this.NextLevelAt == input.NextLevelAt ||
                    this.NextLevelAt.Equals(input.NextLevelAt)
                ) && 
                (
                    this.CurrentResetCount == input.CurrentResetCount ||
                    (this.CurrentResetCount != null &&
                    this.CurrentResetCount.Equals(input.CurrentResetCount))
                ) && 
                (
                    this.SeasonResets == input.SeasonResets ||
                    this.SeasonResets != null &&
                    input.SeasonResets != null &&
                    this.SeasonResets.SequenceEqual(input.SeasonResets)
                ) && 
                (
                    this.RewardItemStates == input.RewardItemStates ||
                    this.RewardItemStates != null &&
                    input.RewardItemStates != null &&
                    this.RewardItemStates.SequenceEqual(input.RewardItemStates)
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
                hashCode = (hashCode * 59) + this.ProgressionHash.GetHashCode();
                hashCode = (hashCode * 59) + this.DailyProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.DailyLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.WeeklyProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.WeeklyLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentProgress.GetHashCode();
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                hashCode = (hashCode * 59) + this.LevelCap.GetHashCode();
                hashCode = (hashCode * 59) + this.StepIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.ProgressToNextLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.NextLevelAt.GetHashCode();
                if (this.CurrentResetCount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentResetCount.GetHashCode();
                }
                if (this.SeasonResets != null)
                {
                    hashCode = (hashCode * 59) + this.SeasonResets.GetHashCode();
                }
                if (this.RewardItemStates != null)
                {
                    hashCode = (hashCode * 59) + this.RewardItemStates.GetHashCode();
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
