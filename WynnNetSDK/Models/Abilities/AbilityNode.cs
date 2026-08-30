using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Abilities;

public class AbilityNode
{
    [JsonPropertyName("type")]
    public EAbilityType Type { get; set; }
    
    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new();
    
    [JsonPropertyName("meta")]
    public AbilityNodeMeta Meta { get; set; } = new();
    
    [JsonPropertyName("family")]
    public List<string> Family { get; set; } = [];
}