using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

/// <summary>
/// Converts leaderboard entries from JSON by detecting the entry type from its properties.
/// </summary>
public class LeaderboardEntryDeserializer : JsonConverter<LeaderboardEntry>
{
    /// <summary>
    /// Reads and deserializes a leaderboard entry from JSON, detecting the correct subtype.
    /// </summary>
    /// <param name="reader">The JSON reader.</param>
    /// <param name="typeToConvert">The type to convert to.</param>
    /// <param name="options">The serializer options.</param>
    /// <returns>The deserialized leaderboard entry, or null if the JSON is empty.</returns>
    public override LeaderboardEntry? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var element = doc.RootElement;
        var json = element.GetRawText();

        if (element.TryGetProperty("username", out _))
            return JsonSerializer.Deserialize(json, WynnSdkJsonContext.Default.LeaderboardPlayerEntry);

        if (element.TryGetProperty("guildUuid", out _))
            return JsonSerializer.Deserialize(json, WynnSdkJsonContext.Default.LeaderboardGuildLegacyEntry);

        return JsonSerializer.Deserialize(json, WynnSdkJsonContext.Default.LeaderboardGuildEntry);
    }

    /// <summary>
    /// Writes a leaderboard entry to JSON. This operation is not supported.
    /// </summary>
    /// <param name="writer">The JSON writer.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="options">The serializer options.</param>
    public override void Write(Utf8JsonWriter writer, LeaderboardEntry value, JsonSerializerOptions options)
    {
        throw new NotImplementedException("This converter only supports deserialization");
    }
}
