using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Enums;

namespace Tavstal.WynnNetSDK.Models.News.Polls;

/// <summary>
/// Represents a requirement for a poll question.
/// </summary>
public class PollQuestionRequirement
{
    /// <summary>
    /// The type of the requirement.
    /// </summary>
    [JsonPropertyName("type")]
    public EPollRequirement Type { get; set; }
    
    /// <summary>
    /// The sub type of the requirement, such as a profession or raid.
    /// </summary>
    [JsonPropertyName("subType")]
    public EPollRequirementSubType? SubType { get; set; }
        
    /// <summary>
    /// The required value for the requirement.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}