using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

/// <summary>
/// The type of a news article.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EArticleType>))]
public enum EArticleType
{
    /// <summary>
    /// A blog post.
    /// </summary>
    [JsonPropertyName("blog")]
    BLOG,
    /// <summary>
    /// An event announcement.
    /// </summary>
    [JsonPropertyName("event")]
    EVENT,
    /// <summary>
    /// A giveaway post.
    /// </summary>
    [JsonPropertyName("giveaway")]
    GIVEAWAY,
    /// <summary>
    /// A standard article.
    /// </summary>
    [JsonPropertyName("article")]
    ARTICLE,
    /// <summary>
    /// A poll article.
    /// </summary>
    [JsonPropertyName("poll")]
    POLL
}
