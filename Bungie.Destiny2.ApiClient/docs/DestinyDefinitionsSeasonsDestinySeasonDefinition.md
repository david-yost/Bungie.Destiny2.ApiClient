# Org.OpenAPITools.Model.DestinyDefinitionsSeasonsDestinySeasonDefinition
Defines a canonical \"Season\" of Destiny: a range of a few months where the game highlights certain challenges, provides new loot, has new Clan-related rewards and celebrates various seasonal events.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**BackgroundImagePath** | **string** |  | [optional] 
**SeasonNumber** | **int** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**SeasonPassHash** | **int?** |  | [optional] 
**SeasonPassProgressionHash** | **int?** |  | [optional] 
**ArtifactItemHash** | **int?** |  | [optional] 
**SealPresentationNodeHash** | **int?** |  | [optional] 
**SeasonalChallengesPresentationNodeHash** | **int?** |  | [optional] 
**Preview** | [**DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition**](DestinyDefinitionsSeasonsDestinySeasonPreviewDefinition.md) |  | [optional] 
**Hash** | **int** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

