using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapMarker
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;
    
    [JsonPropertyName("x")]
    public string X { get; set; } = string.Empty;
    
    [JsonPropertyName("y")]
    public string Y { get; set; } = string.Empty;
    
    [JsonPropertyName("z")]
    public string Z { get; set; } = string.Empty;
}