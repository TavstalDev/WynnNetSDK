using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

/// <summary>
/// Represents a two-dimensional vector with integer components.
/// </summary>
public class Vector2
{
    /// <summary>
    /// The X component of the vector.
    /// </summary>
    [JsonPropertyName("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y component of the vector.
    /// </summary>
    [JsonPropertyName("y")]
    public int Y { get; set; }
}
