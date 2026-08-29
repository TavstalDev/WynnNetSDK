using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild;

public class GuildInfo
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
    
    [JsonPropertyName("hq")]
    public string Headquarters { get; set; } = string.Empty;
}