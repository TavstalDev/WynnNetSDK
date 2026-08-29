using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

public class ItemCustomModel
{
    [JsonPropertyName("rangeDispatch")]
    public List<int> RangeDispatch { get; set; } = [];
}