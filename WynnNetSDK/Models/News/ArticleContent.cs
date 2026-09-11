using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Polls;
using Tavstal.WynnNetSDK.Serialization;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.News;

/// <summary>
/// Represents a content block within a news article.
/// </summary>
public class ArticleContent
{
    /// <summary>
    /// The unique identifier of the content block.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The type of the content block.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Whether this content block is the focus element.
    /// </summary>
    [JsonPropertyName("focus")]
    public bool Focus { get; set; }

    /// <summary>
    /// The raw JSON content. Use ContentAsString() or ContentAsPoll() instead.
    /// </summary>
    [JsonPropertyName("content")]
    [Obsolete("Please use ContentAsString() or ContentAsPoll() instead.")]
    public JsonElement Content { get; set; } = new();

    /// <summary>
    /// Whether this content block is shown on Discord.
    /// </summary>
    [JsonPropertyName("discord")]
    public bool Discord { get; set; }

    /// <summary>
    /// Whether this content block is shown on the website.
    /// </summary>
    [JsonPropertyName("website")]
    public bool Website { get; set; }

    /// <summary>
    /// Returns the content as a string, or null if it is not a string.
    /// </summary>
    /// <returns>The content as a string, or null.</returns>
    public string? ContentAsString()
    {
        if (Content.ValueKind != JsonValueKind.String)
            return null;
        return Content.GetString();
    }

    /// <summary>
    /// Returns the content as a poll question, or null if it is not an object.
    /// </summary>
    /// <returns>The content as a PublisherPollQuestion, or null.</returns>
    public PublisherPollQuestion? ContentAsPoll()
    {
        if (Content.ValueKind != JsonValueKind.Object)
            return null;
        return Content.Deserialize(WynnSdkJsonContext.Default.PublisherPollQuestion);
    }
}
