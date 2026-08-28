namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildGetPrefixRequest : HttpRequestBase
{
    public GuildGetPrefixRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/prefix/{query}")
    {
    }
}