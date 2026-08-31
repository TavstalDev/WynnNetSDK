using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Enums;

namespace Tavstal.WynnNetSDK.Models.News.Polls;

public class PollQuestionRequirement
{
    [JsonPropertyName("type")]
    public EPollRequirement Type { get; set; }
    
    [JsonPropertyName("subType")]
    public EPollRequirementSubType SubType { get; set; }
        
    [JsonPropertyName("value")]
    public int Value { get; set; }
}