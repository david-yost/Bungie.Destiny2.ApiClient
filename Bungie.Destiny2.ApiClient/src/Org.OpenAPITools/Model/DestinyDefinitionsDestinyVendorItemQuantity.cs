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
    /// In addition to item quantity information for vendor prices, this also has any optional information that may exist about how the item&#39;s quantity can be modified. (unfortunately not information that is able to be read outside of the BNet servers, but it&#39;s there)
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyVendorItemQuantity")]
    public partial class DestinyDefinitionsDestinyVendorItemQuantity : IEquatable<DestinyDefinitionsDestinyVendorItemQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorItemQuantity" /> class.
        /// </summary>
        /// <param name="itemHash">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition..</param>
        /// <param name="itemInstanceId">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null..</param>
        /// <param name="quantity">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used..</param>
        /// <param name="hasConditionalVisibility">Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress..</param>
        public DestinyDefinitionsDestinyVendorItemQuantity(int itemHash = default(int), long? itemInstanceId = default(long?), int quantity = default(int), bool hasConditionalVisibility = default(bool))
        {
            this.ItemHash = itemHash;
            this.ItemInstanceId = itemInstanceId;
            this.Quantity = quantity;
            this.HasConditionalVisibility = hasConditionalVisibility;
        }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        /// <value>The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</value>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        /// <value>If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</value>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = true)]
        public long? ItemInstanceId { get; set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        /// <value>The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress.
        /// </summary>
        /// <value>Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress.</value>
        [DataMember(Name = "hasConditionalVisibility", EmitDefaultValue = true)]
        public bool HasConditionalVisibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyVendorItemQuantity {\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  HasConditionalVisibility: ").Append(HasConditionalVisibility).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorItemQuantity);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorItemQuantity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    (this.ItemInstanceId != null &&
                    this.ItemInstanceId.Equals(input.ItemInstanceId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.HasConditionalVisibility == input.HasConditionalVisibility ||
                    this.HasConditionalVisibility.Equals(input.HasConditionalVisibility)
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
                hashCode = (hashCode * 59) + this.ItemHash.GetHashCode();
                if (this.ItemInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemInstanceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.HasConditionalVisibility.GetHashCode();
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
