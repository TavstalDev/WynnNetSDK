using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to get detailed information about a player character from the Wynncraft API.
/// </summary>
public class PlayerGetCharacterRequest : HttpRequestBase<PlayerDetailedCharacter>
{
    /// <summary>
    /// Creates a new request to get detailed information about a player character.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="uuid">The UUID of the character.</param>
    public PlayerGetCharacterRequest(string username, string uuid)
        : base(HttpMethod.Get, $"/v3/player/{username}/characters/{uuid}")
    {
    }
}
