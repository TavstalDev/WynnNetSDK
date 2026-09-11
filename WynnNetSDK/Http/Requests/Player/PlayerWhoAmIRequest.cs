using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to get the identity of the authenticated player from the Wynncraft API.
/// </summary>
public class PlayerWhoAmIRequest : HttpRequestBase<Dictionary<string, PlayerInfo>>
{
    /// <summary>
    /// Creates a new request to get the identity of the authenticated player.
    /// </summary>
    public PlayerWhoAmIRequest()
        : base(HttpMethod.Get, "/v3/player/whoami")
    {
    }
}
