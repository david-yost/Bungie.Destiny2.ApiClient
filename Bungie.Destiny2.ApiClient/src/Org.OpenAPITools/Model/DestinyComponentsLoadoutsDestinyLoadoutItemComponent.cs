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
    /// DestinyComponentsLoadoutsDestinyLoadoutItemComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Loadouts.DestinyLoadoutItemComponent")]
    public partial class DestinyComponentsLoadoutsDestinyLoadoutItemComponent : IEquatable<DestinyComponentsLoadoutsDestinyLoadoutItemComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsLoadoutsDestinyLoadoutItemComponent" /> class.
        /// </summary>
        /// <param name="itemInstanceId">itemInstanceId.</param>
        /// <param name="plugItemHashes">plugItemHashes.</param>
        public DestinyComponentsLoadoutsDestinyLoadoutItemComponent(long itemInstanceId = default(long), List<int> plugItemHashes = default(List<int>))
        {
            this.ItemInstanceId = itemInstanceId;
            this.PlugItemHashes = plugItemHashes;
        }

        /// <summary>
        /// Gets or Sets ItemInstanceId
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets PlugItemHashes
        /// </summary>
        [DataMember(Name = "plugItemHashes", EmitDefaultValue = false)]
        public List<int> PlugItemHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsLoadoutsDestinyLoadoutItemComponent {\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  PlugItemHashes: ").Append(PlugItemHashes).Append("\n");
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
            return this.Equals(input as DestinyComponentsLoadoutsDestinyLoadoutItemComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsLoadoutsDestinyLoadoutItemComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsLoadoutsDestinyLoadoutItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsLoadoutsDestinyLoadoutItemComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    this.ItemInstanceId.Equals(input.ItemInstanceId)
                ) && 
                (
                    this.PlugItemHashes == input.PlugItemHashes ||
                    this.PlugItemHashes != null &&
                    input.PlugItemHashes != null &&
                    this.PlugItemHashes.SequenceEqual(input.PlugItemHashes)
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
                hashCode = (hashCode * 59) + this.ItemInstanceId.GetHashCode();
                if (this.PlugItemHashes != null)
                {
                    hashCode = (hashCode * 59) + this.PlugItemHashes.GetHashCode();
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
