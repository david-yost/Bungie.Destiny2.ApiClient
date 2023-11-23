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
    /// DestinyBaseItemComponentSetOfint64
    /// </summary>
    [DataContract(Name = "DestinyBaseItemComponentSetOfint64")]
    public partial class DestinyBaseItemComponentSetOfint64 : IEquatable<DestinyBaseItemComponentSetOfint64>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyBaseItemComponentSetOfint64" /> class.
        /// </summary>
        /// <param name="objectives">objectives.</param>
        /// <param name="perks">perks.</param>
        public DestinyBaseItemComponentSetOfint64(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent objectives = default(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent), DictionaryComponentResponseOfint64AndDestinyItemPerksComponent perks = default(DictionaryComponentResponseOfint64AndDestinyItemPerksComponent))
        {
            this.Objectives = objectives;
            this.Perks = perks;
        }

        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Gets or Sets Perks
        /// </summary>
        [DataMember(Name = "perks", EmitDefaultValue = false)]
        public DictionaryComponentResponseOfint64AndDestinyItemPerksComponent Perks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyBaseItemComponentSetOfint64 {\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  Perks: ").Append(Perks).Append("\n");
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
            return this.Equals(input as DestinyBaseItemComponentSetOfint64);
        }

        /// <summary>
        /// Returns true if DestinyBaseItemComponentSetOfint64 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyBaseItemComponentSetOfint64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyBaseItemComponentSetOfint64 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Objectives == input.Objectives ||
                    (this.Objectives != null &&
                    this.Objectives.Equals(input.Objectives))
                ) && 
                (
                    this.Perks == input.Perks ||
                    (this.Perks != null &&
                    this.Perks.Equals(input.Perks))
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
                if (this.Objectives != null)
                {
                    hashCode = (hashCode * 59) + this.Objectives.GetHashCode();
                }
                if (this.Perks != null)
                {
                    hashCode = (hashCode * 59) + this.Perks.GetHashCode();
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