# Org.OpenAPITools.Model.DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition
Represents a variant on an activity for a Milestone: a specific difficulty tier, or a specific activity variant for example.  These will often have more specific details, such as an associated Guided Game, progression steps, tier-specific rewards, and custom values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityHash** | **int** | The hash to use for looking up the variant Activity&#39;s definition (DestinyActivityDefinition), where you can find its distinguishing characteristics such as difficulty level and recommended light level.   Frequently, that will be the only distinguishing characteristics in practice, which is somewhat of a bummer. | [optional] 
**Order** | **int** | If you care to do so, render the variants in the order prescribed by this value.  When you combine live Milestone data with the definition, the order becomes more useful because you&#39;ll be cross-referencing between the definition and live data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

