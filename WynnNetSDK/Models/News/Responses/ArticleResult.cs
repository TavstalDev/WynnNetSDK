using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.News.Responses;

/// <summary>
/// Represents the API response containing a list of articles.
/// </summary>
public class ArticleResult
{
    /// <summary>
    /// The pagination controller for the results.
    /// </summary>
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();
    
    /// <summary>
    /// The dictionary of article information keyed by article identifier.
    /// </summary>
    [JsonPropertyName("results")]
    public Dictionary<string, ArticleInfo> Results { get; set; } = [];
}