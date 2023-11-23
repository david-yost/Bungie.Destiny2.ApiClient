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
    /// Has character-agnostic information about an item being sold by a vendor.  Note that if you want instance, stats, etc... data for the item, you&#39;ll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse&#39;s \&quot;items\&quot; property. For most of these, however, you&#39;ll have to ask for it in context of a specific character.
    /// </summary>
    [DataContract(Name = "Destiny.Components.Vendors.DestinyPublicVendorSaleItemComponent")]
    public partial class DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent : IEquatable<DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent" /> class.
        /// </summary>
        /// <param name="vendorItemIndex">The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment..</param>
        /// <param name="itemHash">The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item..</param>
        /// <param name="overrideStyleItemHash">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate..</param>
        /// <param name="quantity">How much of the item you&#39;ll be getting..</param>
        /// <param name="costs">A summary of the current costs of the item..</param>
        /// <param name="overrideNextRefreshDate">If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give..</param>
        /// <param name="apiPurchasable">If true, this item can be purchased through the Bungie.net API..</param>
        public DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent(int vendorItemIndex = default(int), int itemHash = default(int), int? overrideStyleItemHash = default(int?), int quantity = default(int), List<DestinyDestinyItemQuantity> costs = default(List<DestinyDestinyItemQuantity>), DateTime? overrideNextRefreshDate = default(DateTime?), bool? apiPurchasable = default(bool?))
        {
            this.VendorItemIndex = vendorItemIndex;
            this.ItemHash = itemHash;
            this.OverrideStyleItemHash = overrideStyleItemHash;
            this.Quantity = quantity;
            this.Costs = costs;
            this.OverrideNextRefreshDate = overrideNextRefreshDate;
            this.ApiPurchasable = apiPurchasable;
        }

        /// <summary>
        /// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
        /// </summary>
        /// <value>The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.</value>
        [DataMember(Name = "vendorItemIndex", EmitDefaultValue = false)]
        public int VendorItemIndex { get; set; }

        /// <summary>
        /// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
        /// </summary>
        /// <value>The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.</value>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.
        /// </summary>
        /// <value>If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</value>
        [DataMember(Name = "overrideStyleItemHash", EmitDefaultValue = true)]
        public int? OverrideStyleItemHash { get; set; }

        /// <summary>
        /// How much of the item you&#39;ll be getting.
        /// </summary>
        /// <value>How much of the item you&#39;ll be getting.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// A summary of the current costs of the item.
        /// </summary>
        /// <value>A summary of the current costs of the item.</value>
        [DataMember(Name = "costs", EmitDefaultValue = false)]
        public List<DestinyDestinyItemQuantity> Costs { get; set; }

        /// <summary>
        /// If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.
        /// </summary>
        /// <value>If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.</value>
        [DataMember(Name = "overrideNextRefreshDate", EmitDefaultValue = true)]
        public DateTime? OverrideNextRefreshDate { get; set; }

        /// <summary>
        /// If true, this item can be purchased through the Bungie.net API.
        /// </summary>
        /// <value>If true, this item can be purchased through the Bungie.net API.</value>
        [DataMember(Name = "apiPurchasable", EmitDefaultValue = true)]
        public bool? ApiPurchasable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent {\n");
            sb.Append("  VendorItemIndex: ").Append(VendorItemIndex).Append("\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  OverrideStyleItemHash: ").Append(OverrideStyleItemHash).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  OverrideNextRefreshDate: ").Append(OverrideNextRefreshDate).Append("\n");
            sb.Append("  ApiPurchasable: ").Append(ApiPurchasable).Append("\n");
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
            return this.Equals(input as DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VendorItemIndex == input.VendorItemIndex ||
                    this.VendorItemIndex.Equals(input.VendorItemIndex)
                ) && 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    (this.OverrideStyleItemHash != null &&
                    this.OverrideStyleItemHash.Equals(input.OverrideStyleItemHash))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Costs == input.Costs ||
                    this.Costs != null &&
                    input.Costs != null &&
                    this.Costs.SequenceEqual(input.Costs)
                ) && 
                (
                    this.OverrideNextRefreshDate == input.OverrideNextRefreshDate ||
                    (this.OverrideNextRefreshDate != null &&
                    this.OverrideNextRefreshDate.Equals(input.OverrideNextRefreshDate))
                ) && 
                (
                    this.ApiPurchasable == input.ApiPurchasable ||
                    (this.ApiPurchasable != null &&
                    this.ApiPurchasable.Equals(input.ApiPurchasable))
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
                hashCode = (hashCode * 59) + this.VendorItemIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.ItemHash.GetHashCode();
                if (this.OverrideStyleItemHash != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideStyleItemHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Costs != null)
                {
                    hashCode = (hashCode * 59) + this.Costs.GetHashCode();
                }
                if (this.OverrideNextRefreshDate != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideNextRefreshDate.GetHashCode();
                }
                if (this.ApiPurchasable != null)
                {
                    hashCode = (hashCode * 59) + this.ApiPurchasable.GetHashCode();
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
