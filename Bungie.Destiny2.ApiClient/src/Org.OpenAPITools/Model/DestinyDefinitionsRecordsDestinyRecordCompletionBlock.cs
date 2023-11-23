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
    /// DestinyDefinitionsRecordsDestinyRecordCompletionBlock
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Records.DestinyRecordCompletionBlock")]
    public partial class DestinyDefinitionsRecordsDestinyRecordCompletionBlock : IEquatable<DestinyDefinitionsRecordsDestinyRecordCompletionBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsDestinyRecordCompletionBlock" /> class.
        /// </summary>
        /// <param name="partialCompletionObjectiveCountThreshold">The number of objectives that must be completed before the objective is considered \&quot;complete\&quot;.</param>
        /// <param name="scoreValue">scoreValue.</param>
        /// <param name="shouldFireToast">shouldFireToast.</param>
        /// <param name="toastStyle">toastStyle.</param>
        public DestinyDefinitionsRecordsDestinyRecordCompletionBlock(int partialCompletionObjectiveCountThreshold = default(int), int scoreValue = default(int), bool shouldFireToast = default(bool), int toastStyle = default(int))
        {
            this.PartialCompletionObjectiveCountThreshold = partialCompletionObjectiveCountThreshold;
            this.ScoreValue = scoreValue;
            this.ShouldFireToast = shouldFireToast;
            this.ToastStyle = toastStyle;
        }

        /// <summary>
        /// The number of objectives that must be completed before the objective is considered \&quot;complete\&quot;
        /// </summary>
        /// <value>The number of objectives that must be completed before the objective is considered \&quot;complete\&quot;</value>
        [DataMember(Name = "partialCompletionObjectiveCountThreshold", EmitDefaultValue = false)]
        public int PartialCompletionObjectiveCountThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ScoreValue
        /// </summary>
        [DataMember(Name = "ScoreValue", EmitDefaultValue = false)]
        public int ScoreValue { get; set; }

        /// <summary>
        /// Gets or Sets ShouldFireToast
        /// </summary>
        [DataMember(Name = "shouldFireToast", EmitDefaultValue = true)]
        public bool ShouldFireToast { get; set; }

        /// <summary>
        /// Gets or Sets ToastStyle
        /// </summary>
        [DataMember(Name = "toastStyle", EmitDefaultValue = false)]
        public int ToastStyle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsDestinyRecordCompletionBlock {\n");
            sb.Append("  PartialCompletionObjectiveCountThreshold: ").Append(PartialCompletionObjectiveCountThreshold).Append("\n");
            sb.Append("  ScoreValue: ").Append(ScoreValue).Append("\n");
            sb.Append("  ShouldFireToast: ").Append(ShouldFireToast).Append("\n");
            sb.Append("  ToastStyle: ").Append(ToastStyle).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsRecordsDestinyRecordCompletionBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsDestinyRecordCompletionBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsDestinyRecordCompletionBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsDestinyRecordCompletionBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PartialCompletionObjectiveCountThreshold == input.PartialCompletionObjectiveCountThreshold ||
                    this.PartialCompletionObjectiveCountThreshold.Equals(input.PartialCompletionObjectiveCountThreshold)
                ) && 
                (
                    this.ScoreValue == input.ScoreValue ||
                    this.ScoreValue.Equals(input.ScoreValue)
                ) && 
                (
                    this.ShouldFireToast == input.ShouldFireToast ||
                    this.ShouldFireToast.Equals(input.ShouldFireToast)
                ) && 
                (
                    this.ToastStyle == input.ToastStyle ||
                    this.ToastStyle.Equals(input.ToastStyle)
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
                hashCode = (hashCode * 59) + this.PartialCompletionObjectiveCountThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.ScoreValue.GetHashCode();
                hashCode = (hashCode * 59) + this.ShouldFireToast.GetHashCode();
                hashCode = (hashCode * 59) + this.ToastStyle.GetHashCode();
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
