using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapPlayerLocation
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }
    
    [JsonPropertyName("character")]
    public string Character { get; set; } = string.Empty;
    
    [JsonPropertyName("server")]
    public string? Server { get; set; }
    
    [JsonPropertyName("x")]
    public int X { get; set; }
    
    [JsonPropertyName("y")]
    public int Y { get; set; }
    
    [JsonPropertyName("z")]
    public int Z { get; set; }
}