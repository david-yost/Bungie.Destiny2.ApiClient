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
    /// DestinyDefinitionsDestinyActivityLoadoutRequirement
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyActivityLoadoutRequirement")]
    public partial class DestinyDefinitionsDestinyActivityLoadoutRequirement : IEquatable<DestinyDefinitionsDestinyActivityLoadoutRequirement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityLoadoutRequirement" /> class.
        /// </summary>
        /// <param name="equipmentSlotHash">equipmentSlotHash.</param>
        /// <param name="allowedEquippedItemHashes">allowedEquippedItemHashes.</param>
        /// <param name="allowedWeaponSubTypes">allowedWeaponSubTypes.</param>
        public DestinyDefinitionsDestinyActivityLoadoutRequirement(int equipmentSlotHash = default(int), List<int> allowedEquippedItemHashes = default(List<int>), List<int> allowedWeaponSubTypes = default(List<int>))
        {
            this.EquipmentSlotHash = equipmentSlotHash;
            this.AllowedEquippedItemHashes = allowedEquippedItemHashes;
            this.AllowedWeaponSubTypes = allowedWeaponSubTypes;
        }

        /// <summary>
        /// Gets or Sets EquipmentSlotHash
        /// </summary>
        [DataMember(Name = "equipmentSlotHash", EmitDefaultValue = false)]
        public int EquipmentSlotHash { get; set; }

        /// <summary>
        /// Gets or Sets AllowedEquippedItemHashes
        /// </summary>
        [DataMember(Name = "allowedEquippedItemHashes", EmitDefaultValue = false)]
        public List<int> AllowedEquippedItemHashes { get; set; }

        /// <summary>
        /// Gets or Sets AllowedWeaponSubTypes
        /// </summary>
        [DataMember(Name = "allowedWeaponSubTypes", EmitDefaultValue = false)]
        public List<int> AllowedWeaponSubTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityLoadoutRequirement {\n");
            sb.Append("  EquipmentSlotHash: ").Append(EquipmentSlotHash).Append("\n");
            sb.Append("  AllowedEquippedItemHashes: ").Append(AllowedEquippedItemHashes).Append("\n");
            sb.Append("  AllowedWeaponSubTypes: ").Append(AllowedWeaponSubTypes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityLoadoutRequirement);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityLoadoutRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityLoadoutRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityLoadoutRequirement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EquipmentSlotHash == input.EquipmentSlotHash ||
                    this.EquipmentSlotHash.Equals(input.EquipmentSlotHash)
                ) && 
                (
                    this.AllowedEquippedItemHashes == input.AllowedEquippedItemHashes ||
                    this.AllowedEquippedItemHashes != null &&
                    input.AllowedEquippedItemHashes != null &&
                    this.AllowedEquippedItemHashes.SequenceEqual(input.AllowedEquippedItemHashes)
                ) && 
                (
                    this.AllowedWeaponSubTypes == input.AllowedWeaponSubTypes ||
                    this.AllowedWeaponSubTypes != null &&
                    input.AllowedWeaponSubTypes != null &&
                    this.AllowedWeaponSubTypes.SequenceEqual(input.AllowedWeaponSubTypes)
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
                hashCode = (hashCode * 59) + this.EquipmentSlotHash.GetHashCode();
                if (this.AllowedEquippedItemHashes != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedEquippedItemHashes.GetHashCode();
                }
                if (this.AllowedWeaponSubTypes != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedWeaponSubTypes.GetHashCode();
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
