using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Serialization.Converters;

/// <summary>
/// Converts enum values to and from their JSON property names using <see cref="JsonPropertyNameAttribute"/>.
/// </summary>
/// <typeparam name="TEnum">The enum type to convert.</typeparam>
public class JsonPropertyNameStringEnumConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
{
    private readonly Dictionary<string, TEnum> _enumValues;
    private readonly Dictionary<TEnum, string> _enumNames;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonPropertyNameStringEnumConverter{TEnum}"/> class
    /// and builds mappings between enum values and their JSON property names.
    /// </summary>
    public JsonPropertyNameStringEnumConverter()
    {
        _enumValues = new Dictionary<string, TEnum>(StringComparer.OrdinalIgnoreCase);
        _enumNames = new Dictionary<TEnum, string>();

        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var value = (TEnum)field.GetValue(null)!;
            var jsonName = field.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? field.Name;
            _enumValues[jsonName] = value;
            _enumNames[value] = jsonName;
        }
    }

    /// <summary>
    /// Reads and converts the JSON string representation of an enum value to its <typeparamref name="TEnum"/> equivalent.
    /// </summary>
    /// <param name="reader">The UTF-8 JSON reader.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">Serialization options.</param>
    /// <returns>The deserialized enum value.</returns>
    /// <exception cref="JsonException">Thrown when the JSON value is null or cannot be matched to an enum member.</exception>
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var stringValue = reader.GetString();
        if (stringValue == null)
            throw new JsonException($"Null value cannot be converted to {typeof(TEnum).Name}");

        if (_enumValues.TryGetValue(stringValue, out var value))
            return value;

        throw new JsonException($"Value '{stringValue}' cannot be converted to {typeof(TEnum).Name}");
    }

    /// <summary>
    /// Writes the enum value as its JSON property name string.
    /// </summary>
    /// <param name="writer">The UTF-8 JSON writer.</param>
    /// <param name="value">The enum value to serialize.</param>
    /// <param name="options">Serialization options.</param>
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(_enumNames.TryGetValue(value, out var name) ? name : value.ToString());
    }
}
