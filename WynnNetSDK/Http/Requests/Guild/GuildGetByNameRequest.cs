using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to get a guild by its name from the Wynncraft API.
/// </summary>
public class GuildGetByNameRequest : HttpRequestBase<GuildDetailedInfo>
{
    /// <summary>
    /// Creates a new request to get a guild by its name.
    /// </summary>
    /// <param name="query">The name of the guild to search for.</param>
    public GuildGetByNameRequest(string query) 
        : base(HttpMethod.Get, $"/v3/guild/{query}")
    {
    }
}