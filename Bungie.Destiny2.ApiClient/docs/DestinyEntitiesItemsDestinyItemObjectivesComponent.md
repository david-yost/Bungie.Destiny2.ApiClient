# Org.OpenAPITools.Model.DestinyEntitiesItemsDestinyItemObjectivesComponent
Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Objectives** | [**List&lt;DestinyQuestsDestinyObjectiveProgress&gt;**](DestinyQuestsDestinyObjectiveProgress.md) | If the item has a hard association with objectives, your progress on them will be defined here.   Objectives are our standard way to describe a series of tasks that have to be completed for a reward. | [optional] 
**FlavorObjective** | [**DestinyQuestsDestinyObjectiveProgress**](DestinyQuestsDestinyObjectiveProgress.md) |  | [optional] 
**DateCompleted** | **DateTime?** | If we have any information on when these objectives were completed, this will be the date of that completion. This won&#39;t be on many items, but could be interesting for some items that do store this information. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

