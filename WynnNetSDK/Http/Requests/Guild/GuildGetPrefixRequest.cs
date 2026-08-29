using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetPrefixRequest : HttpRequestBase<GuildDetailedInfo>
{
    public GuildGetPrefixRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/prefix/{query}")
    {
    }
}