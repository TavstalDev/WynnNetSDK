using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to get a guild by its prefix from the Wynncraft API.
/// </summary>
public class GuildGetPrefixRequest : HttpRequestBase<GuildDetailedInfo>
{
    /// <summary>
    /// Creates a new request to get a guild by its prefix.
    /// </summary>
    /// <param name="query">The prefix of the guild to search for.</param>
    public GuildGetPrefixRequest(string query)
        : base(HttpMethod.Get, $"/v3/guild/prefix/{query}")
    {
    }
}
