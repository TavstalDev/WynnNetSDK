using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild.Territory;

namespace Tavstal.WynnNetSDK.Models.Guild;

/// <summary>
/// Represents a territory owned by a guild.
/// </summary>
public class GuildTerritory
{
    /// <summary>
    /// The guild that owns this territory.
    /// </summary>
    [JsonPropertyName("guild")]
    public GuildInfo Guild { get; set; } = new();

    /// <summary>
    /// The date and time the territory was acquired.
    /// </summary>
    [JsonPropertyName("acquired")]
    public DateTime Acquired { get; set; }

    /// <summary>
    /// Whether this territory is the guild's headquarters.
    /// </summary>
    [JsonPropertyName("hq")]
    public bool IsHeadquarters { get; set; }

    /// <summary>
    /// The resources produced by this territory.
    /// </summary>
    [JsonPropertyName("resources")]
    public List<TerritoryResource> Resources { get; set; } = [];

    /// <summary>
    /// The territories connected to this territory.
    /// </summary>
    [JsonPropertyName("links")]
    public List<string> Links { get; set; } = [];

    /// <summary>
    /// The treasury scale level of this territory.
    /// </summary>
    [JsonPropertyName("treasury")]
    public EScaleLevel Treasury { get; set; }

    /// <summary>
    /// The defence scale level of this territory.
    /// </summary>
    [JsonPropertyName("defences")]
    public EScaleLevel Defences { get; set; }

    /// <summary>
    /// The location boundaries of this territory.
    /// </summary>
    [JsonPropertyName("location")]
    public TerritoryLocation Location { get; set; } = new();
}