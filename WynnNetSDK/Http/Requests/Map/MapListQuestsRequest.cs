using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all quests from the Wynncraft API.
/// </summary>
public class MapListQuestsRequest : HttpRequestBase<MapQuests>
{
    /// <summary>
    /// Creates a new request to list all quests.
    /// </summary>
    public MapListQuestsRequest() 
        : base(HttpMethod.Get, "/v3/map/quests")
    {
    }
}