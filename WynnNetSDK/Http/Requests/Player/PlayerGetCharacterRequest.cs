using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerGetCharacterRequest : HttpRequestBase<PlayerDetailedCharacter>
{
    public PlayerGetCharacterRequest(string username, string uuid) 
        : base(HttpMethod.Get, $"/v3/player/{username}/characters/{uuid}")
    {
    }
}