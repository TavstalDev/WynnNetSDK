using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerWhoAmIRequest : HttpRequestBase<Dictionary<string, PlayerInfo>>
{
    public PlayerWhoAmIRequest() 
        : base(HttpMethod.Get, "/v3/player/whoami")
    {
    }
}