using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Enums;
using Tavstal.WynnNetSDK.Models.Items.Icon;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

/// <summary>
/// Represents an item in the Wynncraft database.
/// </summary>
public class Item
{
    /// <summary>
    /// The display name of the item.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    /// <summary>
    /// The internal name used to identify the item.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;

    /// <summary>
    /// The main type of the item.
    /// </summary>
    [JsonPropertyName("type")]
    public EItemType Type { get; set; }

    /// <summary>
    /// The sub type of the item.
    /// </summary>
    [JsonPropertyName("subType")]
    public EItemSubType SubType { get; set; }

    /// <summary>
    /// The display icon of the item.
    /// </summary>
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();

    /// <summary>
    /// The emblem displayed on the item.
    /// </summary>
    [JsonPropertyName("emblem")]
    public EEmblem Emblem { get; set; }

    /// <summary>
    /// The rarity tier of the item.
    /// </summary>
    [JsonPropertyName("tier")]
    public ETier Tier { get; set; }

    /// <summary>
    /// The attack speed of the item.
    /// </summary>
    [JsonPropertyName("attackSpeed")]
    public EAttackSpeed? AttackSpeed { get; set; }

    /// <summary>
    /// The average damage per second of the item.
    /// </summary>
    [JsonPropertyName("averageDps")]
    public double? AverageDps { get; set; }

    /// <summary>
    /// The level restriction for using this item.
    /// </summary>
    [JsonPropertyName("restriction")]
    public string? Restriction { get; set; }

    /// <summary>
    /// The drop restriction for this item.
    /// </summary>
    [JsonPropertyName("dropRestriction")]
    public string? DropRestriction { get; set; }

    /// <summary>
    /// The gathering skill type of this item.
    /// </summary>
    [JsonPropertyName("gathering")]
    public EGathering? Gathering { get; set; }

    /// <summary>
    /// The item set this item belongs to.
    /// </summary>
    [JsonPropertyName("set")]
    public EItemSet? Set { get; set; }

    /// <summary>
    /// The list of elemental types for this item.
    /// </summary>
    [JsonPropertyName("elements")]
    public List<string>? Elements { get; set; }

    /// <summary>
    /// The level and stat requirements to use this item.
    /// </summary>
    [JsonPropertyName("requirements")]
    public ItemRequirement? Requirements { get; set; }

    /// <summary>
    /// The major IDs and their descriptions for this item.
    /// </summary>
    [JsonPropertyName("majorIds")]
    public Dictionary<string, string>? MajorIds { get; set; }

    /// <summary>
    /// The number of powder slots available on this item.
    /// </summary>
    [JsonPropertyName("powderSlots")]
    public int? PowderSlots { get; set; }

    /// <summary>
    /// The lore text displayed on the item.
    /// </summary>
    [JsonPropertyName("lore")]
    public string? Lore { get; set; }

    /// <summary>
    /// The identification values for this item.
    /// </summary>
    [JsonPropertyName("identifications")]
    public Dictionary<string, object>? Identifications { get; set; }

    /// <summary>
    /// The base stat values for this item.
    /// </summary>
    [JsonPropertyName("base")]
    public Dictionary<string, object>? Base { get; set; }

    /// <summary>
    /// Gets the identifications as a dictionary of Identification objects.
    /// </summary>
    /// <returns>A dictionary of identification names and their values, or null if none exist.</returns>
    public Dictionary<string, Identification>? GetIdentifications()
    {
        if (Identifications == null)
            return null;

        var dic = new Dictionary<string, Identification>();
        foreach (var pair in Identifications)
        {
            if (pair.Value is int num)
            {
                dic.Add(pair.Key, new Identification
                {
                    Min = num,
                    Raw = num,
                    Max = num
                });
                continue;
            }

            if (pair.Value is Identification iden)
            {
                dic.Add(pair.Key, iden);
                continue;
            }

            if (pair.Value is JsonElement jsonElem)
            {
                if (jsonElem.ValueKind == JsonValueKind.Number)
                {
                    int jnum = jsonElem.GetInt32();
                    dic.Add(pair.Key, new Identification
                    {
                        Min = jnum,
                        Raw = jnum,
                        Max = jnum
                    });
                    continue;
                }

                if (jsonElem.ValueKind != JsonValueKind.Object)
                    continue;

                var jid = jsonElem.Deserialize(WynnNetSDKJsonContext.Default.Identification);
                if (jid == null)
                    continue;

                dic.Add(pair.Key, jid);
            }
        }

        return dic;
    }

    /// <summary>
    /// Gets the base stats as a dictionary of Identification objects.
    /// </summary>
    /// <returns>A dictionary of base stat names and their values, or null if none exist.</returns>
    public Dictionary<string, Identification>? GetBase()
    {
        if (Base == null)
            return null;

        var dic = new Dictionary<string, Identification>();
        foreach (var pair in Base)
        {
            if (pair.Value is int num)
            {
                dic.Add(pair.Key, new Identification
                {
                    Min = num,
                    Raw = num,
                    Max = num
                });
                continue;
            }

            if (pair.Value is Identification iden)
            {
                dic.Add(pair.Key, iden);
                continue;
            }

            if (pair.Value is JsonElement jsonElem)
            {
                if (jsonElem.ValueKind == JsonValueKind.Number)
                {
                    int jnum = jsonElem.GetInt32();
                    dic.Add(pair.Key, new Identification
                    {
                        Min = jnum,
                        Raw = jnum,
                        Max = jnum
                    });
                    continue;
                }

                if (jsonElem.ValueKind != JsonValueKind.Object)
                    continue;

                var jid = jsonElem.Deserialize(WynnNetSDKJsonContext.Default.Identification);
                if (jid == null)
                    continue;

                dic.Add(pair.Key, jid);
            }
        }

        return dic;
    }
}
