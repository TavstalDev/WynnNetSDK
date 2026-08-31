using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

[JsonConverter(typeof(LeaderboardMetadataDeserializer))]
public abstract class LeaderboardMetadata
{
    
}