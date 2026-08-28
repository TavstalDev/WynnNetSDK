namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListRequest : HttpRequestBase
{
    public GuildListRequest() 
        : base(HttpMethod.Get, "/v3/guild/list/guild")
    {
    }
}