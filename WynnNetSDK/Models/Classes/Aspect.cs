using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Represents an aspect that can be applied to a class in Wynncraft.
/// </summary>
public class Aspect
{
    /// <summary>
    /// The display name of the aspect.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The internal identifier of the aspect.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;

    /// <summary>
    /// The icon used to represent this aspect.
    /// </summary>
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();

    /// <summary>
    /// The rarity tier of the aspect.
    /// </summary>
    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = string.Empty;

    /// <summary>
    /// The class required to use this aspect.
    /// </summary>
    [JsonPropertyName("requiredClass")]
    public string RequiredClass { get; set; } = string.Empty;

    /// <summary>
    /// The tier levels of the aspect and their effects.
    /// </summary>
    [JsonPropertyName("tiers")]
    public Dictionary<string, AspectTier> Tiers { get; set; } = [];
}
