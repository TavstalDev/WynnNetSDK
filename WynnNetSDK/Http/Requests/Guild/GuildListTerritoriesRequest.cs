using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListTerritoriesRequest : HttpRequestBase<Dictionary<string, GuildTerritory>>
{
    public GuildListTerritoriesRequest() 
        : base(HttpMethod.Get, "/v3/guild/list/territory")
    {
    }
}