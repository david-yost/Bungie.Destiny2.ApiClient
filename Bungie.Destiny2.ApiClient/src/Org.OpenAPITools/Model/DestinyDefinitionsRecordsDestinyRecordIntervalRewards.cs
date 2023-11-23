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
    /// DestinyDefinitionsRecordsDestinyRecordIntervalRewards
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Records.DestinyRecordIntervalRewards")]
    public partial class DestinyDefinitionsRecordsDestinyRecordIntervalRewards : IEquatable<DestinyDefinitionsRecordsDestinyRecordIntervalRewards>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsDestinyRecordIntervalRewards" /> class.
        /// </summary>
        /// <param name="intervalRewardItems">intervalRewardItems.</param>
        public DestinyDefinitionsRecordsDestinyRecordIntervalRewards(List<DestinyDestinyItemQuantity> intervalRewardItems = default(List<DestinyDestinyItemQuantity>))
        {
            this.IntervalRewardItems = intervalRewardItems;
        }

        /// <summary>
        /// Gets or Sets IntervalRewardItems
        /// </summary>
        [DataMember(Name = "intervalRewardItems", EmitDefaultValue = false)]
        public List<DestinyDestinyItemQuantity> IntervalRewardItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsDestinyRecordIntervalRewards {\n");
            sb.Append("  IntervalRewardItems: ").Append(IntervalRewardItems).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsRecordsDestinyRecordIntervalRewards);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsDestinyRecordIntervalRewards instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsDestinyRecordIntervalRewards to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsDestinyRecordIntervalRewards input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntervalRewardItems == input.IntervalRewardItems ||
                    this.IntervalRewardItems != null &&
                    input.IntervalRewardItems != null &&
                    this.IntervalRewardItems.SequenceEqual(input.IntervalRewardItems)
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
                if (this.IntervalRewardItems != null)
                {
                    hashCode = (hashCode * 59) + this.IntervalRewardItems.GetHashCode();
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
