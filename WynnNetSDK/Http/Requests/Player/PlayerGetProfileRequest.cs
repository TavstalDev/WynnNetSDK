using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerGetProfileRequest : HttpRequestBase<PlayerDetailedInfo>
{
    public PlayerGetProfileRequest(string username) 
        : base(HttpMethod.Get, $"/v3/player/{username}")
    {
    }
}