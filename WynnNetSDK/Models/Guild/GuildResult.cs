using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild;

public class GuildResult
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
}