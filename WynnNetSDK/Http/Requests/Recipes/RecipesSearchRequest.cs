namespace Tavstal.WynnNetSDK.Http.Requests.Recipes;

public class RecipesSearchRequest : HttpRequestBase
{
    public RecipesSearchRequest() 
        : base(HttpMethod.Post, "/v3/item/recipe/search")
    {
    }
}