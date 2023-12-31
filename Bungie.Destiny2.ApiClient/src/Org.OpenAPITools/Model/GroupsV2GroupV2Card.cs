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
    /// A small infocard of group information, usually used for when a list of groups are returned
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupV2Card")]
    public partial class GroupsV2GroupV2Card : IEquatable<GroupsV2GroupV2Card>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupV2Card" /> class.
        /// </summary>
        /// <param name="groupId">groupId.</param>
        /// <param name="name">name.</param>
        /// <param name="groupType">groupType.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="about">about.</param>
        /// <param name="motto">motto.</param>
        /// <param name="memberCount">memberCount.</param>
        /// <param name="locale">locale.</param>
        /// <param name="membershipOption">membershipOption.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="clanInfo">clanInfo.</param>
        /// <param name="avatarPath">avatarPath.</param>
        /// <param name="theme">theme.</param>
        public GroupsV2GroupV2Card(long groupId = default(long), string name = default(string), int groupType = default(int), DateTime creationDate = default(DateTime), string about = default(string), string motto = default(string), int memberCount = default(int), string locale = default(string), int membershipOption = default(int), int capabilities = default(int), GroupsV2GroupV2ClanInfo clanInfo = default(GroupsV2GroupV2ClanInfo), string avatarPath = default(string), string theme = default(string))
        {
            this.GroupId = groupId;
            this.Name = name;
            this.GroupType = groupType;
            this.CreationDate = creationDate;
            this.About = about;
            this.Motto = motto;
            this.MemberCount = memberCount;
            this.Locale = locale;
            this.MembershipOption = membershipOption;
            this.Capabilities = capabilities;
            this.ClanInfo = clanInfo;
            this.AvatarPath = avatarPath;
            this.Theme = theme;
        }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name = "groupType", EmitDefaultValue = false)]
        public int GroupType { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name = "about", EmitDefaultValue = false)]
        public string About { get; set; }

        /// <summary>
        /// Gets or Sets Motto
        /// </summary>
        [DataMember(Name = "motto", EmitDefaultValue = false)]
        public string Motto { get; set; }

        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name = "memberCount", EmitDefaultValue = false)]
        public int MemberCount { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets MembershipOption
        /// </summary>
        [DataMember(Name = "membershipOption", EmitDefaultValue = false)]
        public int MembershipOption { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public int Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets ClanInfo
        /// </summary>
        [DataMember(Name = "clanInfo", EmitDefaultValue = false)]
        public GroupsV2GroupV2ClanInfo ClanInfo { get; set; }

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        [DataMember(Name = "avatarPath", EmitDefaultValue = false)]
        public string AvatarPath { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public string Theme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupV2Card {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Motto: ").Append(Motto).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  ClanInfo: ").Append(ClanInfo).Append("\n");
            sb.Append("  AvatarPath: ").Append(AvatarPath).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
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
            return this.Equals(input as GroupsV2GroupV2Card);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupV2Card instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupV2Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupV2Card input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    this.GroupType.Equals(input.GroupType)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.About == input.About ||
                    (this.About != null &&
                    this.About.Equals(input.About))
                ) && 
                (
                    this.Motto == input.Motto ||
                    (this.Motto != null &&
                    this.Motto.Equals(input.Motto))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    this.MemberCount.Equals(input.MemberCount)
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.MembershipOption == input.MembershipOption ||
                    this.MembershipOption.Equals(input.MembershipOption)
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities.Equals(input.Capabilities)
                ) && 
                (
                    this.ClanInfo == input.ClanInfo ||
                    (this.ClanInfo != null &&
                    this.ClanInfo.Equals(input.ClanInfo))
                ) && 
                (
                    this.AvatarPath == input.AvatarPath ||
                    (this.AvatarPath != null &&
                    this.AvatarPath.Equals(input.AvatarPath))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GroupType.GetHashCode();
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.About != null)
                {
                    hashCode = (hashCode * 59) + this.About.GetHashCode();
                }
                if (this.Motto != null)
                {
                    hashCode = (hashCode * 59) + this.Motto.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MemberCount.GetHashCode();
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MembershipOption.GetHashCode();
                hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                if (this.ClanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ClanInfo.GetHashCode();
                }
                if (this.AvatarPath != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarPath.GetHashCode();
                }
                if (this.Theme != null)
                {
                    hashCode = (hashCode * 59) + this.Theme.GetHashCode();
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
