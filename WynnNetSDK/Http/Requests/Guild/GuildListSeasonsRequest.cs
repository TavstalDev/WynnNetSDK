using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to list all guild seasons from the Wynncraft API.
/// </summary>
public class GuildListSeasonsRequest : HttpRequestBase<Dictionary<string, GuildSeason>>
{
    /// <summary>
    /// Creates a new request to list all guild seasons.
    /// </summary>
    public GuildListSeasonsRequest() 
        : base(HttpMethod.Get, "/v3/guild/seasons")
    {
    }
}