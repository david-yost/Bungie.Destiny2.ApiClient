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
    /// DestinyConfigImagePyramidEntry
    /// </summary>
    [DataContract(Name = "Destiny.Config.ImagePyramidEntry")]
    public partial class DestinyConfigImagePyramidEntry : IEquatable<DestinyConfigImagePyramidEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyConfigImagePyramidEntry" /> class.
        /// </summary>
        /// <param name="name">The name of the subfolder where these images are located..</param>
        /// <param name="factor">The factor by which the original image size has been reduced..</param>
        public DestinyConfigImagePyramidEntry(string name = default(string), float factor = default(float))
        {
            this.Name = name;
            this.Factor = factor;
        }

        /// <summary>
        /// The name of the subfolder where these images are located.
        /// </summary>
        /// <value>The name of the subfolder where these images are located.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The factor by which the original image size has been reduced.
        /// </summary>
        /// <value>The factor by which the original image size has been reduced.</value>
        [DataMember(Name = "factor", EmitDefaultValue = false)]
        public float Factor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyConfigImagePyramidEntry {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
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
            return this.Equals(input as DestinyConfigImagePyramidEntry);
        }

        /// <summary>
        /// Returns true if DestinyConfigImagePyramidEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyConfigImagePyramidEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyConfigImagePyramidEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Factor == input.Factor ||
                    this.Factor.Equals(input.Factor)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Factor.GetHashCode();
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
