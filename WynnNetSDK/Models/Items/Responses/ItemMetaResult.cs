using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

/// <summary>
/// Represents the metadata response for item queries, including filters and static data.
/// </summary>
public class ItemMetaResult
{
    /// <summary>
    /// The available filter options for item queries.
    /// </summary>
    [JsonPropertyName("filters")]
    public ItemMetaFilters Filters { get; set; } = new();

    /// <summary>
    /// The static metadata mapping names to occurrence counts.
    /// </summary>
    [JsonPropertyName("static")]
    public Dictionary<string, int> Static { get; set; } = [];
}
