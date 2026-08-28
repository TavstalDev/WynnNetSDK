namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListSeasonsRequest : HttpRequestBase
{
    public GuildListSeasonsRequest() 
        : base(HttpMethod.Get, "/v3/guild/seasons")
    {
    }
}