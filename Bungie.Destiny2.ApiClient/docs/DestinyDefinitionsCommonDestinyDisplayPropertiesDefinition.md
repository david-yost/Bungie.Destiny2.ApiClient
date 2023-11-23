# Org.OpenAPITools.Model.DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition
Many Destiny*Definition contracts - the \"first order\" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Icon** | **string** | Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images. | [optional] 
**IconSequences** | [**List&lt;DestinyDefinitionsCommonDestinyIconSequenceDefinition&gt;**](DestinyDefinitionsCommonDestinyIconSequenceDefinition.md) |  | [optional] 
**HighResIcon** | **string** | If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here. | [optional] 
**HasIcon** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

