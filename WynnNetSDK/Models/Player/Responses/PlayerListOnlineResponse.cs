using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.Responses;

/// <summary>
/// Represents the response from the online players list endpoint.
/// </summary>
public class PlayerListOnlineResponse
{
    /// <summary>
    /// The total number of players currently online.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// A dictionary of online players mapped by UUID to username.
    /// </summary>
    [JsonPropertyName("players")]
    public Dictionary<string, string> Players { get; set; } = new();
}
