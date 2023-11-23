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
    /// DestinyDefinitionsDestinyPlugItemCraftingRequirements
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyPlugItemCraftingRequirements")]
    public partial class DestinyDefinitionsDestinyPlugItemCraftingRequirements : IEquatable<DestinyDefinitionsDestinyPlugItemCraftingRequirements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyPlugItemCraftingRequirements" /> class.
        /// </summary>
        /// <param name="unlockRequirements">unlockRequirements.</param>
        /// <param name="requiredLevel">If the plug has a known level requirement, it&#39;ll be available here..</param>
        /// <param name="materialRequirementHashes">materialRequirementHashes.</param>
        public DestinyDefinitionsDestinyPlugItemCraftingRequirements(List<DestinyDefinitionsDestinyPlugItemCraftingUnlockRequirement> unlockRequirements = default(List<DestinyDefinitionsDestinyPlugItemCraftingUnlockRequirement>), int? requiredLevel = default(int?), List<int> materialRequirementHashes = default(List<int>))
        {
            this.UnlockRequirements = unlockRequirements;
            this.RequiredLevel = requiredLevel;
            this.MaterialRequirementHashes = materialRequirementHashes;
        }

        /// <summary>
        /// Gets or Sets UnlockRequirements
        /// </summary>
        [DataMember(Name = "unlockRequirements", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyPlugItemCraftingUnlockRequirement> UnlockRequirements { get; set; }

        /// <summary>
        /// If the plug has a known level requirement, it&#39;ll be available here.
        /// </summary>
        /// <value>If the plug has a known level requirement, it&#39;ll be available here.</value>
        [DataMember(Name = "requiredLevel", EmitDefaultValue = true)]
        public int? RequiredLevel { get; set; }

        /// <summary>
        /// Gets or Sets MaterialRequirementHashes
        /// </summary>
        [DataMember(Name = "materialRequirementHashes", EmitDefaultValue = false)]
        public List<int> MaterialRequirementHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyPlugItemCraftingRequirements {\n");
            sb.Append("  UnlockRequirements: ").Append(UnlockRequirements).Append("\n");
            sb.Append("  RequiredLevel: ").Append(RequiredLevel).Append("\n");
            sb.Append("  MaterialRequirementHashes: ").Append(MaterialRequirementHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyPlugItemCraftingRequirements);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyPlugItemCraftingRequirements instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyPlugItemCraftingRequirements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyPlugItemCraftingRequirements input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnlockRequirements == input.UnlockRequirements ||
                    this.UnlockRequirements != null &&
                    input.UnlockRequirements != null &&
                    this.UnlockRequirements.SequenceEqual(input.UnlockRequirements)
                ) && 
                (
                    this.RequiredLevel == input.RequiredLevel ||
                    (this.RequiredLevel != null &&
                    this.RequiredLevel.Equals(input.RequiredLevel))
                ) && 
                (
                    this.MaterialRequirementHashes == input.MaterialRequirementHashes ||
                    this.MaterialRequirementHashes != null &&
                    input.MaterialRequirementHashes != null &&
                    this.MaterialRequirementHashes.SequenceEqual(input.MaterialRequirementHashes)
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
                if (this.UnlockRequirements != null)
                {
                    hashCode = (hashCode * 59) + this.UnlockRequirements.GetHashCode();
                }
                if (this.RequiredLevel != null)
                {
                    hashCode = (hashCode * 59) + this.RequiredLevel.GetHashCode();
                }
                if (this.MaterialRequirementHashes != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialRequirementHashes.GetHashCode();
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
