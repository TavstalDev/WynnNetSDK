using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Territory;

/// <summary>
/// Represents the start and end coordinates of a territory.
/// </summary>
public class TerritoryLocation
{
    /// <summary>
    /// The starting coordinates of the territory boundary.
    /// </summary>
    [JsonPropertyName("start")]
    public List<int> Start { get; set; } = [];

    /// <summary>
    /// The ending coordinates of the territory boundary.
    /// </summary>
    [JsonPropertyName("end")]
    public List<int> End { get; set; } = [];
}