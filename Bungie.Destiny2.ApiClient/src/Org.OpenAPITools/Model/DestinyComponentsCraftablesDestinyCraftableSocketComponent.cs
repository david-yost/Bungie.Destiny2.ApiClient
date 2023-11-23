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
    /// DestinyComponentsCraftablesDestinyCraftableSocketComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Craftables.DestinyCraftableSocketComponent")]
    public partial class DestinyComponentsCraftablesDestinyCraftableSocketComponent : IEquatable<DestinyComponentsCraftablesDestinyCraftableSocketComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsCraftablesDestinyCraftableSocketComponent" /> class.
        /// </summary>
        /// <param name="plugSetHash">plugSetHash.</param>
        /// <param name="plugs">Unlock state for plugs in the socket plug set definition.</param>
        public DestinyComponentsCraftablesDestinyCraftableSocketComponent(int plugSetHash = default(int), List<DestinyComponentsCraftablesDestinyCraftableSocketPlugComponent> plugs = default(List<DestinyComponentsCraftablesDestinyCraftableSocketPlugComponent>))
        {
            this.PlugSetHash = plugSetHash;
            this.Plugs = plugs;
        }

        /// <summary>
        /// Gets or Sets PlugSetHash
        /// </summary>
        [DataMember(Name = "plugSetHash", EmitDefaultValue = false)]
        public int PlugSetHash { get; set; }

        /// <summary>
        /// Unlock state for plugs in the socket plug set definition
        /// </summary>
        /// <value>Unlock state for plugs in the socket plug set definition</value>
        [DataMember(Name = "plugs", EmitDefaultValue = false)]
        public List<DestinyComponentsCraftablesDestinyCraftableSocketPlugComponent> Plugs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsCraftablesDestinyCraftableSocketComponent {\n");
            sb.Append("  PlugSetHash: ").Append(PlugSetHash).Append("\n");
            sb.Append("  Plugs: ").Append(Plugs).Append("\n");
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
            return this.Equals(input as DestinyComponentsCraftablesDestinyCraftableSocketComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsCraftablesDestinyCraftableSocketComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsCraftablesDestinyCraftableSocketComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsCraftablesDestinyCraftableSocketComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlugSetHash == input.PlugSetHash ||
                    this.PlugSetHash.Equals(input.PlugSetHash)
                ) && 
                (
                    this.Plugs == input.Plugs ||
                    this.Plugs != null &&
                    input.Plugs != null &&
                    this.Plugs.SequenceEqual(input.Plugs)
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
                hashCode = (hashCode * 59) + this.PlugSetHash.GetHashCode();
                if (this.Plugs != null)
                {
                    hashCode = (hashCode * 59) + this.Plugs.GetHashCode();
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
