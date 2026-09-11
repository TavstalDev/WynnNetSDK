using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

/// <summary>
/// Represents the filter options available for item metadata queries.
/// </summary>
public class ItemMetaFilters
{
    /// <summary>
    /// The list of available item types.
    /// </summary>
    [JsonPropertyName("type")]
    public List<string> Type { get; set; } = [];

    /// <summary>
    /// The advanced filter options grouped by category.
    /// </summary>
    [JsonPropertyName("advanced")]
    public Dictionary<string, List<string>> Advanced { get; set; } = [];

    /// <summary>
    /// The available tier filter options grouped by category.
    /// </summary>
    [JsonPropertyName("tier")]
    public Dictionary<string, List<string>> Tier { get; set; } = [];

    /// <summary>
    /// The list of available identification filters.
    /// </summary>
    [JsonPropertyName("identifications")]
    public List<string> Identifications { get; set; } = [];

    /// <summary>
    /// The list of available major ID filters.
    /// </summary>
    [JsonPropertyName("majorIds")]
    public List<string> MajorIds { get; set; } = [];

    /// <summary>
    /// The available level range filter values.
    /// </summary>
    [JsonPropertyName("levelRange")]
    public List<int> LevelRange { get; set; } = [];
}
