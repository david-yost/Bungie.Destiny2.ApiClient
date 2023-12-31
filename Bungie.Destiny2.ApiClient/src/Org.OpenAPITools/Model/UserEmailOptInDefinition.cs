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
    /// Defines a single opt-in category: a wide-scoped permission to send emails for the subject related to the opt-in.
    /// </summary>
    [DataContract(Name = "User.EmailOptInDefinition")]
    public partial class UserEmailOptInDefinition : IEquatable<UserEmailOptInDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmailOptInDefinition" /> class.
        /// </summary>
        /// <param name="name">The unique identifier for this opt-in category..</param>
        /// <param name="value">The flag value for this opt-in category. For historical reasons, this is defined as a flags enum..</param>
        /// <param name="setByDefault">If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into..</param>
        /// <param name="dependentSubscriptions">Information about the dependent subscriptions for this opt-in..</param>
        public UserEmailOptInDefinition(string name = default(string), long value = default(long), bool setByDefault = default(bool), List<UserEmailSubscriptionDefinition> dependentSubscriptions = default(List<UserEmailSubscriptionDefinition>))
        {
            this.Name = name;
            this.Value = value;
            this.SetByDefault = setByDefault;
            this.DependentSubscriptions = dependentSubscriptions;
        }

        /// <summary>
        /// The unique identifier for this opt-in category.
        /// </summary>
        /// <value>The unique identifier for this opt-in category.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.
        /// </summary>
        /// <value>The flag value for this opt-in category. For historical reasons, this is defined as a flags enum.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public long Value { get; set; }

        /// <summary>
        /// If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into.
        /// </summary>
        /// <value>If true, this opt-in setting should be set by default in situations where accounts are created without explicit choices about what they&#39;re opting into.</value>
        [DataMember(Name = "setByDefault", EmitDefaultValue = true)]
        public bool SetByDefault { get; set; }

        /// <summary>
        /// Information about the dependent subscriptions for this opt-in.
        /// </summary>
        /// <value>Information about the dependent subscriptions for this opt-in.</value>
        [DataMember(Name = "dependentSubscriptions", EmitDefaultValue = false)]
        public List<UserEmailSubscriptionDefinition> DependentSubscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEmailOptInDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SetByDefault: ").Append(SetByDefault).Append("\n");
            sb.Append("  DependentSubscriptions: ").Append(DependentSubscriptions).Append("\n");
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
            return this.Equals(input as UserEmailOptInDefinition);
        }

        /// <summary>
        /// Returns true if UserEmailOptInDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEmailOptInDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEmailOptInDefinition input)
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
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.SetByDefault == input.SetByDefault ||
                    this.SetByDefault.Equals(input.SetByDefault)
                ) && 
                (
                    this.DependentSubscriptions == input.DependentSubscriptions ||
                    this.DependentSubscriptions != null &&
                    input.DependentSubscriptions != null &&
                    this.DependentSubscriptions.SequenceEqual(input.DependentSubscriptions)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.SetByDefault.GetHashCode();
                if (this.DependentSubscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.DependentSubscriptions.GetHashCode();
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
