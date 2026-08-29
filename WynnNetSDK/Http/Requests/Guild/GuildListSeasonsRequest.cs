using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListSeasonsRequest : HttpRequestBase<Dictionary<string, GuildSeason>>
{
    public GuildListSeasonsRequest() 
        : base(HttpMethod.Get, "/v3/guild/seasons")
    {
    }
}