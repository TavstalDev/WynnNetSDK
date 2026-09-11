using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to list all guilds from the Wynncraft API.
/// </summary>
public class GuildListRequest : HttpRequestBase<Dictionary<string, GuildResult>>
{
    /// <summary>
    /// Creates a new request to list all guilds.
    /// </summary>
    /// <param name="identifier">The identifier type to use in the response.</param>
    public GuildListRequest(EIdentifier? identifier = null)
        : base(HttpMethod.Get, "/v3/guild/list/guild")
    {
        List<string> queryParams = [];
        if (identifier.HasValue)
            queryParams.Add($"identifier={identifier.Value}");

        if (queryParams.Count == 0)
            return;

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}
