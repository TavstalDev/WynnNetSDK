namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

public class GuildListTerritoriesRequest : HttpRequestBase
{
    public GuildListTerritoriesRequest() 
        : base(HttpMethod.Get, "/v3/guild/list/territory")
    {
    }
}