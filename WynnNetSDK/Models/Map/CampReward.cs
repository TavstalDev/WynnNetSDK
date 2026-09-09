using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a reward from a camp or raid.
/// </summary>
public class CampReward
{
    /// <summary>
    /// The name of the reward.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The type of the reward.
    /// </summary>
    [JsonPropertyName("type")]
    public ECampReward Type { get; set; }
    
    /// <summary>
    /// The amount of the reward.
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
    
    /// <summary>
    /// Whether the reward is always given.
    /// </summary>
    [JsonPropertyName("always")]
    public bool Always { get; set; }
    
    /// <summary>
    /// The tier of the reward, if applicable.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
    
    /// <summary>
    /// Whether the reward is a shiny variant.
    /// </summary>
    [JsonPropertyName("shiny")]
    public bool Shiny { get; set; }
}