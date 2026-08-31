using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

public class WorldEventRequirement
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; }


    public string? ValueAsString()
    {
        switch (Value.ValueKind)
        {
            case JsonValueKind.String:
                return Value.GetString();
            case JsonValueKind.Number:
                return Value.GetRawText();
        }
        return null;
    }

    public int? ValueAsInteger()
    {
        if (Value.ValueKind == JsonValueKind.Number)
            return Value.GetInt32();
        return null;
    }
}