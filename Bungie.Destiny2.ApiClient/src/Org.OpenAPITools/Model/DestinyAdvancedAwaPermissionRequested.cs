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
    /// DestinyAdvancedAwaPermissionRequested
    /// </summary>
    [DataContract(Name = "Destiny.Advanced.AwaPermissionRequested")]
    public partial class DestinyAdvancedAwaPermissionRequested : IEquatable<DestinyAdvancedAwaPermissionRequested>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyAdvancedAwaPermissionRequested" /> class.
        /// </summary>
        /// <param name="type">Type of advanced write action..</param>
        /// <param name="affectedItemId">Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available..</param>
        /// <param name="membershipType">Destiny membership type of the account to modify..</param>
        /// <param name="characterId">Destiny character ID, if applicable, that will be affected by the action..</param>
        public DestinyAdvancedAwaPermissionRequested(int type = default(int), long? affectedItemId = default(long?), int membershipType = default(int), long? characterId = default(long?))
        {
            this.Type = type;
            this.AffectedItemId = affectedItemId;
            this.MembershipType = membershipType;
            this.CharacterId = characterId;
        }

        /// <summary>
        /// Type of advanced write action.
        /// </summary>
        /// <value>Type of advanced write action.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public int Type { get; set; }

        /// <summary>
        /// Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.
        /// </summary>
        /// <value>Item instance ID the action shall be applied to. This is optional for all but a new AwaType values. Rule of thumb is to provide the item instance ID if one is available.</value>
        [DataMember(Name = "affectedItemId", EmitDefaultValue = true)]
        public long? AffectedItemId { get; set; }

        /// <summary>
        /// Destiny membership type of the account to modify.
        /// </summary>
        /// <value>Destiny membership type of the account to modify.</value>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public int MembershipType { get; set; }

        /// <summary>
        /// Destiny character ID, if applicable, that will be affected by the action.
        /// </summary>
        /// <value>Destiny character ID, if applicable, that will be affected by the action.</value>
        [DataMember(Name = "characterId", EmitDefaultValue = true)]
        public long? CharacterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyAdvancedAwaPermissionRequested {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AffectedItemId: ").Append(AffectedItemId).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
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
            return this.Equals(input as DestinyAdvancedAwaPermissionRequested);
        }

        /// <summary>
        /// Returns true if DestinyAdvancedAwaPermissionRequested instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyAdvancedAwaPermissionRequested to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyAdvancedAwaPermissionRequested input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.AffectedItemId == input.AffectedItemId ||
                    (this.AffectedItemId != null &&
                    this.AffectedItemId.Equals(input.AffectedItemId))
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AffectedItemId != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MembershipType.GetHashCode();
                if (this.CharacterId != null)
                {
                    hashCode = (hashCode * 59) + this.CharacterId.GetHashCode();
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
