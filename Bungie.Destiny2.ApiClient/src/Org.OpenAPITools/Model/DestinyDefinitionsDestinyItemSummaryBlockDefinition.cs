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
    /// This appears to be information used when rendering rewards. We don&#39;t currently use it on BNet.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemSummaryBlockDefinition")]
    public partial class DestinyDefinitionsDestinyItemSummaryBlockDefinition : IEquatable<DestinyDefinitionsDestinyItemSummaryBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSummaryBlockDefinition" /> class.
        /// </summary>
        /// <param name="sortPriority">Apparently when rendering an item in a reward, this should be used as a sort priority. We&#39;re not doing it presently..</param>
        public DestinyDefinitionsDestinyItemSummaryBlockDefinition(int sortPriority = default(int))
        {
            this.SortPriority = sortPriority;
        }

        /// <summary>
        /// Apparently when rendering an item in a reward, this should be used as a sort priority. We&#39;re not doing it presently.
        /// </summary>
        /// <value>Apparently when rendering an item in a reward, this should be used as a sort priority. We&#39;re not doing it presently.</value>
        [DataMember(Name = "sortPriority", EmitDefaultValue = false)]
        public int SortPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSummaryBlockDefinition {\n");
            sb.Append("  SortPriority: ").Append(SortPriority).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSummaryBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSummaryBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSummaryBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSummaryBlockDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SortPriority == input.SortPriority ||
                    this.SortPriority.Equals(input.SortPriority)
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
                hashCode = (hashCode * 59) + this.SortPriority.GetHashCode();
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
