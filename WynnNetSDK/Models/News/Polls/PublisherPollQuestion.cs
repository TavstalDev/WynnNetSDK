using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News.Polls;

public class PublisherPollQuestion
{
    [JsonPropertyName("answers")]
    public Dictionary<string, string> Answers { get; set; } = [];
    
    [JsonPropertyName("override")]
    public bool Override { get; set; }
    
    [JsonPropertyName("question")]
    public string Question { get; set; } = string.Empty;
    
    [JsonPropertyName("requirements")]
    public List<PollQuestionRequirement> Requirements { get; set; } = [];
}