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
    /// GroupsV2GroupFeatures
    /// </summary>
    [DataContract(Name = "GroupsV2.GroupFeatures")]
    public partial class GroupsV2GroupFeatures : IEquatable<GroupsV2GroupFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupFeatures" /> class.
        /// </summary>
        /// <param name="maximumMembers">maximumMembers.</param>
        /// <param name="maximumMembershipsOfGroupType">Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership..</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="membershipTypes">membershipTypes.</param>
        /// <param name="invitePermissionOverride">Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups..</param>
        /// <param name="updateCulturePermissionOverride">Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups..</param>
        /// <param name="hostGuidedGamePermissionOverride">Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups..</param>
        /// <param name="updateBannerPermissionOverride">Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups..</param>
        /// <param name="joinLevel">Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner..</param>
        public GroupsV2GroupFeatures(int maximumMembers = default(int), int maximumMembershipsOfGroupType = default(int), int capabilities = default(int), List<int> membershipTypes = default(List<int>), bool invitePermissionOverride = default(bool), bool updateCulturePermissionOverride = default(bool), int hostGuidedGamePermissionOverride = default(int), bool updateBannerPermissionOverride = default(bool), int joinLevel = default(int))
        {
            this.MaximumMembers = maximumMembers;
            this.MaximumMembershipsOfGroupType = maximumMembershipsOfGroupType;
            this.Capabilities = capabilities;
            this.MembershipTypes = membershipTypes;
            this.InvitePermissionOverride = invitePermissionOverride;
            this.UpdateCulturePermissionOverride = updateCulturePermissionOverride;
            this.HostGuidedGamePermissionOverride = hostGuidedGamePermissionOverride;
            this.UpdateBannerPermissionOverride = updateBannerPermissionOverride;
            this.JoinLevel = joinLevel;
        }

        /// <summary>
        /// Gets or Sets MaximumMembers
        /// </summary>
        [DataMember(Name = "maximumMembers", EmitDefaultValue = false)]
        public int MaximumMembers { get; set; }

        /// <summary>
        /// Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.
        /// </summary>
        /// <value>Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.</value>
        [DataMember(Name = "maximumMembershipsOfGroupType", EmitDefaultValue = false)]
        public int MaximumMembershipsOfGroupType { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public int Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets MembershipTypes
        /// </summary>
        [DataMember(Name = "membershipTypes", EmitDefaultValue = false)]
        public List<int> MembershipTypes { get; set; }

        /// <summary>
        /// Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        /// <value>Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</value>
        [DataMember(Name = "invitePermissionOverride", EmitDefaultValue = true)]
        public bool InvitePermissionOverride { get; set; }

        /// <summary>
        /// Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        /// <value>Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</value>
        [DataMember(Name = "updateCulturePermissionOverride", EmitDefaultValue = true)]
        public bool UpdateCulturePermissionOverride { get; set; }

        /// <summary>
        /// Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.
        /// </summary>
        /// <value>Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.</value>
        [DataMember(Name = "hostGuidedGamePermissionOverride", EmitDefaultValue = false)]
        public int HostGuidedGamePermissionOverride { get; set; }

        /// <summary>
        /// Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.
        /// </summary>
        /// <value>Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups.</value>
        [DataMember(Name = "updateBannerPermissionOverride", EmitDefaultValue = true)]
        public bool UpdateBannerPermissionOverride { get; set; }

        /// <summary>
        /// Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.
        /// </summary>
        /// <value>Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.</value>
        [DataMember(Name = "joinLevel", EmitDefaultValue = false)]
        public int JoinLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupsV2GroupFeatures {\n");
            sb.Append("  MaximumMembers: ").Append(MaximumMembers).Append("\n");
            sb.Append("  MaximumMembershipsOfGroupType: ").Append(MaximumMembershipsOfGroupType).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  MembershipTypes: ").Append(MembershipTypes).Append("\n");
            sb.Append("  InvitePermissionOverride: ").Append(InvitePermissionOverride).Append("\n");
            sb.Append("  UpdateCulturePermissionOverride: ").Append(UpdateCulturePermissionOverride).Append("\n");
            sb.Append("  HostGuidedGamePermissionOverride: ").Append(HostGuidedGamePermissionOverride).Append("\n");
            sb.Append("  UpdateBannerPermissionOverride: ").Append(UpdateBannerPermissionOverride).Append("\n");
            sb.Append("  JoinLevel: ").Append(JoinLevel).Append("\n");
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
            return this.Equals(input as GroupsV2GroupFeatures);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupFeatures input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaximumMembers == input.MaximumMembers ||
                    this.MaximumMembers.Equals(input.MaximumMembers)
                ) && 
                (
                    this.MaximumMembershipsOfGroupType == input.MaximumMembershipsOfGroupType ||
                    this.MaximumMembershipsOfGroupType.Equals(input.MaximumMembershipsOfGroupType)
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities.Equals(input.Capabilities)
                ) && 
                (
                    this.MembershipTypes == input.MembershipTypes ||
                    this.MembershipTypes != null &&
                    input.MembershipTypes != null &&
                    this.MembershipTypes.SequenceEqual(input.MembershipTypes)
                ) && 
                (
                    this.InvitePermissionOverride == input.InvitePermissionOverride ||
                    this.InvitePermissionOverride.Equals(input.InvitePermissionOverride)
                ) && 
                (
                    this.UpdateCulturePermissionOverride == input.UpdateCulturePermissionOverride ||
                    this.UpdateCulturePermissionOverride.Equals(input.UpdateCulturePermissionOverride)
                ) && 
                (
                    this.HostGuidedGamePermissionOverride == input.HostGuidedGamePermissionOverride ||
                    this.HostGuidedGamePermissionOverride.Equals(input.HostGuidedGamePermissionOverride)
                ) && 
                (
                    this.UpdateBannerPermissionOverride == input.UpdateBannerPermissionOverride ||
                    this.UpdateBannerPermissionOverride.Equals(input.UpdateBannerPermissionOverride)
                ) && 
                (
                    this.JoinLevel == input.JoinLevel ||
                    this.JoinLevel.Equals(input.JoinLevel)
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
                hashCode = (hashCode * 59) + this.MaximumMembers.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumMembershipsOfGroupType.GetHashCode();
                hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                if (this.MembershipTypes != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipTypes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvitePermissionOverride.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateCulturePermissionOverride.GetHashCode();
                hashCode = (hashCode * 59) + this.HostGuidedGamePermissionOverride.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdateBannerPermissionOverride.GetHashCode();
                hashCode = (hashCode * 59) + this.JoinLevel.GetHashCode();
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
