using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Map;

public class WorldEventLocation
{
    [JsonPropertyName("event")]
    public Vector3? Event { get; set; }
    
    [JsonPropertyName("spawn")]
    public Vector3? Spawn { get; set; }
    
    [JsonPropertyName("reward")]
    public Vector3? Reward { get; set; }
    
    [JsonPropertyName("radius")]
    public int? Radius { get; set; }
    
    [JsonPropertyName("spawnRadius")]
    public int? SpawnRadius { get; set; }
}