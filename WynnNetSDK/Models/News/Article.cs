using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Enums;
using Tavstal.WynnNetSDK.Models.News.Polls;

namespace Tavstal.WynnNetSDK.Models.News;

/// <summary>
/// Represents a news article from the Wynncraft API.
/// </summary>
public class Article
{
    /// <summary>
    /// The unique identifier of the article.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The type of the article.
    /// </summary>
    [JsonPropertyName("type")]
    public EArticleType Type { get; set; }

    /// <summary>
    /// The username of the article author.
    /// </summary>
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; } = string.Empty;

    /// <summary>
    /// The Discord messages associated with the article.
    /// </summary>
    [JsonPropertyName("discord_messages")]
    public Dictionary<string, string> DiscordMessages { get; set; } = [];

    /// <summary>
    /// Whether the article has a Discord recap.
    /// </summary>
    [JsonPropertyName("discord_recap")]
    public bool DiscordRecap { get; set; }

    /// <summary>
    /// Whether Discord posting is allowed for this article.
    /// </summary>
    [JsonPropertyName("allow_discord")]
    public bool AllowDiscord { get; set; }

    /// <summary>
    /// The destination URL of the article.
    /// </summary>
    [JsonPropertyName("destination")]
    public string Destination { get; set; } = string.Empty;

    /// <summary>
    /// Whether the article is published.
    /// </summary>
    [JsonPropertyName("published")]
    public bool Published { get; set; }

    /// <summary>
    /// Whether the article is pinned.
    /// </summary>
    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; }

    /// <summary>
    /// Whether the article is visible.
    /// </summary>
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }

    /// <summary>
    /// The content blocks of the article.
    /// </summary>
    [JsonPropertyName("content")]
    public List<ArticleContent> Content { get; set; } = [];

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
    /// A short recap of the article.
    /// </summary>
    [JsonPropertyName("recap")]
    public string Recap { get; set; } = string.Empty;

    /// <summary>
    /// The title of the article.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The banner image URL of the article.
    /// </summary>
    [JsonPropertyName("banner")]
    public string Banner { get; set; } = string.Empty;

    /// <summary>
    /// Whether the banner image should be zoomed.
    /// </summary>
    [JsonPropertyName("banner_zoom")]
    public bool BannerZoom { get; set; }

    /// <summary>
    /// The number of likes on the article.
    /// </summary>
    [JsonPropertyName("likes")]
    public int Likes { get; set; }

    /// <summary>
    /// The date and time the article was published.
    /// </summary>
    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }

    /// <summary>
    /// Whether a Discord account is required to interact with the article.
    /// </summary>
    [JsonPropertyName("require_discord")]
    public bool RequireDiscord { get; set; }

    /// <summary>
    /// Whether a clan membership is required to interact with the article.
    /// </summary>
    [JsonPropertyName("require_clan")]
    public bool RequireClan { get; set; }

    /// <summary>
    /// The poll question requirements for the article.
    /// </summary>
    [JsonPropertyName("poll_settings")]
    public List<PollQuestionRequirement>? PollSettings { get; set; }

    /// <summary>
    /// Whether the poll results are public.
    /// </summary>
    [JsonPropertyName("poll_public")]
    public bool? PollPublic { get; set; }

    /// <summary>
    /// The vote data for the article.
    /// </summary>
    [JsonPropertyName("votes")]
    public Dictionary<string, JsonElement>? Votes { get; set; }

    /// <summary>
    /// Returns the total vote count, or null if no votes exist.
    /// </summary>
    /// <returns>The total vote count, or null.</returns>
    public int? GetVoteCount()
    {
        if (Votes == null)
            return null;
        if (!Votes.TryGetValue("total", out var vote))
            return null;
        if (vote.ValueKind != JsonValueKind.Number)
            return null;
        return vote.GetInt32();
    }
}
