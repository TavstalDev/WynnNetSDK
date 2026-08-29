using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerListCharactersRequest : HttpRequestBase<Dictionary<string, PlayerCharacter>>
{
    public PlayerListCharactersRequest(string username) 
        : base(HttpMethod.Get, $"/v3/player/{username}/characters")
    {
    }
}