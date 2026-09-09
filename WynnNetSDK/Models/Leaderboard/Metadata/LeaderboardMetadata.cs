using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents the base class for leaderboard metadata.
/// </summary>
[JsonConverter(typeof(LeaderboardMetadataDeserializer))]
public abstract class LeaderboardMetadata
{

}
