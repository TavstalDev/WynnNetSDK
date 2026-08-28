namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerGetAbilityMapRequest : HttpRequestBase
{
    public PlayerGetAbilityMapRequest(string username, string uuid) 
        : base(HttpMethod.Get, $"/v3/player/{username}/characters/{uuid}/abilities")
    {
    }
}