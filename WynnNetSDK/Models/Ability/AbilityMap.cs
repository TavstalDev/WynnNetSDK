using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Ability;

public class AbilityMap
{
    [JsonPropertyName("type")]
    public EAbilityType Type { get; set; }
    
    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new();
    
    [JsonPropertyName("meta")]
    public AbilityMapMeta Meta { get; set; } = new();
    
    [JsonPropertyName("family")]
    public List<string> Family { get; set; } = [];
}