using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListRequest : HttpRequestBase<Dictionary<string, GuildResult>>
{
    public GuildListRequest(EIdentifier? identifier = null) 
        : base(HttpMethod.Get, "/v3/guild/list/guild")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");

        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}