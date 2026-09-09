using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Territory;

/// <summary>
/// Represents a resource produced by a guild territory.
/// </summary>
public class TerritoryResource
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    [JsonPropertyName("type")]
    public ETerritoryResourceType Type { get; set; }

    /// <summary>
    /// The amount of resource generated per cycle.
    /// </summary>
    [JsonPropertyName("generation")]
    public int Generation { get; set; }

    /// <summary>
    /// The amount of resource currently stored.
    /// </summary>
    [JsonPropertyName("stored")]
    public int Stored { get; set; }

    /// <summary>
    /// The maximum amount of resource that can be stored.
    /// </summary>
    [JsonPropertyName("limit")]
    public int Limit { get; set; }
}