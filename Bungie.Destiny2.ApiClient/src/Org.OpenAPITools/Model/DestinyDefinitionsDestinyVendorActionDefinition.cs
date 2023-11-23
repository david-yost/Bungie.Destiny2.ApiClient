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
    /// If a vendor can ever end up performing actions, these are the properties that will be related to those actions. I&#39;m not going to bother documenting this yet, as it is unused and unclear if it will ever be used... but in case it is ever populated and someone finds it useful, it is defined here.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyVendorActionDefinition")]
    public partial class DestinyDefinitionsDestinyVendorActionDefinition : IEquatable<DestinyDefinitionsDestinyVendorActionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorActionDefinition" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="executeSeconds">executeSeconds.</param>
        /// <param name="icon">icon.</param>
        /// <param name="name">name.</param>
        /// <param name="verb">verb.</param>
        /// <param name="isPositive">isPositive.</param>
        /// <param name="actionId">actionId.</param>
        /// <param name="actionHash">actionHash.</param>
        /// <param name="autoPerformAction">autoPerformAction.</param>
        public DestinyDefinitionsDestinyVendorActionDefinition(string description = default(string), int executeSeconds = default(int), string icon = default(string), string name = default(string), string verb = default(string), bool isPositive = default(bool), string actionId = default(string), int actionHash = default(int), bool autoPerformAction = default(bool))
        {
            this.Description = description;
            this.ExecuteSeconds = executeSeconds;
            this.Icon = icon;
            this.Name = name;
            this.Verb = verb;
            this.IsPositive = isPositive;
            this.ActionId = actionId;
            this.ActionHash = actionHash;
            this.AutoPerformAction = autoPerformAction;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExecuteSeconds
        /// </summary>
        [DataMember(Name = "executeSeconds", EmitDefaultValue = false)]
        public int ExecuteSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Verb
        /// </summary>
        [DataMember(Name = "verb", EmitDefaultValue = false)]
        public string Verb { get; set; }

        /// <summary>
        /// Gets or Sets IsPositive
        /// </summary>
        [DataMember(Name = "isPositive", EmitDefaultValue = true)]
        public bool IsPositive { get; set; }

        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or Sets ActionHash
        /// </summary>
        [DataMember(Name = "actionHash", EmitDefaultValue = false)]
        public int ActionHash { get; set; }

        /// <summary>
        /// Gets or Sets AutoPerformAction
        /// </summary>
        [DataMember(Name = "autoPerformAction", EmitDefaultValue = true)]
        public bool AutoPerformAction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyVendorActionDefinition {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExecuteSeconds: ").Append(ExecuteSeconds).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
            sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  ActionHash: ").Append(ActionHash).Append("\n");
            sb.Append("  AutoPerformAction: ").Append(AutoPerformAction).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorActionDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorActionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorActionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorActionDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExecuteSeconds == input.ExecuteSeconds ||
                    this.ExecuteSeconds.Equals(input.ExecuteSeconds)
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Verb == input.Verb ||
                    (this.Verb != null &&
                    this.Verb.Equals(input.Verb))
                ) && 
                (
                    this.IsPositive == input.IsPositive ||
                    this.IsPositive.Equals(input.IsPositive)
                ) && 
                (
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.ActionHash == input.ActionHash ||
                    this.ActionHash.Equals(input.ActionHash)
                ) && 
                (
                    this.AutoPerformAction == input.AutoPerformAction ||
                    this.AutoPerformAction.Equals(input.AutoPerformAction)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExecuteSeconds.GetHashCode();
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Verb != null)
                {
                    hashCode = (hashCode * 59) + this.Verb.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPositive.GetHashCode();
                if (this.ActionId != null)
                {
                    hashCode = (hashCode * 59) + this.ActionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActionHash.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoPerformAction.GetHashCode();
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