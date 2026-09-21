using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

/// <summary>
/// The type of requirement for a poll question.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EPollRequirement>))]
public enum EPollRequirement
{
    /// <summary>
    /// Requires a minimum highest character level.
    /// </summary>
    [JsonPropertyName("highest_level")]
    HIGHEST_LEVEL,
    /// <summary>
    /// Requires a minimum account age.
    /// </summary>
    [JsonPropertyName("account_age")]
    ACCOUNT_AGE,
    /// <summary>
    /// Requires completion of specific content.
    /// </summary>
    [JsonPropertyName("content_completion")]
    CONTENT_COMPLETION
}
