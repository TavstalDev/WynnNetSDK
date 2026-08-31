using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

public class LeaderboardEntryDeserializer : JsonConverter<Dictionary<string, LeaderboardEntry>>
{
    public override Dictionary<string, LeaderboardEntry> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Dictionary<string, LeaderboardEntry>();
        using var doc = JsonDocument.ParseValue(ref reader);
        foreach (var prop in doc.RootElement.EnumerateObject())
        {
            var entry = DetectAndDeserialize(prop.Value, options);
            if (entry == null)
                continue;
            result[prop.Name] = entry;
        }

        return result;
    }

    private LeaderboardEntry? DetectAndDeserialize(JsonElement element, JsonSerializerOptions options)
    {
        var json = element.GetRawText();
        
        if (element.TryGetProperty("username", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardPlayerEntry);
        
        if (element.TryGetProperty("guildUuid", out _))
            return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardGuildLegacyEntry);
        
        return JsonSerializer.Deserialize(json, WynnNetSDKJsonContext.Default.LeaderboardGuildEntry);
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<string, LeaderboardEntry> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException("This converter only supports deserialization");
    }
}
