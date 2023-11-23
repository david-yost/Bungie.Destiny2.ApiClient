# Org.OpenAPITools.Model.DestinyEntitiesItemsDestinyItemTalentGridComponent
Well, we're here in Destiny 2, and Talent Grids are unfortunately still around.  The good news is that they're pretty much only being used for certain base information on items and for Builds/Subclasses. The bad news is that they still suck. If you really want this information, grab this component.  An important note is that talent grids are defined as such:  A Grid has 1:M Nodes, which has 1:M Steps.  Any given node can only have a single step active at one time, which represents the actual visual contents and effects of the Node (for instance, if you see a \"Super Cool Bonus\" node, the actual icon and text for the node is coming from the current Step of that node).  Nodes can be grouped into exclusivity sets *and* as of D2, exclusivity groups (which are collections of exclusivity sets that affect each other).  See DestinyTalentGridDefinition for more information. Brace yourself, the water's cold out there in the deep end.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TalentGridHash** | **int** | Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item. | [optional] 
**Nodes** | [**List&lt;DestinyDestinyTalentNode&gt;**](DestinyDestinyTalentNode.md) | Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node. | [optional] 
**IsGridComplete** | **bool** | Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated) | [optional] 
**GridProgression** | [**DestinyDestinyProgression**](DestinyDestinyProgression.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

