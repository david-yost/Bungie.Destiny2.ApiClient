# Org.OpenAPITools.Model.DestinyDefinitionsDestinyItemSocketEntryDefinition
The definition information for a specific socket on an item. This will determine how the socket behaves in-game.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SocketTypeHash** | **int** | All sockets have a type, and this is the hash identifier for this particular type. Use it to look up the DestinySocketTypeDefinition: read there for more information on how socket types affect the behavior of the socket. | [optional] 
**SingleInitialItemHash** | **int** | If a valid hash, this is the hash identifier for the DestinyInventoryItemDefinition representing the Plug that will be initially inserted into the item on item creation. Otherwise, this Socket will either start without a plug inserted, or will have one randomly inserted. | [optional] 
**ReusablePlugItems** | [**List&lt;DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition&gt;**](DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition.md) | This is a list of pre-determined plugs that can *always* be plugged into this socket, without the character having the plug in their inventory.  If this list is populated, you will not be allowed to plug an arbitrary item in the socket: you will only be able to choose from one of these reusable plugs. | [optional] 
**PreventInitializationOnVendorPurchase** | **bool** | If this is true, then the socket will not be initialized with a plug if the item is purchased from a Vendor.  Remember that Vendors are much more than conceptual vendors: they include \&quot;Collection Kiosks\&quot; and other entities. See DestinyVendorDefinition for more information. | [optional] 
**HidePerksInItemTooltip** | **bool** | If this is true, the perks provided by this socket shouldn&#39;t be shown in the item&#39;s tooltip. This might be useful if it&#39;s providing a hidden bonus, or if the bonus is less important than other benefits on the item. | [optional] 
**PlugSources** | **int** | Indicates where you should go to get plugs for this socket. This will affect how you populate your UI, as well as what plugs are valid for this socket. It&#39;s an alternative to having to check for the existence of certain properties (reusablePlugItems for example) to infer where plugs should come from. | [optional] 
**ReusablePlugSetHash** | **int?** | If this socket&#39;s plugs come from a reusable DestinyPlugSetDefinition, this is the identifier for that set. We added this concept to reduce some major duplication that&#39;s going to come from sockets as replacements for what was once implemented as large sets of items and kiosks (like Emotes).   As of Shadowkeep, these will come up much more frequently and be driven by game content rather than custom curation. | [optional] 
**RandomizedPlugSetHash** | **int?** | This field replaces \&quot;randomizedPlugItems\&quot; as of Shadowkeep launch. If a socket has randomized plugs, this is a pointer to the set of plugs that could be used, as defined in DestinyPlugSetDefinition.   If null, the item has no randomized plugs. | [optional] 
**DefaultVisible** | **bool** | If true, then this socket is visible in the item&#39;s \&quot;default\&quot; state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you&#39;re looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

