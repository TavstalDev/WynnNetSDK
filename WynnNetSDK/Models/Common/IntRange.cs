using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

/// <summary>
/// Represents a range of integer values with a minimum and maximum.
/// </summary>
public class IntRange
{
    /// <summary>
    /// The minimum value of the range.
    /// </summary>
    [JsonPropertyName("minimum")]
    public int Minimum { get; set; }

    /// <summary>
    /// The maximum value of the range.
    /// </summary>
    [JsonPropertyName("maximum")]
    public int Maximum { get; set; }
}