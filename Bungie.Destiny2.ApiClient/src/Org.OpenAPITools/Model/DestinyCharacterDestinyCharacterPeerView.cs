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
    /// A minimal view of a character&#39;s equipped items, for the purpose of rendering a summary screen or showing the character in 3D.
    /// </summary>
    [DataContract(Name = "Destiny.Character.DestinyCharacterPeerView")]
    public partial class DestinyCharacterDestinyCharacterPeerView : IEquatable<DestinyCharacterDestinyCharacterPeerView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyCharacterDestinyCharacterPeerView" /> class.
        /// </summary>
        /// <param name="equipment">equipment.</param>
        public DestinyCharacterDestinyCharacterPeerView(List<DestinyCharacterDestinyItemPeerView> equipment = default(List<DestinyCharacterDestinyItemPeerView>))
        {
            this.Equipment = equipment;
        }

        /// <summary>
        /// Gets or Sets Equipment
        /// </summary>
        [DataMember(Name = "equipment", EmitDefaultValue = false)]
        public List<DestinyCharacterDestinyItemPeerView> Equipment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyCharacterDestinyCharacterPeerView {\n");
            sb.Append("  Equipment: ").Append(Equipment).Append("\n");
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
            return this.Equals(input as DestinyCharacterDestinyCharacterPeerView);
        }

        /// <summary>
        /// Returns true if DestinyCharacterDestinyCharacterPeerView instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyCharacterDestinyCharacterPeerView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyCharacterDestinyCharacterPeerView input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Equipment == input.Equipment ||
                    this.Equipment != null &&
                    input.Equipment != null &&
                    this.Equipment.SequenceEqual(input.Equipment)
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
                if (this.Equipment != null)
                {
                    hashCode = (hashCode * 59) + this.Equipment.GetHashCode();
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
