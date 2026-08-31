using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

public class ArticleInfo
{
    [JsonPropertyName("pk")]
    public string Pk { get; set; } = string.Empty;
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public EArticleType Type { get; set; }
    
    [JsonPropertyName("banner")]
    public string Banner { get; set; } = string.Empty;
    
    [JsonPropertyName("banner_zoom")]
    public string BannerZoom { get; set; } = string.Empty;
    
    [JsonPropertyName("recap")]
    public string Recap { get; set; } = string.Empty;
    
    [JsonPropertyName("visible")]
    public bool Visible { get; set; }
    
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }
    
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
    
    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; }
    
    [JsonPropertyName("has_content")]
    public bool HasContent { get; set; }
    
    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }
}