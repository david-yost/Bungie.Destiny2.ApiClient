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
    /// DestinyHistoricalStatsDestinyHistoricalWeaponStatsData
    /// </summary>
    [DataContract(Name = "Destiny.HistoricalStats.DestinyHistoricalWeaponStatsData")]
    public partial class DestinyHistoricalStatsDestinyHistoricalWeaponStatsData : IEquatable<DestinyHistoricalStatsDestinyHistoricalWeaponStatsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyHistoricalWeaponStatsData" /> class.
        /// </summary>
        /// <param name="weapons">List of weapons and their perspective values..</param>
        public DestinyHistoricalStatsDestinyHistoricalWeaponStatsData(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> weapons = default(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats>))
        {
            this.Weapons = weapons;
        }

        /// <summary>
        /// List of weapons and their perspective values.
        /// </summary>
        /// <value>List of weapons and their perspective values.</value>
        [DataMember(Name = "weapons", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyHistoricalWeaponStatsData {\n");
            sb.Append("  Weapons: ").Append(Weapons).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyHistoricalWeaponStatsData);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyHistoricalWeaponStatsData instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyHistoricalWeaponStatsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyHistoricalWeaponStatsData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Weapons == input.Weapons ||
                    this.Weapons != null &&
                    input.Weapons != null &&
                    this.Weapons.SequenceEqual(input.Weapons)
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
                if (this.Weapons != null)
                {
                    hashCode = (hashCode * 59) + this.Weapons.GetHashCode();
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