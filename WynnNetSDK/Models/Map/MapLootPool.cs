using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapLootPool
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public ECampType Type { get; set; }
    
    [JsonPropertyName("rewards")]
    public List<CampReward> Rewards { get; set; } = [];
}