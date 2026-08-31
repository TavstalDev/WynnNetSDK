using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapGatherNode
{
    [JsonPropertyName("x")]
    public int X { get; set; }
    
    [JsonPropertyName("y")]
    public int Y { get; set; }
    
    [JsonPropertyName("z")]
    public int Z { get; set; }
    
    [JsonPropertyName("angle")]
    public int Angle { get; set; }
    
    [JsonPropertyName("type")]
    public EGatherNode Type { get; set; }
    
    [JsonPropertyName("resource")]
    public string Resource { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
}