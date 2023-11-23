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
    /// GroupsV2GroupOptionalConversation
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupOptionalConversation")]
    public partial class GroupsV2GroupOptionalConversation : IEquatable<GroupsV2GroupOptionalConversation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupOptionalConversation" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="conversationId">conversationId.</param>
        /// <param name="chatEnabled">chatEnabled.</param>
        /// <param name="chatName">chatName.</param>
        /// <param name="chatSecurity">chatSecurity.</param>
        public GroupsV2GroupOptionalConversation(long groupId = default(long), long conversationId = default(long), bool chatEnabled = default(bool), string chatName = default(string), int chatSecurity = default(int))
        {
            this.GroupId = groupId;
            this.ConversationId = conversationId;
            this.ChatEnabled = chatEnabled;
            this.ChatName = chatName;
            this.ChatSecurity = chatSecurity;
        }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name = "conversationId", EmitDefaultValue = false)]
        public long ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets ChatEnabled
        /// </summary>
        [DataMember(Name = "chatEnabled", EmitDefaultValue = true)]
        public bool ChatEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ChatName
        /// </summary>
        [DataMember(Name = "chatName", EmitDefaultValue = false)]
        public string ChatName { get; set; }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name = "chatSecurity", EmitDefaultValue = false)]
        public int ChatSecurity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupOptionalConversation {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
            sb.Append("  ChatName: ").Append(ChatName).Append("\n");
            sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
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
            return this.Equals(input as GroupsV2GroupOptionalConversation);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupOptionalConversation instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupOptionalConversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupOptionalConversation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupId == input.GroupId ||
                    this.GroupId.Equals(input.GroupId)
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    this.ConversationId.Equals(input.ConversationId)
                ) && 
                (
                    this.ChatEnabled == input.ChatEnabled ||
                    this.ChatEnabled.Equals(input.ChatEnabled)
                ) && 
                (
                    this.ChatName == input.ChatName ||
                    (this.ChatName != null &&
                    this.ChatName.Equals(input.ChatName))
                ) && 
                (
                    this.ChatSecurity == input.ChatSecurity ||
                    this.ChatSecurity.Equals(input.ChatSecurity)
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
                hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                hashCode = (hashCode * 59) + this.ConversationId.GetHashCode();
                hashCode = (hashCode * 59) + this.ChatEnabled.GetHashCode();
                if (this.ChatName != null)
                {
                    hashCode = (hashCode * 59) + this.ChatName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChatSecurity.GetHashCode();
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
