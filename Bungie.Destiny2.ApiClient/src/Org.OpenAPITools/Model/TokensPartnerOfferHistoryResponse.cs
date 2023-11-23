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
    /// TokensPartnerOfferHistoryResponse
    /// </summary>
    [DataContract(Name = "Tokens.PartnerOfferHistoryResponse")]
    public partial class TokensPartnerOfferHistoryResponse : IEquatable<TokensPartnerOfferHistoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines MembershipType
        /// </summary>
        public enum MembershipTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            NUMBER_10 = 10,

            /// <summary>
            /// Enum NUMBER_254 for value: 254
            /// </summary>
            NUMBER_254 = 254,

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1
        }


        /// <summary>
        /// Gets or Sets MembershipType
        /// </summary>
        [DataMember(Name = "MembershipType", EmitDefaultValue = true)]
        public MembershipTypeEnum? MembershipType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensPartnerOfferHistoryResponse" /> class.
        /// </summary>
        /// <param name="partnerOfferKey">partnerOfferKey.</param>
        /// <param name="membershipId">membershipId.</param>
        /// <param name="membershipType">membershipType.</param>
        /// <param name="localizedName">localizedName.</param>
        /// <param name="localizedDescription">localizedDescription.</param>
        /// <param name="isConsumable">isConsumable.</param>
        /// <param name="quantityApplied">quantityApplied.</param>
        /// <param name="applyDate">applyDate.</param>
        public TokensPartnerOfferHistoryResponse(string partnerOfferKey = default(string), long? membershipId = default(long?), MembershipTypeEnum? membershipType = default(MembershipTypeEnum?), string localizedName = default(string), string localizedDescription = default(string), bool isConsumable = default(bool), int quantityApplied = default(int), DateTime? applyDate = default(DateTime?))
        {
            this.PartnerOfferKey = partnerOfferKey;
            this.MembershipId = membershipId;
            this.MembershipType = membershipType;
            this.LocalizedName = localizedName;
            this.LocalizedDescription = localizedDescription;
            this.IsConsumable = isConsumable;
            this.QuantityApplied = quantityApplied;
            this.ApplyDate = applyDate;
        }

        /// <summary>
        /// Gets or Sets PartnerOfferKey
        /// </summary>
        [DataMember(Name = "PartnerOfferKey", EmitDefaultValue = false)]
        public string PartnerOfferKey { get; set; }

        /// <summary>
        /// Gets or Sets MembershipId
        /// </summary>
        [DataMember(Name = "MembershipId", EmitDefaultValue = true)]
        public long? MembershipId { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedName
        /// </summary>
        [DataMember(Name = "LocalizedName", EmitDefaultValue = false)]
        public string LocalizedName { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedDescription
        /// </summary>
        [DataMember(Name = "LocalizedDescription", EmitDefaultValue = false)]
        public string LocalizedDescription { get; set; }

        /// <summary>
        /// Gets or Sets IsConsumable
        /// </summary>
        [DataMember(Name = "IsConsumable", EmitDefaultValue = true)]
        public bool IsConsumable { get; set; }

        /// <summary>
        /// Gets or Sets QuantityApplied
        /// </summary>
        [DataMember(Name = "QuantityApplied", EmitDefaultValue = false)]
        public int QuantityApplied { get; set; }

        /// <summary>
        /// Gets or Sets ApplyDate
        /// </summary>
        [DataMember(Name = "ApplyDate", EmitDefaultValue = true)]
        public DateTime? ApplyDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensPartnerOfferHistoryResponse {\n");
            sb.Append("  PartnerOfferKey: ").Append(PartnerOfferKey).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  LocalizedName: ").Append(LocalizedName).Append("\n");
            sb.Append("  LocalizedDescription: ").Append(LocalizedDescription).Append("\n");
            sb.Append("  IsConsumable: ").Append(IsConsumable).Append("\n");
            sb.Append("  QuantityApplied: ").Append(QuantityApplied).Append("\n");
            sb.Append("  ApplyDate: ").Append(ApplyDate).Append("\n");
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
            return this.Equals(input as TokensPartnerOfferHistoryResponse);
        }

        /// <summary>
        /// Returns true if TokensPartnerOfferHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensPartnerOfferHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensPartnerOfferHistoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PartnerOfferKey == input.PartnerOfferKey ||
                    (this.PartnerOfferKey != null &&
                    this.PartnerOfferKey.Equals(input.PartnerOfferKey))
                ) && 
                (
                    this.MembershipId == input.MembershipId ||
                    (this.MembershipId != null &&
                    this.MembershipId.Equals(input.MembershipId))
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.LocalizedName == input.LocalizedName ||
                    (this.LocalizedName != null &&
                    this.LocalizedName.Equals(input.LocalizedName))
                ) && 
                (
                    this.LocalizedDescription == input.LocalizedDescription ||
                    (this.LocalizedDescription != null &&
                    this.LocalizedDescription.Equals(input.LocalizedDescription))
                ) && 
                (
                    this.IsConsumable == input.IsConsumable ||
                    this.IsConsumable.Equals(input.IsConsumable)
                ) && 
                (
                    this.QuantityApplied == input.QuantityApplied ||
                    this.QuantityApplied.Equals(input.QuantityApplied)
                ) && 
                (
                    this.ApplyDate == input.ApplyDate ||
                    (this.ApplyDate != null &&
                    this.ApplyDate.Equals(input.ApplyDate))
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
                if (this.PartnerOfferKey != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerOfferKey.GetHashCode();
                }
                if (this.MembershipId != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MembershipType.GetHashCode();
                if (this.LocalizedName != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedName.GetHashCode();
                }
                if (this.LocalizedDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsConsumable.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityApplied.GetHashCode();
                if (this.ApplyDate != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyDate.GetHashCode();
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
