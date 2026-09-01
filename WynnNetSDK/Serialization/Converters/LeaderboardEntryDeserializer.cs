using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

public class LeaderboardEntryDeserializer : JsonConverter<LeaderboardEntry>
{
    public override LeaderboardEntry? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var element = doc.RootElement;
        var json = element.GetRawText();
        
        if (element.TryGetProperty("username", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardPlayerEntry);
        
        if (element.TryGetProperty("guildUuid", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardGuildLegacyEntry);
        
        return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardGuildEntry);
    }

    public override void Write(Utf8JsonWriter writer, LeaderboardEntry value, JsonSerializerOptions options)
    {
        throw new NotImplementedException("This converter only supports deserialization");
    }
}
