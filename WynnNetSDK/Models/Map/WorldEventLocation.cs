using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents the location data for a world event.
/// </summary>
public class WorldEventLocation
{
    /// <summary>
    /// The world coordinates where the event takes place.
    /// </summary>
    [JsonPropertyName("event")]
    public Vector3? Event { get; set; }
    
    /// <summary>
    /// The world coordinates where players spawn for the event.
    /// </summary>
    [JsonPropertyName("spawn")]
    public Vector3? Spawn { get; set; }
    
    /// <summary>
    /// The world coordinates where the reward is given.
    /// </summary>
    [JsonPropertyName("reward")]
    public Vector3? Reward { get; set; }
    
    /// <summary>
    /// The radius of the event area.
    /// </summary>
    [JsonPropertyName("radius")]
    public int? Radius { get; set; }
    
    /// <summary>
    /// The radius of the spawn area.
    /// </summary>
    [JsonPropertyName("spawnRadius")]
    public int? SpawnRadius { get; set; }
}