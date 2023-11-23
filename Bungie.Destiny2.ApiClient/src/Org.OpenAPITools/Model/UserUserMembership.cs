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
    /// Very basic info about a user as returned by the Account server.
    /// </summary>
    [DataContract(Name = "User.UserMembership")]
    public partial class UserUserMembership : IEquatable<UserUserMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserMembership" /> class.
        /// </summary>
        /// <param name="membershipType">Type of the membership. Not necessarily the native type..</param>
        /// <param name="membershipId">Membership ID as they user is known in the Accounts service.</param>
        /// <param name="displayName">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API..</param>
        /// <param name="bungieGlobalDisplayName">The bungie global display name, if set..</param>
        /// <param name="bungieGlobalDisplayNameCode">The bungie global display name code, if set..</param>
        public UserUserMembership(int membershipType = default(int), long membershipId = default(long), string displayName = default(string), string bungieGlobalDisplayName = default(string), int? bungieGlobalDisplayNameCode = default(int?))
        {
            this.MembershipType = membershipType;
            this.MembershipId = membershipId;
            this.DisplayName = displayName;
            this.BungieGlobalDisplayName = bungieGlobalDisplayName;
            this.BungieGlobalDisplayNameCode = bungieGlobalDisplayNameCode;
        }

        /// <summary>
        /// Type of the membership. Not necessarily the native type.
        /// </summary>
        /// <value>Type of the membership. Not necessarily the native type.</value>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public int MembershipType { get; set; }

        /// <summary>
        /// Membership ID as they user is known in the Accounts service
        /// </summary>
        /// <value>Membership ID as they user is known in the Accounts service</value>
        [DataMember(Name = "membershipId", EmitDefaultValue = false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
        /// </summary>
        /// <value>Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The bungie global display name, if set.
        /// </summary>
        /// <value>The bungie global display name, if set.</value>
        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        /// <summary>
        /// The bungie global display name code, if set.
        /// </summary>
        /// <value>The bungie global display name code, if set.</value>
        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = true)]
        public int? BungieGlobalDisplayNameCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserUserMembership {\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  BungieGlobalDisplayName: ").Append(BungieGlobalDisplayName).Append("\n");
            sb.Append("  BungieGlobalDisplayNameCode: ").Append(BungieGlobalDisplayNameCode).Append("\n");
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
            return this.Equals(input as UserUserMembership);
        }

        /// <summary>
        /// Returns true if UserUserMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserMembership input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.MembershipId == input.MembershipId ||
                    this.MembershipId.Equals(input.MembershipId)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (this.BungieGlobalDisplayName != null &&
                    this.BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) && 
                (
                    this.BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (this.BungieGlobalDisplayNameCode != null &&
                    this.BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
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
                hashCode = (hashCode * 59) + this.MembershipType.GetHashCode();
                hashCode = (hashCode * 59) + this.MembershipId.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.BungieGlobalDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.BungieGlobalDisplayName.GetHashCode();
                }
                if (this.BungieGlobalDisplayNameCode != null)
                {
                    hashCode = (hashCode * 59) + this.BungieGlobalDisplayNameCode.GetHashCode();
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
