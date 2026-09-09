using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

/// <summary>
/// Represents the custom model data for an item icon.
/// </summary>
public class ItemCustomModel
{
    /// <summary>
    /// The list of range dispatch values for the custom model.
    /// </summary>
    [JsonPropertyName("rangeDispatch")]
    public List<int> RangeDispatch { get; set; } = [];
}
