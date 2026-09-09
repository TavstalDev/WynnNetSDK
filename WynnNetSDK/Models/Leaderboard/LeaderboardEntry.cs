using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;


/// <summary>
/// Represents a base entry on a leaderboard with a UUID and name.
/// </summary>
[JsonConverter(typeof(LeaderboardEntryDeserializer))]
public abstract class LeaderboardEntry
{
    /// <summary>
    /// The UUID of the leaderboard entry.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// The name of the leaderboard entry.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
