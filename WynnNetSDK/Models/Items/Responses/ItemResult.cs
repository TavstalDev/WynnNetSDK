using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

/// <summary>
/// Represents a paginated response containing item search results.
/// </summary>
public class ItemResult
{
    /// <summary>
    /// The page controller for navigating results.
    /// </summary>
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();

    /// <summary>
    /// The list of items returned by the search.
    /// </summary>
    [JsonPropertyName("results")]
    public List<Item> Results { get; set; } = [];
}
