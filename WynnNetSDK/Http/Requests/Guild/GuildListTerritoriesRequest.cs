using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Requests.Guild;

/// <summary>
/// A request to list all guild territories from the Wynncraft API.
/// </summary>
public class GuildListTerritoriesRequest : HttpRequestBase<Dictionary<string, GuildTerritory>>
{
    /// <summary>
    /// Creates a new request to list all guild territories.
    /// </summary>
    public GuildListTerritoriesRequest() 
        : base(HttpMethod.Get, "/v3/guild/list/territory")
    {
    }
}