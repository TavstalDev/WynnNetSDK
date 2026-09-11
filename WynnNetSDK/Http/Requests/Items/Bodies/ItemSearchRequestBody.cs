using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Enums;

namespace Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;

/// <summary>
/// The request body for searching items with filters.
/// </summary>
public class ItemSearchRequestBody
{
    /// <summary>
    /// The search query to filter items by name.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The item types to filter by.
    /// </summary>
    [JsonPropertyName("type")]
    public List<EItemType>? Type { get; set; }

    /// <summary>
    /// The item tiers to filter by.
    /// </summary>
    [JsonPropertyName("tier")]
    public List<ETier>? Tier { get; set; }

    /// <summary>
    /// The attack speeds to filter by.
    /// </summary>
    [JsonPropertyName("attackSpeed")]
    public List<EAttackSpeed>? AttackSpeed { get; set; }

    /// <summary>
    /// The level range to filter items by.
    /// </summary>
    [JsonPropertyName("levelRange")]
    public List<int>? LevelRange { get; set; }

    /// <summary>
    /// The gathering professions to filter by.
    /// </summary>
    [JsonPropertyName("professions")]
    public List<EGathering>? Professions { get; set; }

    /// <summary>
    /// The item identifications to filter by.
    /// </summary>
    [JsonPropertyName("identifications")]
    public List<EIdentification>? Identifications { get; set; }

    /// <summary>
    /// The major IDs to filter by.
    /// </summary>
    [JsonPropertyName("majorIds")]
    public List<EMajorId>? MajorIds { get; set; }
}
