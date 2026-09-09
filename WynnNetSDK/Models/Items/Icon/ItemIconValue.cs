using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

/// <summary>
/// Represents the value data of an item icon.
/// </summary>
public class ItemIconValue
{
    /// <summary>
    /// The material ID of the icon item.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The display name of the icon item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The custom model data for the icon.
    /// </summary>
    [JsonPropertyName("customModelData")]
    public ItemCustomModel CustomModelData { get; set; } = new();
}
