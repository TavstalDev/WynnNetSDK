using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

/// <summary>
/// Provides pagination information for paged API responses.
/// </summary>
public class PageController
{
    /// <summary>
    /// The total number of items across all pages.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// The number of items on the current page.
    /// </summary>
    [JsonPropertyName("current_count")]
    public int CurrentCount { get; set; }

    /// <summary>
    /// The total number of pages available.
    /// </summary>
    [JsonPropertyName("pages")]
    public int Pages { get; set; }

    /// <summary>
    /// The previous page number, or null if on the first page.
    /// </summary>
    [JsonPropertyName("prev")]
    public int? Prev { get; set; }

    /// <summary>
    /// The current page number.
    /// </summary>
    [JsonPropertyName("current")]
    public int Current { get; set; }

    /// <summary>
    /// The next page number, or null if on the last page.
    /// </summary>
    [JsonPropertyName("next")]
    public int? Next { get; set; }
}