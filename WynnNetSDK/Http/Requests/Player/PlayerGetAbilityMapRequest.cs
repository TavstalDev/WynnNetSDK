using Tavstal.WynnNetSDK.Models.Abilities;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to get the ability map for a player character from the Wynncraft API.
/// </summary>
public class PlayerGetAbilityMapRequest : HttpRequestBase<Dictionary<string, List<AbilityMap>>>
{
    /// <summary>
    /// Creates a new request to get the ability map for a player character.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="uuid">The UUID of the character.</param>
    public PlayerGetAbilityMapRequest(string username, string uuid)
        : base(HttpMethod.Get, $"/v3/player/{username}/characters/{uuid}/abilities")
    {
    }
}
