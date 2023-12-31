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
    /// The information for how the vendor purchase should override a given socket with custom plug data.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyVendorItemSocketOverride")]
    public partial class DestinyDefinitionsDestinyVendorItemSocketOverride : IEquatable<DestinyDefinitionsDestinyVendorItemSocketOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorItemSocketOverride" /> class.
        /// </summary>
        /// <param name="singleItemHash">If this is populated, the socket will be overridden with a specific plug.  If this isn&#39;t populated, it&#39;s being overridden by something more complicated that is only known by the Game Server and God, which means we can&#39;t tell you in advance what it&#39;ll be..</param>
        /// <param name="randomizedOptionsCount">If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it&#39;s set to by default..</param>
        /// <param name="socketTypeHash">This appears to be used to select which socket ultimately gets the override defined here..</param>
        public DestinyDefinitionsDestinyVendorItemSocketOverride(int? singleItemHash = default(int?), int randomizedOptionsCount = default(int), int socketTypeHash = default(int))
        {
            this.SingleItemHash = singleItemHash;
            this.RandomizedOptionsCount = randomizedOptionsCount;
            this.SocketTypeHash = socketTypeHash;
        }

        /// <summary>
        /// If this is populated, the socket will be overridden with a specific plug.  If this isn&#39;t populated, it&#39;s being overridden by something more complicated that is only known by the Game Server and God, which means we can&#39;t tell you in advance what it&#39;ll be.
        /// </summary>
        /// <value>If this is populated, the socket will be overridden with a specific plug.  If this isn&#39;t populated, it&#39;s being overridden by something more complicated that is only known by the Game Server and God, which means we can&#39;t tell you in advance what it&#39;ll be.</value>
        [DataMember(Name = "singleItemHash", EmitDefaultValue = true)]
        public int? SingleItemHash { get; set; }

        /// <summary>
        /// If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it&#39;s set to by default.
        /// </summary>
        /// <value>If this is greater than -1, the number of randomized plugs on this socket will be set to this quantity instead of whatever it&#39;s set to by default.</value>
        [DataMember(Name = "randomizedOptionsCount", EmitDefaultValue = false)]
        public int RandomizedOptionsCount { get; set; }

        /// <summary>
        /// This appears to be used to select which socket ultimately gets the override defined here.
        /// </summary>
        /// <value>This appears to be used to select which socket ultimately gets the override defined here.</value>
        [DataMember(Name = "socketTypeHash", EmitDefaultValue = false)]
        public int SocketTypeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyVendorItemSocketOverride {\n");
            sb.Append("  SingleItemHash: ").Append(SingleItemHash).Append("\n");
            sb.Append("  RandomizedOptionsCount: ").Append(RandomizedOptionsCount).Append("\n");
            sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorItemSocketOverride);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorItemSocketOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorItemSocketOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorItemSocketOverride input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SingleItemHash == input.SingleItemHash ||
                    (this.SingleItemHash != null &&
                    this.SingleItemHash.Equals(input.SingleItemHash))
                ) && 
                (
                    this.RandomizedOptionsCount == input.RandomizedOptionsCount ||
                    this.RandomizedOptionsCount.Equals(input.RandomizedOptionsCount)
                ) && 
                (
                    this.SocketTypeHash == input.SocketTypeHash ||
                    this.SocketTypeHash.Equals(input.SocketTypeHash)
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
                if (this.SingleItemHash != null)
                {
                    hashCode = (hashCode * 59) + this.SingleItemHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RandomizedOptionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.SocketTypeHash.GetHashCode();
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
