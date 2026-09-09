using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a loot pool associated with a camp or raid.
/// </summary>
public class MapLootPool
{
    /// <summary>
    /// The display name of the loot pool.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The internal identifier of the loot pool.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    /// <summary>
    /// The camp type of the loot pool.
    /// </summary>
    [JsonPropertyName("type")]
    public ECampType Type { get; set; }
    
    /// <summary>
    /// The list of rewards in this loot pool.
    /// </summary>
    [JsonPropertyName("rewards")]
    public List<CampReward> Rewards { get; set; } = [];
}