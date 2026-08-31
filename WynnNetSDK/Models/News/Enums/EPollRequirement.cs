using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

public enum EPollRequirement
{
    [JsonPropertyName("highest_level")]
    HIGHEST_LEVEL,
    [JsonPropertyName("account_age")]
    ACCOUNT_AGE,
    [JsonPropertyName("content_completion")]
    CONTENT_COMPLETION
}
