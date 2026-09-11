using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

/// <summary>
/// Represents a legacy news article from the old Wynncraft forum system.
/// </summary>
public class LegacyArticle
{
    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The date the article was posted.
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// The URL of the forum thread.
    /// </summary>
    [JsonPropertyName("forumThread")]
    public string ForumThread { get; set; } = string.Empty;

    /// <summary>
    /// The author of the article.
    /// </summary>
    [JsonPropertyName("author")]
    public string Author { get; set; } = string.Empty;

    /// <summary>
    /// The HTML content of the article.
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// The comments on the article.
    /// </summary>
    [JsonPropertyName("comments")]
    public string Comments { get; set; } = string.Empty;
}
