using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a requirement for a world event or camp.
/// </summary>
public class WorldEventRequirement
{
    /// <summary>
    /// The type of the requirement.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// The value of the requirement as a JSON element.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; }


    /// <summary>
    /// Returns the requirement value as a string, or null if it is not a string or number.
    /// </summary>
    /// <returns>The value as a string, or null.</returns>
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

    /// <summary>
    /// Returns the requirement value as an integer, or null if it is not a number.
    /// </summary>
    /// <returns>The value as an integer, or null.</returns>
    public int? ValueAsInteger()
    {
        if (Value.ValueKind == JsonValueKind.Number)
            return Value.GetInt32();
        return null;
    }
}