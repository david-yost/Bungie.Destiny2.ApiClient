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
    /// ConfigUserTheme
    /// </summary>
    [DataContract(Name = "Config.UserTheme")]
    public partial class ConfigUserTheme : IEquatable<ConfigUserTheme>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigUserTheme" /> class.
        /// </summary>
        /// <param name="userThemeId">userThemeId.</param>
        /// <param name="userThemeName">userThemeName.</param>
        /// <param name="userThemeDescription">userThemeDescription.</param>
        public ConfigUserTheme(int userThemeId = default(int), string userThemeName = default(string), string userThemeDescription = default(string))
        {
            this.UserThemeId = userThemeId;
            this.UserThemeName = userThemeName;
            this.UserThemeDescription = userThemeDescription;
        }

        /// <summary>
        /// Gets or Sets UserThemeId
        /// </summary>
        [DataMember(Name = "userThemeId", EmitDefaultValue = false)]
        public int UserThemeId { get; set; }

        /// <summary>
        /// Gets or Sets UserThemeName
        /// </summary>
        [DataMember(Name = "userThemeName", EmitDefaultValue = false)]
        public string UserThemeName { get; set; }

        /// <summary>
        /// Gets or Sets UserThemeDescription
        /// </summary>
        [DataMember(Name = "userThemeDescription", EmitDefaultValue = false)]
        public string UserThemeDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigUserTheme {\n");
            sb.Append("  UserThemeId: ").Append(UserThemeId).Append("\n");
            sb.Append("  UserThemeName: ").Append(UserThemeName).Append("\n");
            sb.Append("  UserThemeDescription: ").Append(UserThemeDescription).Append("\n");
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
            return this.Equals(input as ConfigUserTheme);
        }

        /// <summary>
        /// Returns true if ConfigUserTheme instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigUserTheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigUserTheme input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserThemeId == input.UserThemeId ||
                    this.UserThemeId.Equals(input.UserThemeId)
                ) && 
                (
                    this.UserThemeName == input.UserThemeName ||
                    (this.UserThemeName != null &&
                    this.UserThemeName.Equals(input.UserThemeName))
                ) && 
                (
                    this.UserThemeDescription == input.UserThemeDescription ||
                    (this.UserThemeDescription != null &&
                    this.UserThemeDescription.Equals(input.UserThemeDescription))
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
                hashCode = (hashCode * 59) + this.UserThemeId.GetHashCode();
                if (this.UserThemeName != null)
                {
                    hashCode = (hashCode * 59) + this.UserThemeName.GetHashCode();
                }
                if (this.UserThemeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.UserThemeDescription.GetHashCode();
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
