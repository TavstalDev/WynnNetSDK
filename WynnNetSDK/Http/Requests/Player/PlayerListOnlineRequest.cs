using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerListOnlineRequest : HttpRequestBase<PlayerListOnlineResponse>
{
    public PlayerListOnlineRequest(EIdentifier? identifier = null, string? server = null) 
        : base(HttpMethod.Get, "/v3/player")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");
        if (server != null)
            queryParams.Add($"server={server}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
    
    public PlayerListOnlineRequest(EIdentifier? identifier = null, int? server = null) 
        : base(HttpMethod.Get, "/v3/player")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");
        if (server != null)
            queryParams.Add($"server={server}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}