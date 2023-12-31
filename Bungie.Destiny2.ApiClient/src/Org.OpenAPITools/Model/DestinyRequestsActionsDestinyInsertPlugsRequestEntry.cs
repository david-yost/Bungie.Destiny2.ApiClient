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
    /// Represents all of the data related to a single plug to be inserted.  Note that, while you *can* point to a socket that represents infusion, you will receive an error if you attempt to do so. Come on guys, let&#39;s play nice.
    /// </summary>
    [DataContract(Name = "Destiny.Requests.Actions.DestinyInsertPlugsRequestEntry")]
    public partial class DestinyRequestsActionsDestinyInsertPlugsRequestEntry : IEquatable<DestinyRequestsActionsDestinyInsertPlugsRequestEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyRequestsActionsDestinyInsertPlugsRequestEntry" /> class.
        /// </summary>
        /// <param name="socketIndex">The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don&#39;t point to or try to insert a plug into an infusion socket. It won&#39;t work..</param>
        /// <param name="socketArrayType">This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \&quot;default\&quot; sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don&#39;t give me that look..</param>
        /// <param name="plugItemHash">Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it&#39;s a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets..</param>
        public DestinyRequestsActionsDestinyInsertPlugsRequestEntry(int socketIndex = default(int), int socketArrayType = default(int), int plugItemHash = default(int))
        {
            this.SocketIndex = socketIndex;
            this.SocketArrayType = socketArrayType;
            this.PlugItemHash = plugItemHash;
        }

        /// <summary>
        /// The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don&#39;t point to or try to insert a plug into an infusion socket. It won&#39;t work.
        /// </summary>
        /// <value>The index into the socket array, which identifies the specific socket being operated on. We also need to know the socketArrayType in order to uniquely identify the socket.  Don&#39;t point to or try to insert a plug into an infusion socket. It won&#39;t work.</value>
        [DataMember(Name = "socketIndex", EmitDefaultValue = false)]
        public int SocketIndex { get; set; }

        /// <summary>
        /// This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \&quot;default\&quot; sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don&#39;t give me that look.
        /// </summary>
        /// <value>This property, combined with the socketIndex, tells us which socket we are referring to (since operations can be performed on both Intrinsic and \&quot;default\&quot; sockets, and they occupy different arrays in the Inventory Item Definition). I know, I know. Don&#39;t give me that look.</value>
        [DataMember(Name = "socketArrayType", EmitDefaultValue = false)]
        public int SocketArrayType { get; set; }

        /// <summary>
        /// Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it&#39;s a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.
        /// </summary>
        /// <value>Plugs are never instanced (except in infusion). So with the hash alone, we should be able to: 1) Infer whether the player actually needs to have the item, or if it&#39;s a reusable plug 2) Perform any operation needed to use the Plug, including removing the plug item and running reward sheets.</value>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public int PlugItemHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyRequestsActionsDestinyInsertPlugsRequestEntry {\n");
            sb.Append("  SocketIndex: ").Append(SocketIndex).Append("\n");
            sb.Append("  SocketArrayType: ").Append(SocketArrayType).Append("\n");
            sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
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
            return this.Equals(input as DestinyRequestsActionsDestinyInsertPlugsRequestEntry);
        }

        /// <summary>
        /// Returns true if DestinyRequestsActionsDestinyInsertPlugsRequestEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyRequestsActionsDestinyInsertPlugsRequestEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyRequestsActionsDestinyInsertPlugsRequestEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SocketIndex == input.SocketIndex ||
                    this.SocketIndex.Equals(input.SocketIndex)
                ) && 
                (
                    this.SocketArrayType == input.SocketArrayType ||
                    this.SocketArrayType.Equals(input.SocketArrayType)
                ) && 
                (
                    this.PlugItemHash == input.PlugItemHash ||
                    this.PlugItemHash.Equals(input.PlugItemHash)
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
                hashCode = (hashCode * 59) + this.SocketIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.SocketArrayType.GetHashCode();
                hashCode = (hashCode * 59) + this.PlugItemHash.GetHashCode();
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
