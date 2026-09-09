using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to list all characters of a player from the Wynncraft API.
/// </summary>
public class PlayerListCharactersRequest : HttpRequestBase<Dictionary<string, PlayerCharacter>>
{
    /// <summary>
    /// Creates a new request to list all characters of a player.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    public PlayerListCharactersRequest(string username) 
        : base(HttpMethod.Get, $"/v3/player/{username}/characters")
    {
    }
}