using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

public class PollQuestionRequirement
{
    [JsonPropertyName("type")]
    public EPollRequirement Type { get; set; }
    
    [JsonPropertyName("subType")]
    public EPollRequirementSubType SubType { get; set; }
        
    [JsonPropertyName("value")]
    public int Value { get; set; }
}