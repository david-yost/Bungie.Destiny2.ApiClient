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
    /// Sockets may refer to a \&quot;Plug Set\&quot;: a set of reusable plugs that may be shared across multiple sockets (or even, in theory, multiple sockets over multiple items).  This is the set of those plugs that we came across in the users&#39; inventory, along with the values for plugs in the set. Any given set in this component may be represented in Character and Profile-level, as some plugs may be Profile-level restricted, and some character-level restricted. (note that the ones that are even more specific will remain on the actual socket component itself, as they cannot be reused)
    /// </summary>
    [DataContract(Name = "Destiny.Components.PlugSets.DestinyPlugSetsComponent")]
    public partial class DestinyComponentsPlugSetsDestinyPlugSetsComponent : IEquatable<DestinyComponentsPlugSetsDestinyPlugSetsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsPlugSetsDestinyPlugSetsComponent" /> class.
        /// </summary>
        /// <param name="plugs">The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition)..</param>
        public DestinyComponentsPlugSetsDestinyPlugSetsComponent(Dictionary<string, List<DestinySocketsDestinyItemPlug>> plugs = default(Dictionary<string, List<DestinySocketsDestinyItemPlug>>))
        {
            this.Plugs = plugs;
        }

        /// <summary>
        /// The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition).
        /// </summary>
        /// <value>The shared list of plugs for each relevant PlugSet, keyed by the hash identifier of the PlugSet (DestinyPlugSetDefinition).</value>
        [DataMember(Name = "plugs", EmitDefaultValue = false)]
        public Dictionary<string, List<DestinySocketsDestinyItemPlug>> Plugs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsPlugSetsDestinyPlugSetsComponent {\n");
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
            return this.Equals(input as DestinyComponentsPlugSetsDestinyPlugSetsComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsPlugSetsDestinyPlugSetsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsPlugSetsDestinyPlugSetsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsPlugSetsDestinyPlugSetsComponent input)
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
