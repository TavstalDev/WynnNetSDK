using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;


[JsonConverter(typeof(LeaderboardEntryDeserializer))]
public abstract class LeaderboardEntry
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}