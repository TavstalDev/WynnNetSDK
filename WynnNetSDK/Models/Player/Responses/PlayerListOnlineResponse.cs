using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.Responses;

public class PlayerListOnlineResponse
{
    [JsonPropertyName("total")]
    public int Total { get; set; }
    
    [JsonPropertyName("players")]
    public Dictionary<string, string> Players { get; set; } = new();
}