using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

public class LegacyArticle
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;
    
    [JsonPropertyName("forumThread")]
    public string ForumThread { get; set; } = string.Empty;
    
    [JsonPropertyName("author")]
    public string Author { get; set; } = string.Empty;
    
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    
    [JsonPropertyName("comments")]
    public string Comments { get; set; } = string.Empty;
}