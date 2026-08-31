using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

public class Article
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("type")]
    public EArticleType Type { get; set; }
    
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; } = string.Empty;
    
    [JsonPropertyName("discord_messages")]
    public Dictionary<string, string> DiscordMessages { get; set; } = [];
    
    [JsonPropertyName("discord_recap")]
    public bool DiscordRecap { get; set; }
    
    [JsonPropertyName("allow_discord")]
    public bool AllowDiscord { get; set; }
    
    [JsonPropertyName("destination")]
    public string Destination { get; set; } = string.Empty;
    
    [JsonPropertyName("published")]
    public bool Published { get; set; }
    
    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; }
    
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
    
    [JsonPropertyName("content")]
    public List<ArticleContent> Content { get; set; } = [];
    
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }
    
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
    
    [JsonPropertyName("recap")]
    public string Recap { get; set; } = string.Empty;
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    [JsonPropertyName("banner")]
    public string Banner { get; set; } = string.Empty;
    
    [JsonPropertyName("banner_zoom")]
    public string BannerZoom { get; set; } = string.Empty;
    
    [JsonPropertyName("likes")]
    public int Likes { get; set; }
    
    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }
    
    [JsonPropertyName("require_discord")]
    public bool RequireDiscord { get; set; }
    
    [JsonPropertyName("require_clan")]
    public bool RequireClan { get; set; }
    
    [JsonPropertyName("poll_settings")]
    public List<PollQuestionRequirement>? PollSettings { get; set; }
    
    [JsonPropertyName("poll_public")]
    public bool? PollPublic { get; set; }
    
    [JsonPropertyName("votes")]
    public Dictionary<string, int>? Votes { get; set; }
}