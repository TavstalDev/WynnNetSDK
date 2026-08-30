using System.Net.Http.Json;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsSearchRequest : HttpRequestBase<ItemResult>
{
    public ItemsSearchRequest(ItemSearchRequestBody requestBody, int? page = null, bool? fullResult = null) 
        : base(HttpMethod.Post, "/v3/item/search")
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
        Content = JsonContent.Create(requestBody, WynnNetSDKJsonContext.Default.ItemSearchRequestBody);
    }
}