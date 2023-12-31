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
    /// Some basic information about whether you can be joined, how many slots are left etc. Note that this can change quickly, so it may not actually be useful. But perhaps it will be in some use cases?
    /// </summary>
    [DataContract(Name = "Destiny.Components.Profiles.DestinyProfileTransitoryJoinability")]
    public partial class DestinyComponentsProfilesDestinyProfileTransitoryJoinability : IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryJoinability>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsProfilesDestinyProfileTransitoryJoinability" /> class.
        /// </summary>
        /// <param name="openSlots">The number of slots still available on this person&#39;s fireteam..</param>
        /// <param name="privacySetting">Who the person is currently allowing invites from..</param>
        /// <param name="closedReasons">Reasons why a person can&#39;t join this person&#39;s fireteam..</param>
        public DestinyComponentsProfilesDestinyProfileTransitoryJoinability(int openSlots = default(int), int privacySetting = default(int), int closedReasons = default(int))
        {
            this.OpenSlots = openSlots;
            this.PrivacySetting = privacySetting;
            this.ClosedReasons = closedReasons;
        }

        /// <summary>
        /// The number of slots still available on this person&#39;s fireteam.
        /// </summary>
        /// <value>The number of slots still available on this person&#39;s fireteam.</value>
        [DataMember(Name = "openSlots", EmitDefaultValue = false)]
        public int OpenSlots { get; set; }

        /// <summary>
        /// Who the person is currently allowing invites from.
        /// </summary>
        /// <value>Who the person is currently allowing invites from.</value>
        [DataMember(Name = "privacySetting", EmitDefaultValue = false)]
        public int PrivacySetting { get; set; }

        /// <summary>
        /// Reasons why a person can&#39;t join this person&#39;s fireteam.
        /// </summary>
        /// <value>Reasons why a person can&#39;t join this person&#39;s fireteam.</value>
        [DataMember(Name = "closedReasons", EmitDefaultValue = false)]
        public int ClosedReasons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryJoinability {\n");
            sb.Append("  OpenSlots: ").Append(OpenSlots).Append("\n");
            sb.Append("  PrivacySetting: ").Append(PrivacySetting).Append("\n");
            sb.Append("  ClosedReasons: ").Append(ClosedReasons).Append("\n");
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
            return this.Equals(input as DestinyComponentsProfilesDestinyProfileTransitoryJoinability);
        }

        /// <summary>
        /// Returns true if DestinyComponentsProfilesDestinyProfileTransitoryJoinability instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsProfilesDestinyProfileTransitoryJoinability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryJoinability input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpenSlots == input.OpenSlots ||
                    this.OpenSlots.Equals(input.OpenSlots)
                ) && 
                (
                    this.PrivacySetting == input.PrivacySetting ||
                    this.PrivacySetting.Equals(input.PrivacySetting)
                ) && 
                (
                    this.ClosedReasons == input.ClosedReasons ||
                    this.ClosedReasons.Equals(input.ClosedReasons)
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
                hashCode = (hashCode * 59) + this.OpenSlots.GetHashCode();
                hashCode = (hashCode * 59) + this.PrivacySetting.GetHashCode();
                hashCode = (hashCode * 59) + this.ClosedReasons.GetHashCode();
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
