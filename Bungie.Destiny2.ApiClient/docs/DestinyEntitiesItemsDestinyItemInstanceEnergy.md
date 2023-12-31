# Org.OpenAPITools.Model.DestinyEntitiesItemsDestinyItemInstanceEnergy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnergyTypeHash** | **int** | The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it. | [optional] 
**EnergyType** | **int** | This is the enum version of the Energy Type value, for convenience. | [optional] 
**EnergyCapacity** | **int** | The total capacity of Energy that the item currently has, regardless of if it is currently being used. | [optional] 
**EnergyUsed** | **int** | The amount of Energy currently in use by inserted plugs. | [optional] 
**EnergyUnused** | **int** | The amount of energy still available for inserting new plugs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

