using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerGuildInfo
{
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
    
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;
    
    [JsonPropertyName("rankStars")]
    public string RankStars { get; set; } = string.Empty;
}