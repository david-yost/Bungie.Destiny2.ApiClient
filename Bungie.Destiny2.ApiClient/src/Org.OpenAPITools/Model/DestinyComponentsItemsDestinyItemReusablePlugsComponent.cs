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
    /// DestinyComponentsItemsDestinyItemReusablePlugsComponent
    /// </summary>
    [DataContract(Name = "Destiny.Components.Items.DestinyItemReusablePlugsComponent")]
    public partial class DestinyComponentsItemsDestinyItemReusablePlugsComponent : IEquatable<DestinyComponentsItemsDestinyItemReusablePlugsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsItemsDestinyItemReusablePlugsComponent" /> class.
        /// </summary>
        /// <param name="plugs">If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \&quot;enabled\&quot;, whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn&#39;t been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY &#x3D; The INDEX into the item&#39;s list of sockets. VALUE &#x3D; The set of plugs for that socket.   If a socket doesn&#39;t have any reusable plugs defined at the item scope, there will be no entry for that socket..</param>
        public DestinyComponentsItemsDestinyItemReusablePlugsComponent(Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> plugs = default(Dictionary<string, List<DestinySocketsDestinyItemPlugBase>>))
        {
            this.Plugs = plugs;
        }

        /// <summary>
        /// If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \&quot;enabled\&quot;, whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn&#39;t been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY &#x3D; The INDEX into the item&#39;s list of sockets. VALUE &#x3D; The set of plugs for that socket.   If a socket doesn&#39;t have any reusable plugs defined at the item scope, there will be no entry for that socket.
        /// </summary>
        /// <value>If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are \&quot;enabled\&quot;, whether they are allowed to be inserted, and any other information such as objectives.   A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn&#39;t been completed yet.   In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.   KEY &#x3D; The INDEX into the item&#39;s list of sockets. VALUE &#x3D; The set of plugs for that socket.   If a socket doesn&#39;t have any reusable plugs defined at the item scope, there will be no entry for that socket.</value>
        [DataMember(Name = "plugs", EmitDefaultValue = false)]
        public Dictionary<string, List<DestinySocketsDestinyItemPlugBase>> Plugs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsItemsDestinyItemReusablePlugsComponent {\n");
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
            return this.Equals(input as DestinyComponentsItemsDestinyItemReusablePlugsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsItemsDestinyItemReusablePlugsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsItemsDestinyItemReusablePlugsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsItemsDestinyItemReusablePlugsComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
