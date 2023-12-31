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
    /// Describes the way that an Item Stat (see DestinyStatDefinition) is transformed using the DestinyStatGroupDefinition related to that item. See both of the aforementioned definitions for more information about the stages of stat transformation.  This represents the transformation of a stat into a \&quot;Display\&quot; stat (the closest value that BNet can get to the in-game display value of the stat)
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyStatDisplayDefinition")]
    public partial class DestinyDefinitionsDestinyStatDisplayDefinition : IEquatable<DestinyDefinitionsDestinyStatDisplayDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyStatDisplayDefinition" /> class.
        /// </summary>
        /// <param name="statHash">The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property..</param>
        /// <param name="maximumValue">Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0).</param>
        /// <param name="displayAsNumeric">If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police..</param>
        /// <param name="displayInterpolation">The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation..</param>
        public DestinyDefinitionsDestinyStatDisplayDefinition(int statHash = default(int), int maximumValue = default(int), bool displayAsNumeric = default(bool), List<InterpolationInterpolationPoint> displayInterpolation = default(List<InterpolationInterpolationPoint>))
        {
            this.StatHash = statHash;
            this.MaximumValue = maximumValue;
            this.DisplayAsNumeric = displayAsNumeric;
            this.DisplayInterpolation = displayInterpolation;
        }

        /// <summary>
        /// The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property.
        /// </summary>
        /// <value>The hash identifier for the stat being transformed into a Display stat.  Use it to look up the DestinyStatDefinition, or key into a DestinyInventoryItemDefinition&#39;s stats property.</value>
        [DataMember(Name = "statHash", EmitDefaultValue = false)]
        public int StatHash { get; set; }

        /// <summary>
        /// Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)
        /// </summary>
        /// <value>Regardless of the output of interpolation, this is the maximum possible value that the stat can be. It should also be used as the upper bound for displaying the stat as a progress bar (the minimum always being 0)</value>
        [DataMember(Name = "maximumValue", EmitDefaultValue = false)]
        public int MaximumValue { get; set; }

        /// <summary>
        /// If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police.
        /// </summary>
        /// <value>If this is true, the stat should be displayed as a number. Otherwise, display it as a progress bar. Or, you know, do whatever you want. There&#39;s no displayAsNumeric police.</value>
        [DataMember(Name = "displayAsNumeric", EmitDefaultValue = true)]
        public bool DisplayAsNumeric { get; set; }

        /// <summary>
        /// The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.
        /// </summary>
        /// <value>The interpolation table representing how the Investment Stat is transformed into a Display Stat.   See DestinyStatDefinition for a description of the stages of stat transformation.</value>
        [DataMember(Name = "displayInterpolation", EmitDefaultValue = false)]
        public List<InterpolationInterpolationPoint> DisplayInterpolation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyStatDisplayDefinition {\n");
            sb.Append("  StatHash: ").Append(StatHash).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  DisplayAsNumeric: ").Append(DisplayAsNumeric).Append("\n");
            sb.Append("  DisplayInterpolation: ").Append(DisplayInterpolation).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyStatDisplayDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyStatDisplayDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyStatDisplayDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyStatDisplayDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatHash == input.StatHash ||
                    this.StatHash.Equals(input.StatHash)
                ) && 
                (
                    this.MaximumValue == input.MaximumValue ||
                    this.MaximumValue.Equals(input.MaximumValue)
                ) && 
                (
                    this.DisplayAsNumeric == input.DisplayAsNumeric ||
                    this.DisplayAsNumeric.Equals(input.DisplayAsNumeric)
                ) && 
                (
                    this.DisplayInterpolation == input.DisplayInterpolation ||
                    this.DisplayInterpolation != null &&
                    input.DisplayInterpolation != null &&
                    this.DisplayInterpolation.SequenceEqual(input.DisplayInterpolation)
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
                hashCode = (hashCode * 59) + this.StatHash.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumValue.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayAsNumeric.GetHashCode();
                if (this.DisplayInterpolation != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayInterpolation.GetHashCode();
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
