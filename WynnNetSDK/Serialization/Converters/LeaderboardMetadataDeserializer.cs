using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

public class LeaderboardMetadataDeserializer : JsonConverter<LeaderboardMetadata>
{
    public override LeaderboardMetadata? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var element = doc.RootElement;
        var json = element.GetRawText();

        // Detect type by checking unique properties
        if (element.TryGetProperty("playtime", out _) && element.TryGetProperty("totalLevelXp", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardMetadataTotalLevelXpPlaytime);
            
        if (element.TryGetProperty("xp", out _) && element.TryGetProperty("playtime", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardMetadataXpPlaytime);
            
        if (element.TryGetProperty("playtime", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardMetadataPlaytime);
            
        if (element.TryGetProperty("completions", out _) && element.TryGetProperty("gambits", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardMetadataCompletionsGambits);
            
        if (element.TryGetProperty("season", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardMetadataSeason);
            
        throw new InvalidOperationException("Could not determine metadata type");
    }

    public override void Write(Utf8JsonWriter writer, LeaderboardMetadata value, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }
}