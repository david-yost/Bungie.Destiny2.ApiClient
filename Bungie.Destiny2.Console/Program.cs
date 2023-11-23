using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;


var userApi = new UserApi(new Configuration
{
    DefaultHeaders = new Dictionary<string, string> { { "X-API-Key", "c97f995de5e3438eba25fd2a456d4fc9" } },
}); 

var result = await userApi.UserSearchByGlobalNamePostAsync(0, new Org.OpenAPITools.Model.UserUserSearchPrefixRequest { DisplayNamePrefix = "Achaia" });

Console.WriteLine("User Search Results:");
foreach (var x in result.Response.SearchResults)
Console.WriteLine($"{x.BungieNetMembershipId}:{x.BungieGlobalDisplayName}");