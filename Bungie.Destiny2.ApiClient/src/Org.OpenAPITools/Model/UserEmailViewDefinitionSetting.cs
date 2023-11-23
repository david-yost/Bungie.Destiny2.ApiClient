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
    /// UserEmailViewDefinitionSetting
    /// </summary>
    [DataContract(Name = "User.EmailViewDefinitionSetting")]
    public partial class UserEmailViewDefinitionSetting : IEquatable<UserEmailViewDefinitionSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmailViewDefinitionSetting" /> class.
        /// </summary>
        /// <param name="name">The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired..</param>
        /// <param name="localization">A dictionary of localized text for the EMail setting, keyed by the locale..</param>
        /// <param name="setByDefault">If true, this setting should be set by default if the user hasn&#39;t chosen whether it&#39;s set or cleared yet..</param>
        /// <param name="optInAggregateValue">The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting..</param>
        /// <param name="subscriptions">The subscriptions to show as children of this setting, if any..</param>
        public UserEmailViewDefinitionSetting(string name = default(string), Dictionary<string, UserEMailSettingLocalization> localization = default(Dictionary<string, UserEMailSettingLocalization>), bool setByDefault = default(bool), long optInAggregateValue = default(long), List<UserEmailSubscriptionDefinition> subscriptions = default(List<UserEmailSubscriptionDefinition>))
        {
            this.Name = name;
            this.Localization = localization;
            this.SetByDefault = setByDefault;
            this.OptInAggregateValue = optInAggregateValue;
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.
        /// </summary>
        /// <value>The identifier for this UI Setting, which can be used to relate it to custom strings or other data as desired.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A dictionary of localized text for the EMail setting, keyed by the locale.
        /// </summary>
        /// <value>A dictionary of localized text for the EMail setting, keyed by the locale.</value>
        [DataMember(Name = "localization", EmitDefaultValue = false)]
        public Dictionary<string, UserEMailSettingLocalization> Localization { get; set; }

        /// <summary>
        /// If true, this setting should be set by default if the user hasn&#39;t chosen whether it&#39;s set or cleared yet.
        /// </summary>
        /// <value>If true, this setting should be set by default if the user hasn&#39;t chosen whether it&#39;s set or cleared yet.</value>
        [DataMember(Name = "setByDefault", EmitDefaultValue = true)]
        public bool SetByDefault { get; set; }

        /// <summary>
        /// The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.
        /// </summary>
        /// <value>The OptInFlags value to set or clear if this setting is set or cleared in the UI. It is the aggregate of all underlying opt-in flags related to this setting.</value>
        [DataMember(Name = "optInAggregateValue", EmitDefaultValue = false)]
        public long OptInAggregateValue { get; set; }

        /// <summary>
        /// The subscriptions to show as children of this setting, if any.
        /// </summary>
        /// <value>The subscriptions to show as children of this setting, if any.</value>
        [DataMember(Name = "subscriptions", EmitDefaultValue = false)]
        public List<UserEmailSubscriptionDefinition> Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserEmailViewDefinitionSetting {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Localization: ").Append(Localization).Append("\n");
            sb.Append("  SetByDefault: ").Append(SetByDefault).Append("\n");
            sb.Append("  OptInAggregateValue: ").Append(OptInAggregateValue).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(input as UserEmailViewDefinitionSetting);
        }

        /// <summary>
        /// Returns true if UserEmailViewDefinitionSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEmailViewDefinitionSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEmailViewDefinitionSetting input)
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
                    this.Localization == input.Localization ||
                    this.Localization != null &&
                    input.Localization != null &&
                    this.Localization.SequenceEqual(input.Localization)
                ) && 
                (
                    this.SetByDefault == input.SetByDefault ||
                    this.SetByDefault.Equals(input.SetByDefault)
                ) && 
                (
                    this.OptInAggregateValue == input.OptInAggregateValue ||
                    this.OptInAggregateValue.Equals(input.OptInAggregateValue)
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
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
                if (this.Localization != null)
                {
                    hashCode = (hashCode * 59) + this.Localization.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SetByDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.OptInAggregateValue.GetHashCode();
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
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
