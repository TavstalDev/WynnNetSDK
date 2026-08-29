using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetByUuidRequest : HttpRequestBase<GuildDetailedInfo>
{
    public GuildGetByUuidRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/uuid/{query}")
    {
    }
}