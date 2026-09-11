using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to get the detailed profile of a player from the Wynncraft API.
/// </summary>
public class PlayerGetProfileRequest : HttpRequestBase<PlayerDetailedInfo>
{
    /// <summary>
    /// Creates a new request to get the detailed profile of a player.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    public PlayerGetProfileRequest(string username)
        : base(HttpMethod.Get, $"/v3/player/{username}")
    {
    }
}
