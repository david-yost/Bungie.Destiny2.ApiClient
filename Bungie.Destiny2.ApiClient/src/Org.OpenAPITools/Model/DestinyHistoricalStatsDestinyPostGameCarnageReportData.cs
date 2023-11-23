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
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportData
    /// </summary>
    [DataContract(Name = "Destiny.HistoricalStats.DestinyPostGameCarnageReportData")]
    public partial class DestinyHistoricalStatsDestinyPostGameCarnageReportData : IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyPostGameCarnageReportData" /> class.
        /// </summary>
        /// <param name="period">Date and time for the activity..</param>
        /// <param name="startingPhaseIndex">If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started. This value is only valid for activities before the Beyond Light expansion shipped. Subsequent activities will not have a valid value here..</param>
        /// <param name="activityWasStartedFromBeginning">True if the activity was started from the beginning, if that information is available and the activity was played post Witch Queen release..</param>
        /// <param name="activityDetails">activityDetails.</param>
        /// <param name="entries">Collection of players and their data for this activity..</param>
        /// <param name="teams">Collection of stats for the player in this activity..</param>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportData(DateTime period = default(DateTime), int? startingPhaseIndex = default(int?), bool? activityWasStartedFromBeginning = default(bool?), DestinyHistoricalStatsDestinyHistoricalStatsActivity activityDetails = default(DestinyHistoricalStatsDestinyHistoricalStatsActivity), List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> entries = default(List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry>), List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> teams = default(List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry>))
        {
            this.Period = period;
            this.StartingPhaseIndex = startingPhaseIndex;
            this.ActivityWasStartedFromBeginning = activityWasStartedFromBeginning;
            this.ActivityDetails = activityDetails;
            this.Entries = entries;
            this.Teams = teams;
        }

        /// <summary>
        /// Date and time for the activity.
        /// </summary>
        /// <value>Date and time for the activity.</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public DateTime Period { get; set; }

        /// <summary>
        /// If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started. This value is only valid for activities before the Beyond Light expansion shipped. Subsequent activities will not have a valid value here.
        /// </summary>
        /// <value>If this activity has \&quot;phases\&quot;, this is the phase at which the activity was started. This value is only valid for activities before the Beyond Light expansion shipped. Subsequent activities will not have a valid value here.</value>
        [DataMember(Name = "startingPhaseIndex", EmitDefaultValue = true)]
        public int? StartingPhaseIndex { get; set; }

        /// <summary>
        /// True if the activity was started from the beginning, if that information is available and the activity was played post Witch Queen release.
        /// </summary>
        /// <value>True if the activity was started from the beginning, if that information is available and the activity was played post Witch Queen release.</value>
        [DataMember(Name = "activityWasStartedFromBeginning", EmitDefaultValue = true)]
        public bool? ActivityWasStartedFromBeginning { get; set; }

        /// <summary>
        /// Gets or Sets ActivityDetails
        /// </summary>
        [DataMember(Name = "activityDetails", EmitDefaultValue = false)]
        public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; set; }

        /// <summary>
        /// Collection of players and their data for this activity.
        /// </summary>
        /// <value>Collection of players and their data for this activity.</value>
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> Entries { get; set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        /// <value>Collection of stats for the player in this activity.</value>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportData {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  StartingPhaseIndex: ").Append(StartingPhaseIndex).Append("\n");
            sb.Append("  ActivityWasStartedFromBeginning: ").Append(ActivityWasStartedFromBeginning).Append("\n");
            sb.Append("  ActivityDetails: ").Append(ActivityDetails).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyPostGameCarnageReportData);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyPostGameCarnageReportData instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyPostGameCarnageReportData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.StartingPhaseIndex == input.StartingPhaseIndex ||
                    (this.StartingPhaseIndex != null &&
                    this.StartingPhaseIndex.Equals(input.StartingPhaseIndex))
                ) && 
                (
                    this.ActivityWasStartedFromBeginning == input.ActivityWasStartedFromBeginning ||
                    (this.ActivityWasStartedFromBeginning != null &&
                    this.ActivityWasStartedFromBeginning.Equals(input.ActivityWasStartedFromBeginning))
                ) && 
                (
                    this.ActivityDetails == input.ActivityDetails ||
                    (this.ActivityDetails != null &&
                    this.ActivityDetails.Equals(input.ActivityDetails))
                ) && 
                (
                    this.Entries == input.Entries ||
                    this.Entries != null &&
                    input.Entries != null &&
                    this.Entries.SequenceEqual(input.Entries)
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    input.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
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
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.StartingPhaseIndex != null)
                {
                    hashCode = (hashCode * 59) + this.StartingPhaseIndex.GetHashCode();
                }
                if (this.ActivityWasStartedFromBeginning != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityWasStartedFromBeginning.GetHashCode();
                }
                if (this.ActivityDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityDetails.GetHashCode();
                }
                if (this.Entries != null)
                {
                    hashCode = (hashCode * 59) + this.Entries.GetHashCode();
                }
                if (this.Teams != null)
                {
                    hashCode = (hashCode * 59) + this.Teams.GetHashCode();
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
