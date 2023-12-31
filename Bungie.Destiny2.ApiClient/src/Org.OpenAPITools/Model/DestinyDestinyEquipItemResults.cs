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
    /// The results of a bulk Equipping operation performed through the Destiny API.
    /// </summary>
    [DataContract(Name = "Destiny.DestinyEquipItemResults")]
    public partial class DestinyDestinyEquipItemResults : IEquatable<DestinyDestinyEquipItemResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDestinyEquipItemResults" /> class.
        /// </summary>
        /// <param name="equipResults">equipResults.</param>
        public DestinyDestinyEquipItemResults(List<DestinyDestinyEquipItemResult> equipResults = default(List<DestinyDestinyEquipItemResult>))
        {
            this.EquipResults = equipResults;
        }

        /// <summary>
        /// Gets or Sets EquipResults
        /// </summary>
        [DataMember(Name = "equipResults", EmitDefaultValue = false)]
        public List<DestinyDestinyEquipItemResult> EquipResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDestinyEquipItemResults {\n");
            sb.Append("  EquipResults: ").Append(EquipResults).Append("\n");
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
            return this.Equals(input as DestinyDestinyEquipItemResults);
        }

        /// <summary>
        /// Returns true if DestinyDestinyEquipItemResults instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDestinyEquipItemResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDestinyEquipItemResults input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EquipResults == input.EquipResults ||
                    this.EquipResults != null &&
                    input.EquipResults != null &&
                    this.EquipResults.SequenceEqual(input.EquipResults)
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
                if (this.EquipResults != null)
                {
                    hashCode = (hashCode * 59) + this.EquipResults.GetHashCode();
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
