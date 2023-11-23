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
    /// The time has unfortunately come to talk about Talent Grids.  Talent Grids are the most complex and unintuitive part of the Destiny Definition data. Grab a cup of coffee before we begin, I can wait.  Talent Grids were the primary way that items could be customized in Destiny 1. In Destiny 2, for now, talent grids have become exclusively used by Subclass/Build items: but the system is still in place for it to be used by items should the direction change back toward talent grids.  Talent Grids have Nodes: the visual circles on the talent grid detail screen that have icons and can be activated if you meet certain requirements and pay costs. The actual visual data and effects, however, are driven by the \&quot;Steps\&quot; on Talent Nodes. Any given node will have 1:M of these steps, and the specific step that will be considered the \&quot;current\&quot; step (and thus the dictator of all benefits, visual state, and activation requirements on the Node) will almost always not be determined until an instance of the item is created. This is how, in Destiny 1, items were able to have such a wide variety of what users saw as \&quot;Perks\&quot;: they were actually Talent Grids with nodes that had a wide variety of Steps, randomly chosen at the time of item creation.  Now that Talent Grids are used exclusively by subclasses and builds, all of the properties within still apply: but there are additional visual elements on the Subclass/Build screens that are superimposed on top of the talent nodes. Unfortunately, BNet doesn&#39;t have this data: if you want to build a subclass screen, you will have to provide your own \&quot;decorative\&quot; assets, such as the visual connectors between nodes and the fancy colored-fire-bathed character standing behind the nodes.  DestinyInventoryItem.talentGrid.talentGridHash defines an item&#39;s linked Talent Grid, which brings you to this definition that contains enough satic data about talent grids to make your head spin. These *must* be combined with instanced data - found when live data returns DestinyItemTalentGridComponent - in order to derive meaning. The instanced data will reference nodes and steps within these definitions, which you will then have to look up in the definition and combine with the instanced data to give the user the visual representation of their item&#39;s talent grid.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyTalentGridDefinition")]
    public partial class DestinyDefinitionsDestinyTalentGridDefinition : IEquatable<DestinyDefinitionsDestinyTalentGridDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyTalentGridDefinition" /> class.
        /// </summary>
        /// <param name="maxGridLevel">The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated..</param>
        /// <param name="gridLevelPerColumn">The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \&quot;column\&quot; of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it&#39;s just a bit of interesting history..</param>
        /// <param name="progressionHash">The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid&#39;s level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition&#39;s activation requirements for more information..</param>
        /// <param name="nodes">The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent)..</param>
        /// <param name="exclusiveSets">Talent Nodes can exist in \&quot;exclusive sets\&quot;: these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \&quot;Swap\&quot;).  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept..</param>
        /// <param name="independentNodeIndexes">This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping..</param>
        /// <param name="groups">Talent Nodes can have \&quot;Exclusive Groups\&quot;. These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \&quot;groupHash\&quot; from DestinyTalentExclusiveGroup..</param>
        /// <param name="nodeCategories">BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \&quot;Independent\&quot; nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyTalentGridDefinition(int maxGridLevel = default(int), int gridLevelPerColumn = default(int), int progressionHash = default(int), List<DestinyDefinitionsDestinyTalentNodeDefinition> nodes = default(List<DestinyDefinitionsDestinyTalentNodeDefinition>), List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> exclusiveSets = default(List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition>), List<int> independentNodeIndexes = default(List<int>), Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> groups = default(Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup>), List<DestinyDefinitionsDestinyTalentNodeCategory> nodeCategories = default(List<DestinyDefinitionsDestinyTalentNodeCategory>), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.MaxGridLevel = maxGridLevel;
            this.GridLevelPerColumn = gridLevelPerColumn;
            this.ProgressionHash = progressionHash;
            this.Nodes = nodes;
            this.ExclusiveSets = exclusiveSets;
            this.IndependentNodeIndexes = independentNodeIndexes;
            this.Groups = groups;
            this.NodeCategories = nodeCategories;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }

        /// <summary>
        /// The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.
        /// </summary>
        /// <value>The maximum possible level of the Talent Grid: at this level, any nodes are allowed to be activated.</value>
        [DataMember(Name = "maxGridLevel", EmitDefaultValue = false)]
        public int MaxGridLevel { get; set; }

        /// <summary>
        /// The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \&quot;column\&quot; of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it&#39;s just a bit of interesting history.
        /// </summary>
        /// <value>The meaning of this has been lost in the sands of time: it still exists as a property, but appears to be unused in the modern UI of talent grids. It used to imply that each visual \&quot;column\&quot; of talent nodes required identical progression levels in order to be activated. Returning this value in case it is still useful to someone? Perhaps it&#39;s just a bit of interesting history.</value>
        [DataMember(Name = "gridLevelPerColumn", EmitDefaultValue = false)]
        public int GridLevelPerColumn { get; set; }

        /// <summary>
        /// The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid&#39;s level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition&#39;s activation requirements for more information.
        /// </summary>
        /// <value>The hash identifier of the Progression (DestinyProgressionDefinition) that drives whether and when Talent Nodes can be activated on the Grid. Items will have instances of this Progression, and will gain experience that will eventually cause the grid to increase in level. As the grid&#39;s level increases, it will cross the threshold where nodes can be activated. See DestinyTalentGridStepDefinition&#39;s activation requirements for more information.</value>
        [DataMember(Name = "progressionHash", EmitDefaultValue = false)]
        public int ProgressionHash { get; set; }

        /// <summary>
        /// The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).
        /// </summary>
        /// <value>The list of Talent Nodes on the Grid (recall that Nodes themselves are really just locations in the UI to show whatever their current Step is. You will only know the current step for a node by retrieving instanced data through platform calls to the API that return DestinyItemTalentGridComponent).</value>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyTalentNodeDefinition> Nodes { get; set; }

        /// <summary>
        /// Talent Nodes can exist in \&quot;exclusive sets\&quot;: these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \&quot;Swap\&quot;).  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.
        /// </summary>
        /// <value>Talent Nodes can exist in \&quot;exclusive sets\&quot;: these are sets of nodes in which only a single node in the set can be activated at any given time. Activating a node in this set will automatically deactivate the other nodes in the set (referred to as a \&quot;Swap\&quot;).  If a node in the exclusive set has already been activated, the game will not charge you materials to activate another node in the set, even if you have never activated it before, because you already paid the cost to activate one node in the set.  Not to be confused with Exclusive Groups. (how the heck do we NOT get confused by that? Jeez) See the groups property for information about that only-tangentially-related concept.</value>
        [DataMember(Name = "exclusiveSets", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition> ExclusiveSets { get; set; }

        /// <summary>
        /// This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.
        /// </summary>
        /// <value>This is a quick reference to the indexes of nodes that are not part of exclusive sets. Handy for knowing which talent nodes can only be activated directly, rather than via swapping.</value>
        [DataMember(Name = "independentNodeIndexes", EmitDefaultValue = false)]
        public List<int> IndependentNodeIndexes { get; set; }

        /// <summary>
        /// Talent Nodes can have \&quot;Exclusive Groups\&quot;. These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \&quot;groupHash\&quot; from DestinyTalentExclusiveGroup.
        /// </summary>
        /// <value>Talent Nodes can have \&quot;Exclusive Groups\&quot;. These are not to be confused with Exclusive Sets (see exclusiveSets property).  Look at the definition of DestinyTalentExclusiveGroup for more information and how they work. These groups are keyed by the \&quot;groupHash\&quot; from DestinyTalentExclusiveGroup.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public Dictionary<string, DestinyDefinitionsDestinyTalentExclusiveGroup> Groups { get; set; }

        /// <summary>
        /// BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \&quot;Independent\&quot; nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.
        /// </summary>
        /// <value>BNet wants to show talent nodes grouped by similar purpose with localized titles. This is the ordered list of those categories: if you want to show nodes by category, you can iterate over this list, render the displayProperties for the category as the title, and then iterate over the talent nodes referenced by the category to show the related nodes.  Note that this is different from Exclusive Groups or Sets, because these categories also incorporate \&quot;Independent\&quot; nodes that belong to neither sets nor groups. These are purely for visual grouping of nodes rather than functional grouping.</value>
        [DataMember(Name = "nodeCategories", EmitDefaultValue = false)]
        public List<DestinyDefinitionsDestinyTalentNodeCategory> NodeCategories { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public int Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name = "redacted", EmitDefaultValue = true)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyTalentGridDefinition {\n");
            sb.Append("  MaxGridLevel: ").Append(MaxGridLevel).Append("\n");
            sb.Append("  GridLevelPerColumn: ").Append(GridLevelPerColumn).Append("\n");
            sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  ExclusiveSets: ").Append(ExclusiveSets).Append("\n");
            sb.Append("  IndependentNodeIndexes: ").Append(IndependentNodeIndexes).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  NodeCategories: ").Append(NodeCategories).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyTalentGridDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyTalentGridDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyTalentGridDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyTalentGridDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxGridLevel == input.MaxGridLevel ||
                    this.MaxGridLevel.Equals(input.MaxGridLevel)
                ) && 
                (
                    this.GridLevelPerColumn == input.GridLevelPerColumn ||
                    this.GridLevelPerColumn.Equals(input.GridLevelPerColumn)
                ) && 
                (
                    this.ProgressionHash == input.ProgressionHash ||
                    this.ProgressionHash.Equals(input.ProgressionHash)
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.ExclusiveSets == input.ExclusiveSets ||
                    this.ExclusiveSets != null &&
                    input.ExclusiveSets != null &&
                    this.ExclusiveSets.SequenceEqual(input.ExclusiveSets)
                ) && 
                (
                    this.IndependentNodeIndexes == input.IndependentNodeIndexes ||
                    this.IndependentNodeIndexes != null &&
                    input.IndependentNodeIndexes != null &&
                    this.IndependentNodeIndexes.SequenceEqual(input.IndependentNodeIndexes)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.NodeCategories == input.NodeCategories ||
                    this.NodeCategories != null &&
                    input.NodeCategories != null &&
                    this.NodeCategories.SequenceEqual(input.NodeCategories)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                hashCode = (hashCode * 59) + this.MaxGridLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.GridLevelPerColumn.GetHashCode();
                hashCode = (hashCode * 59) + this.ProgressionHash.GetHashCode();
                if (this.Nodes != null)
                {
                    hashCode = (hashCode * 59) + this.Nodes.GetHashCode();
                }
                if (this.ExclusiveSets != null)
                {
                    hashCode = (hashCode * 59) + this.ExclusiveSets.GetHashCode();
                }
                if (this.IndependentNodeIndexes != null)
                {
                    hashCode = (hashCode * 59) + this.IndependentNodeIndexes.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.NodeCategories != null)
                {
                    hashCode = (hashCode * 59) + this.NodeCategories.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Redacted.GetHashCode();
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