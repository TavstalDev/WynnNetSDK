using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News.Polls;

/// <summary>
/// Represents a poll question published in a news article.
/// </summary>
public class PublisherPollQuestion
{
    /// <summary>
    /// The available answers for the poll question.
    /// </summary>
    [JsonPropertyName("answers")]
    public Dictionary<string, string> Answers { get; set; } = [];

    /// <summary>
    /// Whether the poll settings override previous settings.
    /// </summary>
    [JsonPropertyName("override")]
    public bool Override { get; set; }

    /// <summary>
    /// The text of the poll question.
    /// </summary>
    [JsonPropertyName("question")]
    public string Question { get; set; } = string.Empty;

    /// <summary>
    /// The requirements to participate in the poll.
    /// </summary>
    [JsonPropertyName("requirements")]
    public List<PollQuestionRequirement> Requirements { get; set; } = [];
}
