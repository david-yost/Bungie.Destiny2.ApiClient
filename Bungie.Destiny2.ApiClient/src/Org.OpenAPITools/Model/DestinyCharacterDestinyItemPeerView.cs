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
    /// Bare minimum summary information for an item, for the sake of 3D rendering the item.
    /// </summary>
    [DataContract(Name = "Destiny.Character.DestinyItemPeerView")]
    public partial class DestinyCharacterDestinyItemPeerView : IEquatable<DestinyCharacterDestinyItemPeerView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyCharacterDestinyItemPeerView" /> class.
        /// </summary>
        /// <param name="itemHash">The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data..</param>
        /// <param name="dyes">The list of dyes that have been applied to this item..</param>
        public DestinyCharacterDestinyItemPeerView(int itemHash = default(int), List<DestinyDyeReference> dyes = default(List<DestinyDyeReference>))
        {
            this.ItemHash = itemHash;
            this.Dyes = dyes;
        }

        /// <summary>
        /// The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.
        /// </summary>
        /// <value>The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.</value>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// The list of dyes that have been applied to this item.
        /// </summary>
        /// <value>The list of dyes that have been applied to this item.</value>
        [DataMember(Name = "dyes", EmitDefaultValue = false)]
        public List<DestinyDyeReference> Dyes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyCharacterDestinyItemPeerView {\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  Dyes: ").Append(Dyes).Append("\n");
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
            return this.Equals(input as DestinyCharacterDestinyItemPeerView);
        }

        /// <summary>
        /// Returns true if DestinyCharacterDestinyItemPeerView instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyCharacterDestinyItemPeerView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyCharacterDestinyItemPeerView input)
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
                    this.Dyes == input.Dyes ||
                    this.Dyes != null &&
                    input.Dyes != null &&
                    this.Dyes.SequenceEqual(input.Dyes)
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
                if (this.Dyes != null)
                {
                    hashCode = (hashCode * 59) + this.Dyes.GetHashCode();
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
