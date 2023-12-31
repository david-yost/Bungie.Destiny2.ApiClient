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
    /// GroupsV2GroupResponse
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupResponse")]
    public partial class GroupsV2GroupResponse : IEquatable<GroupsV2GroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupResponse" /> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        /// <param name="founder">founder.</param>
        /// <param name="alliedIds">alliedIds.</param>
        /// <param name="parentGroup">parentGroup.</param>
        /// <param name="allianceStatus">allianceStatus.</param>
        /// <param name="groupJoinInviteCount">groupJoinInviteCount.</param>
        /// <param name="currentUserMembershipsInactiveForDestiny">A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save..</param>
        /// <param name="currentUserMemberMap">This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available..</param>
        /// <param name="currentUserPotentialMemberMap">This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once..</param>
        public GroupsV2GroupResponse(GroupsV2GroupV2 detail = default(GroupsV2GroupV2), GroupsV2GroupMember founder = default(GroupsV2GroupMember), List<long> alliedIds = default(List<long>), GroupsV2GroupV2 parentGroup = default(GroupsV2GroupV2), int allianceStatus = default(int), int groupJoinInviteCount = default(int), bool currentUserMembershipsInactiveForDestiny = default(bool), Dictionary<string, GroupsV2GroupMember> currentUserMemberMap = default(Dictionary<string, GroupsV2GroupMember>), Dictionary<string, GroupsV2GroupPotentialMember> currentUserPotentialMemberMap = default(Dictionary<string, GroupsV2GroupPotentialMember>))
        {
            this.Detail = detail;
            this.Founder = founder;
            this.AlliedIds = alliedIds;
            this.ParentGroup = parentGroup;
            this.AllianceStatus = allianceStatus;
            this.GroupJoinInviteCount = groupJoinInviteCount;
            this.CurrentUserMembershipsInactiveForDestiny = currentUserMembershipsInactiveForDestiny;
            this.CurrentUserMemberMap = currentUserMemberMap;
            this.CurrentUserPotentialMemberMap = currentUserPotentialMemberMap;
        }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GroupsV2GroupV2 Detail { get; set; }

        /// <summary>
        /// Gets or Sets Founder
        /// </summary>
        [DataMember(Name = "founder", EmitDefaultValue = false)]
        public GroupsV2GroupMember Founder { get; set; }

        /// <summary>
        /// Gets or Sets AlliedIds
        /// </summary>
        [DataMember(Name = "alliedIds", EmitDefaultValue = false)]
        public List<long> AlliedIds { get; set; }

        /// <summary>
        /// Gets or Sets ParentGroup
        /// </summary>
        [DataMember(Name = "parentGroup", EmitDefaultValue = false)]
        public GroupsV2GroupV2 ParentGroup { get; set; }

        /// <summary>
        /// Gets or Sets AllianceStatus
        /// </summary>
        [DataMember(Name = "allianceStatus", EmitDefaultValue = false)]
        public int AllianceStatus { get; set; }

        /// <summary>
        /// Gets or Sets GroupJoinInviteCount
        /// </summary>
        [DataMember(Name = "groupJoinInviteCount", EmitDefaultValue = false)]
        public int GroupJoinInviteCount { get; set; }

        /// <summary>
        /// A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.
        /// </summary>
        /// <value>A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.</value>
        [DataMember(Name = "currentUserMembershipsInactiveForDestiny", EmitDefaultValue = true)]
        public bool CurrentUserMembershipsInactiveForDestiny { get; set; }

        /// <summary>
        /// This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.
        /// </summary>
        /// <value>This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.</value>
        [DataMember(Name = "currentUserMemberMap", EmitDefaultValue = false)]
        public Dictionary<string, GroupsV2GroupMember> CurrentUserMemberMap { get; set; }

        /// <summary>
        /// This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.
        /// </summary>
        /// <value>This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.</value>
        [DataMember(Name = "currentUserPotentialMemberMap", EmitDefaultValue = false)]
        public Dictionary<string, GroupsV2GroupPotentialMember> CurrentUserPotentialMemberMap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupResponse {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Founder: ").Append(Founder).Append("\n");
            sb.Append("  AlliedIds: ").Append(AlliedIds).Append("\n");
            sb.Append("  ParentGroup: ").Append(ParentGroup).Append("\n");
            sb.Append("  AllianceStatus: ").Append(AllianceStatus).Append("\n");
            sb.Append("  GroupJoinInviteCount: ").Append(GroupJoinInviteCount).Append("\n");
            sb.Append("  CurrentUserMembershipsInactiveForDestiny: ").Append(CurrentUserMembershipsInactiveForDestiny).Append("\n");
            sb.Append("  CurrentUserMemberMap: ").Append(CurrentUserMemberMap).Append("\n");
            sb.Append("  CurrentUserPotentialMemberMap: ").Append(CurrentUserPotentialMemberMap).Append("\n");
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
            return this.Equals(input as GroupsV2GroupResponse);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Founder == input.Founder ||
                    (this.Founder != null &&
                    this.Founder.Equals(input.Founder))
                ) && 
                (
                    this.AlliedIds == input.AlliedIds ||
                    this.AlliedIds != null &&
                    input.AlliedIds != null &&
                    this.AlliedIds.SequenceEqual(input.AlliedIds)
                ) && 
                (
                    this.ParentGroup == input.ParentGroup ||
                    (this.ParentGroup != null &&
                    this.ParentGroup.Equals(input.ParentGroup))
                ) && 
                (
                    this.AllianceStatus == input.AllianceStatus ||
                    this.AllianceStatus.Equals(input.AllianceStatus)
                ) && 
                (
                    this.GroupJoinInviteCount == input.GroupJoinInviteCount ||
                    this.GroupJoinInviteCount.Equals(input.GroupJoinInviteCount)
                ) && 
                (
                    this.CurrentUserMembershipsInactiveForDestiny == input.CurrentUserMembershipsInactiveForDestiny ||
                    this.CurrentUserMembershipsInactiveForDestiny.Equals(input.CurrentUserMembershipsInactiveForDestiny)
                ) && 
                (
                    this.CurrentUserMemberMap == input.CurrentUserMemberMap ||
                    this.CurrentUserMemberMap != null &&
                    input.CurrentUserMemberMap != null &&
                    this.CurrentUserMemberMap.SequenceEqual(input.CurrentUserMemberMap)
                ) && 
                (
                    this.CurrentUserPotentialMemberMap == input.CurrentUserPotentialMemberMap ||
                    this.CurrentUserPotentialMemberMap != null &&
                    input.CurrentUserPotentialMemberMap != null &&
                    this.CurrentUserPotentialMemberMap.SequenceEqual(input.CurrentUserPotentialMemberMap)
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
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
                if (this.Founder != null)
                {
                    hashCode = (hashCode * 59) + this.Founder.GetHashCode();
                }
                if (this.AlliedIds != null)
                {
                    hashCode = (hashCode * 59) + this.AlliedIds.GetHashCode();
                }
                if (this.ParentGroup != null)
                {
                    hashCode = (hashCode * 59) + this.ParentGroup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllianceStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.GroupJoinInviteCount.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentUserMembershipsInactiveForDestiny.GetHashCode();
                if (this.CurrentUserMemberMap != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentUserMemberMap.GetHashCode();
                }
                if (this.CurrentUserPotentialMemberMap != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentUserPotentialMemberMap.GetHashCode();
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
