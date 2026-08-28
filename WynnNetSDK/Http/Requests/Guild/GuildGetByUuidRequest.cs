namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetByUuidRequest : HttpRequestBase
{
    public GuildGetByUuidRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/uuid/{query}")
    {
    }
}