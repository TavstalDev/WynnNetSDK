using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Player;

/// <summary>
/// A request to list all online players from the Wynncraft API.
/// </summary>
public class PlayerListOnlineRequest : HttpRequestBase<PlayerListOnlineResponse>
{
    /// <summary>
    /// Creates a new request to list all online players using a server name.
    /// </summary>
    /// <param name="identifier">The identifier type to use in the response.</param>
    /// <param name="server">The server name to filter by.</param>
    public PlayerListOnlineRequest(EIdentifier? identifier = null, string? server = null)
        : base(HttpMethod.Get, "/v3/player")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");
        if (server != null)
            queryParams.Add($"server={server}");

        if (queryParams.Count == 0)
            return;

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }

    /// <summary>
    /// Creates a new request to list all online players using a server ID.
    /// </summary>
    /// <param name="identifier">The identifier type to use in the response.</param>
    /// <param name="server">The server ID to filter by.</param>
    public PlayerListOnlineRequest(EIdentifier? identifier = null, int? server = null)
        : base(HttpMethod.Get, "/v3/player")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");
        if (server != null)
            queryParams.Add($"server={server}");

        if (queryParams.Count == 0)
            return;

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}
