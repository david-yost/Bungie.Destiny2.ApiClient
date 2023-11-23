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
    /// As/if presentation nodes begin to host more entities as children, these lists will be added to. One list property exists per type of entity that can be treated as a child of this presentation node, and each holds the identifier of the entity and any associated information needed to display the UI for that entity (if anything)
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.Presentation.DestinyPresentationNodeChildrenBlock")]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock : IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock" /> class.
        /// </summary>
        /// <param name="presentationNodes">presentationNodes.</param>
        /// <param name="collectibles">collectibles.</param>
        /// <param name="records">records.</param>
        /// <param name="metrics">metrics.</param>
        /// <param name="craftables">craftables.</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock(List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> presentationNodes = default(List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry>), List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> collectibles = default(List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry>), List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> records = default(List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry>), List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> metrics = default(List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry>), List<DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry> craftables = default(List<DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry>))
        {
            this.PresentationNodes = presentationNodes;
            this.Collectibles = collectibles;
            this.Records = records;
            this.Metrics = metrics;
            this.Craftables = craftables;
        }

        /// <summary>
        /// Gets or Sets PresentationNodes
        /// </summary>
        [DataMember(Name = "presentationNodes", EmitDefaultValue = false)]
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> PresentationNodes { get; set; }

        /// <summary>
        /// Gets or Sets Collectibles
        /// </summary>
        [DataMember(Name = "collectibles", EmitDefaultValue = false)]
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> Collectibles { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> Records { get; set; }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Craftables
        /// </summary>
        [DataMember(Name = "craftables", EmitDefaultValue = false)]
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeCraftableChildEntry> Craftables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock {\n");
            sb.Append("  PresentationNodes: ").Append(PresentationNodes).Append("\n");
            sb.Append("  Collectibles: ").Append(Collectibles).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Craftables: ").Append(Craftables).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PresentationNodes == input.PresentationNodes ||
                    this.PresentationNodes != null &&
                    input.PresentationNodes != null &&
                    this.PresentationNodes.SequenceEqual(input.PresentationNodes)
                ) && 
                (
                    this.Collectibles == input.Collectibles ||
                    this.Collectibles != null &&
                    input.Collectibles != null &&
                    this.Collectibles.SequenceEqual(input.Collectibles)
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.Craftables == input.Craftables ||
                    this.Craftables != null &&
                    input.Craftables != null &&
                    this.Craftables.SequenceEqual(input.Craftables)
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
                if (this.PresentationNodes != null)
                {
                    hashCode = (hashCode * 59) + this.PresentationNodes.GetHashCode();
                }
                if (this.Collectibles != null)
                {
                    hashCode = (hashCode * 59) + this.Collectibles.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                if (this.Metrics != null)
                {
                    hashCode = (hashCode * 59) + this.Metrics.GetHashCode();
                }
                if (this.Craftables != null)
                {
                    hashCode = (hashCode * 59) + this.Craftables.GetHashCode();
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
