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
    /// Plugs are non-instanced items that can provide Stat and Perk benefits when socketed into an instanced item. Items have Sockets, and Plugs are inserted into Sockets.  This component finds all items that are considered \&quot;Plugs\&quot; in your inventory, and return information about the plug aside from any specific Socket into which it could be inserted.
    /// </summary>
    [DataContract(Name = "Destiny.Components.Items.DestinyItemPlugComponent")]
    public partial class DestinyComponentsItemsDestinyItemPlugComponent : IEquatable<DestinyComponentsItemsDestinyItemPlugComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsItemsDestinyItemPlugComponent" /> class.
        /// </summary>
        /// <param name="plugObjectives">Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \&quot;gating\&quot; for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data..</param>
        /// <param name="plugItemHash">The hash identifier of the DestinyInventoryItemDefinition that represents this plug..</param>
        /// <param name="canInsert">If true, this plug has met all of its insertion requirements. Big if true..</param>
        /// <param name="enabled">If true, this plug will provide its benefits while inserted..</param>
        /// <param name="insertFailIndexes">If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted..</param>
        /// <param name="enableFailIndexes">If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled..</param>
        public DestinyComponentsItemsDestinyItemPlugComponent(List<DestinyQuestsDestinyObjectiveProgress> plugObjectives = default(List<DestinyQuestsDestinyObjectiveProgress>), int plugItemHash = default(int), bool canInsert = default(bool), bool enabled = default(bool), List<int> insertFailIndexes = default(List<int>), List<int> enableFailIndexes = default(List<int>))
        {
            this.PlugObjectives = plugObjectives;
            this.PlugItemHash = plugItemHash;
            this.CanInsert = canInsert;
            this.Enabled = enabled;
            this.InsertFailIndexes = insertFailIndexes;
            this.EnableFailIndexes = enableFailIndexes;
        }

        /// <summary>
        /// Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \&quot;gating\&quot; for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.
        /// </summary>
        /// <value>Sometimes, Plugs may have objectives: these are often used for flavor and display purposes, but they can be used for any arbitrary purpose (both fortunately and unfortunately). Recently (with Season 2) they were expanded in use to be used as the \&quot;gating\&quot; for whether the plug can be inserted at all. For instance, a Plug might be tracking the number of PVP kills you have made. It will use the parent item&#39;s data about that tracking status to determine what to show, and will generally show it using the DestinyObjectiveDefinition&#39;s progressDescription property. Refer to the plug&#39;s itemHash and objective property for more information if you would like to display even more data.</value>
        [DataMember(Name = "plugObjectives", EmitDefaultValue = false)]
        public List<DestinyQuestsDestinyObjectiveProgress> PlugObjectives { get; set; }

        /// <summary>
        /// The hash identifier of the DestinyInventoryItemDefinition that represents this plug.
        /// </summary>
        /// <value>The hash identifier of the DestinyInventoryItemDefinition that represents this plug.</value>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public int PlugItemHash { get; set; }

        /// <summary>
        /// If true, this plug has met all of its insertion requirements. Big if true.
        /// </summary>
        /// <value>If true, this plug has met all of its insertion requirements. Big if true.</value>
        [DataMember(Name = "canInsert", EmitDefaultValue = true)]
        public bool CanInsert { get; set; }

        /// <summary>
        /// If true, this plug will provide its benefits while inserted.
        /// </summary>
        /// <value>If true, this plug will provide its benefits while inserted.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted.
        /// </summary>
        /// <value>If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted.</value>
        [DataMember(Name = "insertFailIndexes", EmitDefaultValue = false)]
        public List<int> InsertFailIndexes { get; set; }

        /// <summary>
        /// If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.
        /// </summary>
        /// <value>If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled.</value>
        [DataMember(Name = "enableFailIndexes", EmitDefaultValue = false)]
        public List<int> EnableFailIndexes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyComponentsItemsDestinyItemPlugComponent {\n");
            sb.Append("  PlugObjectives: ").Append(PlugObjectives).Append("\n");
            sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
            sb.Append("  CanInsert: ").Append(CanInsert).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  InsertFailIndexes: ").Append(InsertFailIndexes).Append("\n");
            sb.Append("  EnableFailIndexes: ").Append(EnableFailIndexes).Append("\n");
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
            return this.Equals(input as DestinyComponentsItemsDestinyItemPlugComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsItemsDestinyItemPlugComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsItemsDestinyItemPlugComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsItemsDestinyItemPlugComponent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlugObjectives == input.PlugObjectives ||
                    this.PlugObjectives != null &&
                    input.PlugObjectives != null &&
                    this.PlugObjectives.SequenceEqual(input.PlugObjectives)
                ) && 
                (
                    this.PlugItemHash == input.PlugItemHash ||
                    this.PlugItemHash.Equals(input.PlugItemHash)
                ) && 
                (
                    this.CanInsert == input.CanInsert ||
                    this.CanInsert.Equals(input.CanInsert)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.InsertFailIndexes == input.InsertFailIndexes ||
                    this.InsertFailIndexes != null &&
                    input.InsertFailIndexes != null &&
                    this.InsertFailIndexes.SequenceEqual(input.InsertFailIndexes)
                ) && 
                (
                    this.EnableFailIndexes == input.EnableFailIndexes ||
                    this.EnableFailIndexes != null &&
                    input.EnableFailIndexes != null &&
                    this.EnableFailIndexes.SequenceEqual(input.EnableFailIndexes)
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
                if (this.PlugObjectives != null)
                {
                    hashCode = (hashCode * 59) + this.PlugObjectives.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlugItemHash.GetHashCode();
                hashCode = (hashCode * 59) + this.CanInsert.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.InsertFailIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.InsertFailIndexes.GetHashCode();
                }
                if (this.EnableFailIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.EnableFailIndexes.GetHashCode();
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
