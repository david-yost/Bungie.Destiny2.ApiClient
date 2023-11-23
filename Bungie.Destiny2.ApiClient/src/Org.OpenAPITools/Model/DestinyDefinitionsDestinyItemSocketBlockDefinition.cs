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
    /// If defined, the item has at least one socket.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyItemSocketBlockDefinition")]
    public partial class DestinyDefinitionsDestinyItemSocketBlockDefinition : IEquatable<DestinyDefinitionsDestinyItemSocketBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSocketBlockDefinition" /> class.
        /// </summary>
        /// <param name="detail">This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \&quot;details\&quot;. ... that&#39;s lame, but perhaps it will become something cool in the future..</param>
        /// <param name="socketEntries">Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info..</param>
        /// <param name="intrinsicSockets">Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket..</param>
        /// <param name="socketCategories">A convenience property, that refers to the sockets in the \&quot;sockets\&quot; property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man..</param>
        public DestinyDefinitionsDestinyItemSocketBlockDefinition(string detail = default(string), List<DestinyDefinitionsDestinyItemSocketEntryDefinition> socketEntries = default(List<DestinyDefinitionsDestinyItemSocketEntryDefinition>), List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> intrinsicSockets = default(List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition>), List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> socketCategories = default(List<DestinyDefinitionsDestinyItemSocketCategoryDefinition>))
        {
            this.Detail = detail;
            this.SocketEntries = socketEntries;
            this.IntrinsicSockets = intrinsicSockets;
            this.SocketCategories = socketCategories;
        }

        /// <summary>
        /// This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \&quot;details\&quot;. ... that&#39;s lame, but perhaps it will become something cool in the future.
        /// </summary>
        /// <value>This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \&quot;details\&quot;. ... that&#39;s lame, but perhaps it will become something cool in the future.</value>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.
        /// </summary>
        /// <value>Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.</value>
        [DataMember(Name = "socketEntries", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyItemSocketEntryDefinition> SocketEntries { get; set; }

        /// <summary>
        /// Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.
        /// </summary>
        /// <value>Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.</value>
        [DataMember(Name = "intrinsicSockets", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> IntrinsicSockets { get; set; }

        /// <summary>
        /// A convenience property, that refers to the sockets in the \&quot;sockets\&quot; property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.
        /// </summary>
        /// <value>A convenience property, that refers to the sockets in the \&quot;sockets\&quot; property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.</value>
        [DataMember(Name = "socketCategories", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> SocketCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSocketBlockDefinition {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  SocketEntries: ").Append(SocketEntries).Append("\n");
            sb.Append("  IntrinsicSockets: ").Append(IntrinsicSockets).Append("\n");
            sb.Append("  SocketCategories: ").Append(SocketCategories).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSocketBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSocketBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSocketBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSocketBlockDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.SocketEntries == input.SocketEntries ||
                    this.SocketEntries != null &&
                    input.SocketEntries != null &&
                    this.SocketEntries.SequenceEqual(input.SocketEntries)
                ) && 
                (
                    this.IntrinsicSockets == input.IntrinsicSockets ||
                    this.IntrinsicSockets != null &&
                    input.IntrinsicSockets != null &&
                    this.IntrinsicSockets.SequenceEqual(input.IntrinsicSockets)
                ) && 
                (
                    this.SocketCategories == input.SocketCategories ||
                    this.SocketCategories != null &&
                    input.SocketCategories != null &&
                    this.SocketCategories.SequenceEqual(input.SocketCategories)
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
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
                if (this.SocketEntries != null)
                {
                    hashCode = (hashCode * 59) + this.SocketEntries.GetHashCode();
                }
                if (this.IntrinsicSockets != null)
                {
                    hashCode = (hashCode * 59) + this.IntrinsicSockets.GetHashCode();
                }
                if (this.SocketCategories != null)
                {
                    hashCode = (hashCode * 59) + this.SocketCategories.GetHashCode();
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
