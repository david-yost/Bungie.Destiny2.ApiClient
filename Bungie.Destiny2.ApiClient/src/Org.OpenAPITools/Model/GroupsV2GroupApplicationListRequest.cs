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
    /// GroupsV2GroupApplicationListRequest
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupApplicationListRequest")]
    public partial class GroupsV2GroupApplicationListRequest : IEquatable<GroupsV2GroupApplicationListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupApplicationListRequest" /> class.
        /// </summary>
        /// <param name="memberships">memberships.</param>
        /// <param name="message">message.</param>
        public GroupsV2GroupApplicationListRequest(List<UserUserMembership> memberships = default(List<UserUserMembership>), string message = default(string))
        {
            this.Memberships = memberships;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Memberships
        /// </summary>
        [DataMember(Name = "memberships", EmitDefaultValue = false)]
        public List<UserUserMembership> Memberships { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupApplicationListRequest {\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as GroupsV2GroupApplicationListRequest);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupApplicationListRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupApplicationListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupApplicationListRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Memberships == input.Memberships ||
                    this.Memberships != null &&
                    input.Memberships != null &&
                    this.Memberships.SequenceEqual(input.Memberships)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Memberships != null)
                {
                    hashCode = (hashCode * 59) + this.Memberships.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
