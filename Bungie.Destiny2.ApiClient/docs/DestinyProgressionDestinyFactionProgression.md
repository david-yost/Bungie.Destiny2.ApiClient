# Org.OpenAPITools.Model.DestinyProgressionDestinyFactionProgression
Mostly for historical purposes, we segregate Faction progressions from other progressions. This is just a DestinyProgression with a shortcut for finding the DestinyFactionDefinition of the faction related to the progression.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FactionHash** | **int** | The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info. | [optional] 
**FactionVendorIndex** | **int** | The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available. | [optional] 
**ProgressionHash** | **int** | The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data. | [optional] 
**DailyProgress** | **int** | The amount of progress earned today for this progression. | [optional] 
**DailyLimit** | **int** | If this progression has a daily limit, this is that limit. | [optional] 
**WeeklyProgress** | **int** | The amount of progress earned toward this progression in the current week. | [optional] 
**WeeklyLimit** | **int** | If this progression has a weekly limit, this is that limit. | [optional] 
**CurrentProgress** | **int** | This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned) | [optional] 
**Level** | **int** | This is the level of the progression (for instance, the Character Level). | [optional] 
**LevelCap** | **int** | This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable) | [optional] 
**StepIndex** | **int** | Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.) | [optional] 
**ProgressToNextLevel** | **int** | The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word. | [optional] 
**NextLevelAt** | **int** | The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level. | [optional] 
**CurrentResetCount** | **int?** | The number of resets of this progression you&#39;ve executed this season, if applicable to this progression. | [optional] 
**SeasonResets** | [**List&lt;DestinyDestinyProgressionResetEntry&gt;**](DestinyDestinyProgressionResetEntry.md) | Information about historical resets of this progression, if there is any data for it. | [optional] 
**RewardItemStates** | **List&lt;int&gt;** | Information about historical rewards for this progression, if there is any data for it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

