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
    /// DestinyEntitiesItemsDestinyItemInstanceEnergy
    /// </summary>
    [DataContract(Name = "Destiny.Entities.Items.DestinyItemInstanceEnergy")]
    public partial class DestinyEntitiesItemsDestinyItemInstanceEnergy : IEquatable<DestinyEntitiesItemsDestinyItemInstanceEnergy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemInstanceEnergy" /> class.
        /// </summary>
        /// <param name="energyTypeHash">The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it..</param>
        /// <param name="energyType">This is the enum version of the Energy Type value, for convenience..</param>
        /// <param name="energyCapacity">The total capacity of Energy that the item currently has, regardless of if it is currently being used..</param>
        /// <param name="energyUsed">The amount of Energy currently in use by inserted plugs..</param>
        /// <param name="energyUnused">The amount of energy still available for inserting new plugs..</param>
        public DestinyEntitiesItemsDestinyItemInstanceEnergy(int energyTypeHash = default(int), int energyType = default(int), int energyCapacity = default(int), int energyUsed = default(int), int energyUnused = default(int))
        {
            this.EnergyTypeHash = energyTypeHash;
            this.EnergyType = energyType;
            this.EnergyCapacity = energyCapacity;
            this.EnergyUsed = energyUsed;
            this.EnergyUnused = energyUnused;
        }

        /// <summary>
        /// The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.
        /// </summary>
        /// <value>The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.</value>
        [DataMember(Name = "energyTypeHash", EmitDefaultValue = false)]
        public int EnergyTypeHash { get; set; }

        /// <summary>
        /// This is the enum version of the Energy Type value, for convenience.
        /// </summary>
        /// <value>This is the enum version of the Energy Type value, for convenience.</value>
        [DataMember(Name = "energyType", EmitDefaultValue = false)]
        public int EnergyType { get; set; }

        /// <summary>
        /// The total capacity of Energy that the item currently has, regardless of if it is currently being used.
        /// </summary>
        /// <value>The total capacity of Energy that the item currently has, regardless of if it is currently being used.</value>
        [DataMember(Name = "energyCapacity", EmitDefaultValue = false)]
        public int EnergyCapacity { get; set; }

        /// <summary>
        /// The amount of Energy currently in use by inserted plugs.
        /// </summary>
        /// <value>The amount of Energy currently in use by inserted plugs.</value>
        [DataMember(Name = "energyUsed", EmitDefaultValue = false)]
        public int EnergyUsed { get; set; }

        /// <summary>
        /// The amount of energy still available for inserting new plugs.
        /// </summary>
        /// <value>The amount of energy still available for inserting new plugs.</value>
        [DataMember(Name = "energyUnused", EmitDefaultValue = false)]
        public int EnergyUnused { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyEntitiesItemsDestinyItemInstanceEnergy {\n");
            sb.Append("  EnergyTypeHash: ").Append(EnergyTypeHash).Append("\n");
            sb.Append("  EnergyType: ").Append(EnergyType).Append("\n");
            sb.Append("  EnergyCapacity: ").Append(EnergyCapacity).Append("\n");
            sb.Append("  EnergyUsed: ").Append(EnergyUsed).Append("\n");
            sb.Append("  EnergyUnused: ").Append(EnergyUnused).Append("\n");
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemInstanceEnergy);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemInstanceEnergy instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemInstanceEnergy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemInstanceEnergy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnergyTypeHash == input.EnergyTypeHash ||
                    this.EnergyTypeHash.Equals(input.EnergyTypeHash)
                ) && 
                (
                    this.EnergyType == input.EnergyType ||
                    this.EnergyType.Equals(input.EnergyType)
                ) && 
                (
                    this.EnergyCapacity == input.EnergyCapacity ||
                    this.EnergyCapacity.Equals(input.EnergyCapacity)
                ) && 
                (
                    this.EnergyUsed == input.EnergyUsed ||
                    this.EnergyUsed.Equals(input.EnergyUsed)
                ) && 
                (
                    this.EnergyUnused == input.EnergyUnused ||
                    this.EnergyUnused.Equals(input.EnergyUnused)
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
                hashCode = (hashCode * 59) + this.EnergyTypeHash.GetHashCode();
                hashCode = (hashCode * 59) + this.EnergyType.GetHashCode();
                hashCode = (hashCode * 59) + this.EnergyCapacity.GetHashCode();
                hashCode = (hashCode * 59) + this.EnergyUsed.GetHashCode();
                hashCode = (hashCode * 59) + this.EnergyUnused.GetHashCode();
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
