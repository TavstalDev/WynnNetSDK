using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a camp on the Wynncraft map.
/// </summary>
public class MapCamp
{
    /// <summary>
    /// The display name of the camp.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The internal identifier of the camp.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;

    /// <summary>
    /// The type of the camp.
    /// </summary>
    [JsonPropertyName("type")]
    public ECampType Type { get; set; }

    /// <summary>
    /// The lore description of the camp.
    /// </summary>
    [JsonPropertyName("lore")]
    public string? Lore { get; set; }

    /// <summary>
    /// The difficulty level of the camp.
    /// </summary>
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }

    /// <summary>
    /// The recommended level for the camp.
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }

    /// <summary>
    /// The estimated length or duration of the camp.
    /// </summary>
    [JsonPropertyName("length")]
    public string? Length { get; set; }

    /// <summary>
    /// The requirements to enter the camp.
    /// </summary>
    [JsonPropertyName("requirements")]
    public List<WorldEventRequirement>? Requirements { get; set; }

    /// <summary>
    /// The world coordinates of the camp.
    /// </summary>
    [JsonPropertyName("location")]
    public Vector3? Location { get; set; }

    /// <summary>
    /// The list of rewards for completing the camp.
    /// </summary>
    [JsonPropertyName("rewards")]
    public List<CampReward> Rewards { get; set; } = [];
}
