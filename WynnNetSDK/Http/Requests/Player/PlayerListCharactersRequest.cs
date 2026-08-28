namespace Tavstal.WynnNetSDK.Http.Requests.Player;

public class PlayerListCharactersRequest : HttpRequestBase
{
    public PlayerListCharactersRequest(string username) 
        : base(HttpMethod.Get, $"/v3/player/{username}/characters")
    {
    }
}