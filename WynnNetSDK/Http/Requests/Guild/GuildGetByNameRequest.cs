namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetByNameRequest : HttpRequestBase
{
    public GuildGetByNameRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/{query}")
    {
    }
}