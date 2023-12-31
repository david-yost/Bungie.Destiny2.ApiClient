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
    /// Part of our dynamic, localized Milestone content is arbitrary categories of items. These are built in our content management system, and thus aren&#39;t the same as programmatically generated rewards.
    /// </summary>
    [DataContract(Name = "Destiny.Milestones.DestinyMilestoneContentItemCategory")]
    public partial class DestinyMilestonesDestinyMilestoneContentItemCategory : IEquatable<DestinyMilestonesDestinyMilestoneContentItemCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestoneContentItemCategory" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="itemHashes">itemHashes.</param>
        public DestinyMilestonesDestinyMilestoneContentItemCategory(string title = default(string), List<int> itemHashes = default(List<int>))
        {
            this.Title = title;
            this.ItemHashes = itemHashes;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ItemHashes
        /// </summary>
        [DataMember(Name = "itemHashes", EmitDefaultValue = false)]
        public List<int> ItemHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestoneContentItemCategory {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ItemHashes: ").Append(ItemHashes).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestoneContentItemCategory);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestoneContentItemCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestoneContentItemCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestoneContentItemCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ItemHashes == input.ItemHashes ||
                    this.ItemHashes != null &&
                    input.ItemHashes != null &&
                    this.ItemHashes.SequenceEqual(input.ItemHashes)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.ItemHashes != null)
                {
                    hashCode = (hashCode * 59) + this.ItemHashes.GetHashCode();
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
