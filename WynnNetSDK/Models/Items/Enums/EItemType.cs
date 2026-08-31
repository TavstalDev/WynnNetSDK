using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

public enum EItemType
{
    [JsonPropertyName("weapon")]
    WEAPON,
    [JsonPropertyName("armour")]
    ARMOUR,
    [JsonPropertyName("accessory")]
    ACCESSORY,
    [JsonPropertyName("charm")]
    CHARM,
    [JsonPropertyName("tome")]
    TOME,
    [JsonPropertyName("tool")]
    TOOL,
    [JsonPropertyName("material")]
    MATERIAL,
    [JsonPropertyName("ingredient")]
    INGREDIENT
}
