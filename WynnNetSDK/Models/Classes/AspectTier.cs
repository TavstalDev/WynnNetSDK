using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Represents a tier level of an aspect.
/// </summary>
public class AspectTier
{
    /// <summary>
    /// The point threshold required to reach this tier.
    /// </summary>
    [JsonPropertyName("threshold")]
    public int Threshold { get; set; }

    /// <summary>
    /// The description lines explaining this tier's effects.
    /// </summary>
    [JsonPropertyName("description")]
    public List<string> Description { get; set; } = [];
}
