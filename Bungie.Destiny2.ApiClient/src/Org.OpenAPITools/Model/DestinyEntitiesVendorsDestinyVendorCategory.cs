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
    /// Information about the category and items currently sold in that category.
    /// </summary>
    [DataContract(Name = "Destiny.Entities.Vendors.DestinyVendorCategory")]
    public partial class DestinyEntitiesVendorsDestinyVendorCategory : IEquatable<DestinyEntitiesVendorsDestinyVendorCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesVendorsDestinyVendorCategory" /> class.
        /// </summary>
        /// <param name="displayCategoryIndex">An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category..</param>
        /// <param name="itemIndexes">An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned..</param>
        public DestinyEntitiesVendorsDestinyVendorCategory(int displayCategoryIndex = default(int), List<int> itemIndexes = default(List<int>))
        {
            this.DisplayCategoryIndex = displayCategoryIndex;
            this.ItemIndexes = itemIndexes;
        }

        /// <summary>
        /// An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.
        /// </summary>
        /// <value>An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.</value>
        [DataMember(Name = "displayCategoryIndex", EmitDefaultValue = false)]
        public int DisplayCategoryIndex { get; set; }

        /// <summary>
        /// An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.
        /// </summary>
        /// <value>An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.</value>
        [DataMember(Name = "itemIndexes", EmitDefaultValue = false)]
        public List<int> ItemIndexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyEntitiesVendorsDestinyVendorCategory {\n");
            sb.Append("  DisplayCategoryIndex: ").Append(DisplayCategoryIndex).Append("\n");
            sb.Append("  ItemIndexes: ").Append(ItemIndexes).Append("\n");
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
            return this.Equals(input as DestinyEntitiesVendorsDestinyVendorCategory);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesVendorsDestinyVendorCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesVendorsDestinyVendorCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesVendorsDestinyVendorCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayCategoryIndex == input.DisplayCategoryIndex ||
                    this.DisplayCategoryIndex.Equals(input.DisplayCategoryIndex)
                ) && 
                (
                    this.ItemIndexes == input.ItemIndexes ||
                    this.ItemIndexes != null &&
                    input.ItemIndexes != null &&
                    this.ItemIndexes.SequenceEqual(input.ItemIndexes)
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
                hashCode = (hashCode * 59) + this.DisplayCategoryIndex.GetHashCode();
                if (this.ItemIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIndexes.GetHashCode();
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