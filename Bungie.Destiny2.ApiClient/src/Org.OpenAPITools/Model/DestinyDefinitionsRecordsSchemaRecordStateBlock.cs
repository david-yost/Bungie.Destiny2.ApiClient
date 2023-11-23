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
    /// DestinyDefinitionsRecordsSchemaRecordStateBlock
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Records.SchemaRecordStateBlock")]
    public partial class DestinyDefinitionsRecordsSchemaRecordStateBlock : IEquatable<DestinyDefinitionsRecordsSchemaRecordStateBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsRecordsSchemaRecordStateBlock" /> class.
        /// </summary>
        /// <param name="featuredPriority">featuredPriority.</param>
        /// <param name="obscuredString">obscuredString.</param>
        public DestinyDefinitionsRecordsSchemaRecordStateBlock(int featuredPriority = default(int), string obscuredString = default(string))
        {
            this.FeaturedPriority = featuredPriority;
            this.ObscuredString = obscuredString;
        }

        /// <summary>
        /// Gets or Sets FeaturedPriority
        /// </summary>
        [DataMember(Name = "featuredPriority", EmitDefaultValue = false)]
        public int FeaturedPriority { get; set; }

        /// <summary>
        /// Gets or Sets ObscuredString
        /// </summary>
        [DataMember(Name = "obscuredString", EmitDefaultValue = false)]
        public string ObscuredString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsRecordsSchemaRecordStateBlock {\n");
            sb.Append("  FeaturedPriority: ").Append(FeaturedPriority).Append("\n");
            sb.Append("  ObscuredString: ").Append(ObscuredString).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsRecordsSchemaRecordStateBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsRecordsSchemaRecordStateBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsRecordsSchemaRecordStateBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsRecordsSchemaRecordStateBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FeaturedPriority == input.FeaturedPriority ||
                    this.FeaturedPriority.Equals(input.FeaturedPriority)
                ) && 
                (
                    this.ObscuredString == input.ObscuredString ||
                    (this.ObscuredString != null &&
                    this.ObscuredString.Equals(input.ObscuredString))
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
                hashCode = (hashCode * 59) + this.FeaturedPriority.GetHashCode();
                if (this.ObscuredString != null)
                {
                    hashCode = (hashCode * 59) + this.ObscuredString.GetHashCode();
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
