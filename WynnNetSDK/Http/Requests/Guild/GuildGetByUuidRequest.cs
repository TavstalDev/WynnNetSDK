using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to get a guild by its UUID from the Wynncraft API.
/// </summary>
public class GuildGetByUuidRequest : HttpRequestBase<GuildDetailedInfo>
{
    /// <summary>
    /// Creates a new request to get a guild by its UUID.
    /// </summary>
    /// <param name="query">The UUID of the guild to search for.</param>
    public GuildGetByUuidRequest(string query)
        : base(HttpMethod.Get, $"/v3/guild/uuid/{query}")
    {
    }
}
