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
    /// DestinyComponentsStringVariablesDestinyStringVariablesComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.StringVariables.DestinyStringVariablesComponent")]
    public partial class DestinyComponentsStringVariablesDestinyStringVariablesComponent : IEquatable<DestinyComponentsStringVariablesDestinyStringVariablesComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsStringVariablesDestinyStringVariablesComponent" /> class.
        /// </summary>
        /// <param name="integerValuesByHash">integerValuesByHash.</param>
        public DestinyComponentsStringVariablesDestinyStringVariablesComponent(Dictionary<string, int> integerValuesByHash = default(Dictionary<string, int>))
        {
            this.IntegerValuesByHash = integerValuesByHash;
        }

        /// <summary>
        /// Gets or Sets IntegerValuesByHash
        /// </summary>
        [DataMember(Name = "integerValuesByHash", EmitDefaultValue = false)]
        public Dictionary<string, int> IntegerValuesByHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsStringVariablesDestinyStringVariablesComponent {\n");
            sb.Append("  IntegerValuesByHash: ").Append(IntegerValuesByHash).Append("\n");
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
            return this.Equals(input as DestinyComponentsStringVariablesDestinyStringVariablesComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsStringVariablesDestinyStringVariablesComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsStringVariablesDestinyStringVariablesComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsStringVariablesDestinyStringVariablesComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntegerValuesByHash == input.IntegerValuesByHash ||
                    this.IntegerValuesByHash != null &&
                    input.IntegerValuesByHash != null &&
                    this.IntegerValuesByHash.SequenceEqual(input.IntegerValuesByHash)
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
                if (this.IntegerValuesByHash != null)
                {
                    hashCode = (hashCode * 59) + this.IntegerValuesByHash.GetHashCode();
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
