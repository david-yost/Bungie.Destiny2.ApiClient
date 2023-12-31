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
    /// The definition for an \&quot;inventory flyout\&quot;: a UI screen where we show you part of an otherwise hidden vendor inventory: like the Vault inventory buckets.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyVendorInventoryFlyoutDefinition")]
    public partial class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition : IEquatable<DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition" /> class.
        /// </summary>
        /// <param name="lockedDescription">If the flyout is locked, this is the reason why..</param>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="buckets">A list of inventory buckets and other metadata to show on the screen..</param>
        /// <param name="flyoutId">An identifier for the flyout, in case anything else needs to refer to them..</param>
        /// <param name="suppressNewness">If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI..</param>
        /// <param name="equipmentSlotHash">If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show..</param>
        public DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition(string lockedDescription = default(string), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> buckets = default(List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition>), int flyoutId = default(int), bool suppressNewness = default(bool), int? equipmentSlotHash = default(int?))
        {
            this.LockedDescription = lockedDescription;
            this.DisplayProperties = displayProperties;
            this.Buckets = buckets;
            this.FlyoutId = flyoutId;
            this.SuppressNewness = suppressNewness;
            this.EquipmentSlotHash = equipmentSlotHash;
        }

        /// <summary>
        /// If the flyout is locked, this is the reason why.
        /// </summary>
        /// <value>If the flyout is locked, this is the reason why.</value>
        [DataMember(Name = "lockedDescription", EmitDefaultValue = false)]
        public string LockedDescription { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// A list of inventory buckets and other metadata to show on the screen.
        /// </summary>
        /// <value>A list of inventory buckets and other metadata to show on the screen.</value>
        [DataMember(Name = "buckets", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition> Buckets { get; set; }

        /// <summary>
        /// An identifier for the flyout, in case anything else needs to refer to them.
        /// </summary>
        /// <value>An identifier for the flyout, in case anything else needs to refer to them.</value>
        [DataMember(Name = "flyoutId", EmitDefaultValue = false)]
        public int FlyoutId { get; set; }

        /// <summary>
        /// If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI.
        /// </summary>
        /// <value>If this is true, don&#39;t show any of the glistening \&quot;this is a new item\&quot; UI elements, like we show on the inventory items themselves in in-game UI.</value>
        [DataMember(Name = "suppressNewness", EmitDefaultValue = true)]
        public bool SuppressNewness { get; set; }

        /// <summary>
        /// If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show.
        /// </summary>
        /// <value>If this flyout is meant to show you the contents of the player&#39;s equipment slot, this is the slot to show.</value>
        [DataMember(Name = "equipmentSlotHash", EmitDefaultValue = true)]
        public int? EquipmentSlotHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition {\n");
            sb.Append("  LockedDescription: ").Append(LockedDescription).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
            sb.Append("  FlyoutId: ").Append(FlyoutId).Append("\n");
            sb.Append("  SuppressNewness: ").Append(SuppressNewness).Append("\n");
            sb.Append("  EquipmentSlotHash: ").Append(EquipmentSlotHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LockedDescription == input.LockedDescription ||
                    (this.LockedDescription != null &&
                    this.LockedDescription.Equals(input.LockedDescription))
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.Buckets == input.Buckets ||
                    this.Buckets != null &&
                    input.Buckets != null &&
                    this.Buckets.SequenceEqual(input.Buckets)
                ) && 
                (
                    this.FlyoutId == input.FlyoutId ||
                    this.FlyoutId.Equals(input.FlyoutId)
                ) && 
                (
                    this.SuppressNewness == input.SuppressNewness ||
                    this.SuppressNewness.Equals(input.SuppressNewness)
                ) && 
                (
                    this.EquipmentSlotHash == input.EquipmentSlotHash ||
                    (this.EquipmentSlotHash != null &&
                    this.EquipmentSlotHash.Equals(input.EquipmentSlotHash))
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
                if (this.LockedDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LockedDescription.GetHashCode();
                }
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                if (this.Buckets != null)
                {
                    hashCode = (hashCode * 59) + this.Buckets.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FlyoutId.GetHashCode();
                hashCode = (hashCode * 59) + this.SuppressNewness.GetHashCode();
                if (this.EquipmentSlotHash != null)
                {
                    hashCode = (hashCode * 59) + this.EquipmentSlotHash.GetHashCode();
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
