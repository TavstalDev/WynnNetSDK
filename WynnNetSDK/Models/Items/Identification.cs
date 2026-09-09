using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

/// <summary>
/// Represents an item identification value with min, raw, and max ranges.
/// </summary>
public class Identification
{
    /// <summary>
    /// The minimum value of this identification.
    /// </summary>
    [JsonPropertyName("min")]
    public int Min { get; set; }

    /// <summary>
    /// The raw or base value of this identification.
    /// </summary>
    [JsonPropertyName("raw")]
    public int Raw { get; set; }

    /// <summary>
    /// The maximum value of this identification.
    /// </summary>
    [JsonPropertyName("max")]
    public int Max { get; set; }
}
