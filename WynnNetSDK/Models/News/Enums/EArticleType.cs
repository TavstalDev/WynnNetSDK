using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

public enum EArticleType
{
    [JsonPropertyName("blog")]
    BLOG,
    [JsonPropertyName("event")]
    EVENT,
    [JsonPropertyName("giveaway")]
    GIVEAWAY,
    [JsonPropertyName("article")]
    ARTICLE,
    [JsonPropertyName("poll")]
    POLL
}
