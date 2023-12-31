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
    /// TrendingTrendingEntryDestinyRitual
    /// </summary>
    [DataContract(Name = "Trending.TrendingEntryDestinyRitual")]
    public partial class TrendingTrendingEntryDestinyRitual : IEquatable<TrendingTrendingEntryDestinyRitual>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTrendingEntryDestinyRitual" /> class.
        /// </summary>
        /// <param name="image">image.</param>
        /// <param name="icon">icon.</param>
        /// <param name="title">title.</param>
        /// <param name="subtitle">subtitle.</param>
        /// <param name="dateStart">dateStart.</param>
        /// <param name="dateEnd">dateEnd.</param>
        /// <param name="milestoneDetails">milestoneDetails.</param>
        /// <param name="eventContent">eventContent.</param>
        public TrendingTrendingEntryDestinyRitual(string image = default(string), string icon = default(string), string title = default(string), string subtitle = default(string), DateTime? dateStart = default(DateTime?), DateTime? dateEnd = default(DateTime?), DestinyMilestonesDestinyPublicMilestone milestoneDetails = default(DestinyMilestonesDestinyPublicMilestone), DestinyMilestonesDestinyMilestoneContent eventContent = default(DestinyMilestonesDestinyMilestoneContent))
        {
            this.Image = image;
            this.Icon = icon;
            this.Title = title;
            this.Subtitle = subtitle;
            this.DateStart = dateStart;
            this.DateEnd = dateEnd;
            this.MilestoneDetails = milestoneDetails;
            this.EventContent = eventContent;
        }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Subtitle
        /// </summary>
        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or Sets DateStart
        /// </summary>
        [DataMember(Name = "dateStart", EmitDefaultValue = true)]
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// Gets or Sets DateEnd
        /// </summary>
        [DataMember(Name = "dateEnd", EmitDefaultValue = true)]
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneDetails
        /// </summary>
        [DataMember(Name = "milestoneDetails", EmitDefaultValue = false)]
        public DestinyMilestonesDestinyPublicMilestone MilestoneDetails { get; set; }

        /// <summary>
        /// Gets or Sets EventContent
        /// </summary>
        [DataMember(Name = "eventContent", EmitDefaultValue = false)]
        public DestinyMilestonesDestinyMilestoneContent EventContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrendingTrendingEntryDestinyRitual {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  MilestoneDetails: ").Append(MilestoneDetails).Append("\n");
            sb.Append("  EventContent: ").Append(EventContent).Append("\n");
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
            return this.Equals(input as TrendingTrendingEntryDestinyRitual);
        }

        /// <summary>
        /// Returns true if TrendingTrendingEntryDestinyRitual instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingTrendingEntryDestinyRitual to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingTrendingEntryDestinyRitual input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Subtitle == input.Subtitle ||
                    (this.Subtitle != null &&
                    this.Subtitle.Equals(input.Subtitle))
                ) && 
                (
                    this.DateStart == input.DateStart ||
                    (this.DateStart != null &&
                    this.DateStart.Equals(input.DateStart))
                ) && 
                (
                    this.DateEnd == input.DateEnd ||
                    (this.DateEnd != null &&
                    this.DateEnd.Equals(input.DateEnd))
                ) && 
                (
                    this.MilestoneDetails == input.MilestoneDetails ||
                    (this.MilestoneDetails != null &&
                    this.MilestoneDetails.Equals(input.MilestoneDetails))
                ) && 
                (
                    this.EventContent == input.EventContent ||
                    (this.EventContent != null &&
                    this.EventContent.Equals(input.EventContent))
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
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Subtitle != null)
                {
                    hashCode = (hashCode * 59) + this.Subtitle.GetHashCode();
                }
                if (this.DateStart != null)
                {
                    hashCode = (hashCode * 59) + this.DateStart.GetHashCode();
                }
                if (this.DateEnd != null)
                {
                    hashCode = (hashCode * 59) + this.DateEnd.GetHashCode();
                }
                if (this.MilestoneDetails != null)
                {
                    hashCode = (hashCode * 59) + this.MilestoneDetails.GetHashCode();
                }
                if (this.EventContent != null)
                {
                    hashCode = (hashCode * 59) + this.EventContent.GetHashCode();
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
