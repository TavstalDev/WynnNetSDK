using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetByNameRequest : HttpRequestBase<GuildDetailedInfo>
{
    public GuildGetByNameRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/{query}")
    {
    }
}