using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Enums;

namespace Tavstal.WynnNetSDK.Models.News;

/// <summary>
/// Represents summary information about a news article.
/// </summary>
public class ArticleInfo
{
    /// <summary>
    /// The primary key identifier of the article.
    /// </summary>
    [JsonPropertyName("pk")]
    public string Pk { get; set; } = string.Empty;
    
    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// The type of the article.
    /// </summary>
    [JsonPropertyName("type")]
    public EArticleType Type { get; set; }
    
    /// <summary>
    /// The banner image URL of the article.
    /// </summary>
    [JsonPropertyName("banner")]
    public string Banner { get; set; } = string.Empty;
    
    /// <summary>
    /// The banner zoom setting of the article.
    /// </summary>
    [JsonPropertyName("banner_zoom")]
    public string BannerZoom { get; set; } = string.Empty;
    
    /// <summary>
    /// A short recap of the article.
    /// </summary>
    [JsonPropertyName("recap")]
    public string Recap { get; set; } = string.Empty;
    
    /// <summary>
    /// Whether the article is visible.
    /// </summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
    
    /// <summary>
    /// The start date of the article.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }
    
    /// <summary>
    /// The end date of the article, if applicable.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
    
    /// <summary>
    /// Whether the article is pinned.
    /// </summary>
    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; }
    
    /// <summary>
    /// Whether the article has content.
    /// </summary>
    [JsonPropertyName("has_content")]
    public bool HasContent { get; set; }
    
    /// <summary>
    /// The date and time the article was published.
    /// </summary>
    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }
}