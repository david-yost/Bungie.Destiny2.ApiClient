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
    /// Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI. The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyDisplayCategoryDefinition")]
    public partial class DestinyDefinitionsDestinyDisplayCategoryDefinition : IEquatable<DestinyDefinitionsDestinyDisplayCategoryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyDisplayCategoryDefinition" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="identifier">A string identifier for the display category..</param>
        /// <param name="displayCategoryHash">displayCategoryHash.</param>
        /// <param name="displayProperties">displayProperties.</param>
        /// <param name="displayInBanner">If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI..</param>
        /// <param name="progressionHash">If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool..</param>
        /// <param name="sortOrder">If this category sorts items in a nonstandard way, this will be the way we sort..</param>
        /// <param name="displayStyleHash">An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category..</param>
        /// <param name="displayStyleIdentifier">An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category..</param>
        public DestinyDefinitionsDestinyDisplayCategoryDefinition(int index = default(int), string identifier = default(string), int displayCategoryHash = default(int), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), bool displayInBanner = default(bool), int? progressionHash = default(int?), int sortOrder = default(int), int? displayStyleHash = default(int?), string displayStyleIdentifier = default(string))
        {
            this.Index = index;
            this.Identifier = identifier;
            this.DisplayCategoryHash = displayCategoryHash;
            this.DisplayProperties = displayProperties;
            this.DisplayInBanner = displayInBanner;
            this.ProgressionHash = progressionHash;
            this.SortOrder = sortOrder;
            this.DisplayStyleHash = displayStyleHash;
            this.DisplayStyleIdentifier = displayStyleIdentifier;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// A string identifier for the display category.
        /// </summary>
        /// <value>A string identifier for the display category.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets DisplayCategoryHash
        /// </summary>
        [DataMember(Name = "displayCategoryHash", EmitDefaultValue = false)]
        public int DisplayCategoryHash { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI.
        /// </summary>
        /// <value>If true, this category should be displayed in the \&quot;Banner\&quot; section of the vendor&#39;s UI.</value>
        [DataMember(Name = "displayInBanner", EmitDefaultValue = true)]
        public bool DisplayInBanner { get; set; }

        /// <summary>
        /// If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool.
        /// </summary>
        /// <value>If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.  Specific categories can now have thier own distinct progression, apparently. So that&#39;s cool.</value>
        [DataMember(Name = "progressionHash", EmitDefaultValue = true)]
        public int? ProgressionHash { get; set; }

        /// <summary>
        /// If this category sorts items in a nonstandard way, this will be the way we sort.
        /// </summary>
        /// <value>If this category sorts items in a nonstandard way, this will be the way we sort.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
        /// </summary>
        /// <value>An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</value>
        [DataMember(Name = "displayStyleHash", EmitDefaultValue = true)]
        public int? DisplayStyleHash { get; set; }

        /// <summary>
        /// An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
        /// </summary>
        /// <value>An indicator of how the category will be displayed in the UI. It&#39;s up to you to do something cool or interesting in response to this, or just to treat it as a normal category.</value>
        [DataMember(Name = "displayStyleIdentifier", EmitDefaultValue = false)]
        public string DisplayStyleIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyDisplayCategoryDefinition {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayCategoryHash: ").Append(DisplayCategoryHash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  DisplayInBanner: ").Append(DisplayInBanner).Append("\n");
            sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  DisplayStyleHash: ").Append(DisplayStyleHash).Append("\n");
            sb.Append("  DisplayStyleIdentifier: ").Append(DisplayStyleIdentifier).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyDisplayCategoryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyDisplayCategoryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyDisplayCategoryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyDisplayCategoryDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayCategoryHash == input.DisplayCategoryHash ||
                    this.DisplayCategoryHash.Equals(input.DisplayCategoryHash)
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.DisplayInBanner == input.DisplayInBanner ||
                    this.DisplayInBanner.Equals(input.DisplayInBanner)
                ) && 
                (
                    this.ProgressionHash == input.ProgressionHash ||
                    (this.ProgressionHash != null &&
                    this.ProgressionHash.Equals(input.ProgressionHash))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
                ) && 
                (
                    this.DisplayStyleHash == input.DisplayStyleHash ||
                    (this.DisplayStyleHash != null &&
                    this.DisplayStyleHash.Equals(input.DisplayStyleHash))
                ) && 
                (
                    this.DisplayStyleIdentifier == input.DisplayStyleIdentifier ||
                    (this.DisplayStyleIdentifier != null &&
                    this.DisplayStyleIdentifier.Equals(input.DisplayStyleIdentifier))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayCategoryHash.GetHashCode();
                if (this.DisplayProperties != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayInBanner.GetHashCode();
                if (this.ProgressionHash != null)
                {
                    hashCode = (hashCode * 59) + this.ProgressionHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
                if (this.DisplayStyleHash != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayStyleHash.GetHashCode();
                }
                if (this.DisplayStyleIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayStyleIdentifier.GetHashCode();
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
