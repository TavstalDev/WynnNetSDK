namespace Tavstal.WynnNetSDK.Http.Requests.Recipes;

public class RecipesListRequest : HttpRequestBase
{
    public RecipesListRequest() 
        : base(HttpMethod.Get, "/v3/item/recipe/database")
    {
    }
}