using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

/// <summary>
/// Represents the display icon of an item.
/// </summary>
public class ItemIcon
{
    /// <summary>
    /// The name of the icon material.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The format type of the icon.
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; } = string.Empty;

    /// <summary>
    /// The value data of the icon.
    /// </summary>
    [JsonPropertyName("value")]
    public ItemIconValue Value { get; set; } = new();
}
