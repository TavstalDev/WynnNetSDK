using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

/// <summary>
/// Converts leaderboard metadata from JSON by detecting the metadata type from its properties.
/// </summary>
public class LeaderboardMetadataDeserializer : JsonConverter<LeaderboardMetadata>
{
    /// <summary>
    /// Reads and deserializes leaderboard metadata from JSON, detecting the correct subtype.
    /// </summary>
    /// <param name="reader">The JSON reader.</param>
    /// <param name="typeToConvert">The type to convert to.</param>
    /// <param name="options">The serializer options.</param>
    /// <returns>The deserialized leaderboard metadata.</returns>
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

    /// <summary>
    /// Writes leaderboard metadata to JSON. This operation is not supported.
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="options">The serializer options.</param>
    public override void Write(Utf8JsonWriter writer, LeaderboardMetadata value, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }
}