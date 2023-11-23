# Org.OpenAPITools.Model.DestinyEntitiesVendorsDestinyVendorCategoriesComponent
A vendor can have many categories of items that they sell. This component will return the category information for available items, as well as the index into those items in the user's sale item list.  Note that, since both the category and items are indexes, this data is Content Version dependent. Be sure to check that your content is up to date before using this data. This is an unfortunate, but permanent, limitation of Vendor data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | [**List&lt;DestinyEntitiesVendorsDestinyVendorCategory&gt;**](DestinyEntitiesVendorsDestinyVendorCategory.md) | The list of categories for items that the vendor sells, in rendering order.  These categories each point to a \&quot;display category\&quot; in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

