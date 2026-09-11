using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

/// <summary>
/// Represents a three-dimensional vector with double-precision components.
/// </summary>
public class Vector3
{
    /// <summary>
    /// The X component of the vector.
    /// </summary>
    [JsonPropertyName("x")]
    public double X { get; set; }

    /// <summary>
    /// The Y component of the vector.
    /// </summary>
    [JsonPropertyName("y")]
    public double Y { get; set; }

    /// <summary>
    /// The Z component of the vector.
    /// </summary>
    [JsonPropertyName("z")]
    public double Z { get; set; }
}
