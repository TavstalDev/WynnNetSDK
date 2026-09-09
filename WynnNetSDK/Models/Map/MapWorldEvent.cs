using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a world event on the Wynncraft map.
/// </summary>
public class MapWorldEvent
{
    /// <summary>
    /// The display name of the world event.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The internal identifier of the world event.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    /// <summary>
    /// The lore description of the world event.
    /// </summary>
    [JsonPropertyName("lore")]
    public string Lore { get; set; } = string.Empty;
    
    /// <summary>
    /// The difficulty of the world event.
    /// </summary>
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }
    
    /// <summary>
    /// The recommended level for the world event.
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    
    /// <summary>
    /// The estimated length or duration of the world event.
    /// </summary>
    [JsonPropertyName("length")]
    public string? Length { get; set; }
    
    /// <summary>
    /// The rewards given per level of the world event.
    /// </summary>
    [JsonPropertyName("rewardPerLevel")]
    public Dictionary<string, List<string>>? RewardPerLevel { get; set; }
    
    /// <summary>
    /// The requirements to participate in the world event.
    /// </summary>
    [JsonPropertyName("requirements")]
    public List<WorldEventRequirement>? Requirements { get; set; }
    
    /// <summary>
    /// The list of locations for the world event.
    /// </summary>
    [JsonPropertyName("location")]
    public List<WorldEventLocation> Location { get; set; } = [];
    
    /// <summary>
    /// The scheduled time of the world event.
    /// </summary>
    [JsonPropertyName("schedule")]
    public DateTime? Schedule { get; set; }
}