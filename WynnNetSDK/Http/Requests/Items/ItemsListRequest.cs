using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsListRequest : HttpRequestBase<ItemResult>
{
    public ItemsListRequest(int? page = null, bool? fullResult = null) 
        : base(HttpMethod.Get, "/v3/item/database")
    {
        List<string> queryParams = [];
        if (page is > 0)
            queryParams.Add($"page={page}");
        if (fullResult is true)
            queryParams.Add("fullResult");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}