# Org.OpenAPITools.Model.DestinyDefinitionsDestinyNodeSocketReplaceResponse
This is a bit of an odd duck. Apparently, if talent nodes steps have this data, the game will go through on step activation and alter the first Socket it finds on the item that has a type matching the given socket type, inserting the indicated plug item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SocketTypeHash** | **int** | The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question. | [optional] 
**PlugItemHash** | **int** | The hash identifier of the plug item that will be inserted into the socket found. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

