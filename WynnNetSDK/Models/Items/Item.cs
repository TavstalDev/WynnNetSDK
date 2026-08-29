using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Items;

public class Item
{
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public EItemType Type { get; set; }
    
    [JsonPropertyName("subType")]
    public EItemSubType SubType { get; set; }
    
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();
    
    [JsonPropertyName("emblem")]
    public EEmblem Emblem { get; set; }
    
    [JsonPropertyName("tier")]
    public ETier Tier { get; set; }
    
    [JsonPropertyName("attackSpeed")]
    public EAttackSpeed? AttackSpeed { get; set; }
    
    [JsonPropertyName("averageDps")]
    public double? AverageDps { get; set; }
    
    [JsonPropertyName("restriction")]
    public string? Restriction { get; set; }
    
    [JsonPropertyName("dropRestriction")]
    public string? DropRestriction { get; set; }
    
    [JsonPropertyName("gathering")]
    public EGathering? Gathering { get; set; }
    
    [JsonPropertyName("set")]
    public EItemSet? Set { get; set; }
    
    [JsonPropertyName("elements")]
    public List<string>? Elements { get; set; }
    
    [JsonPropertyName("requirements")]
    public ItemRequirement? Requirements { get; set; }
    
    [JsonPropertyName("majorIds")]
    public Dictionary<string, string>? MajorIds { get; set; }
    
    [JsonPropertyName("powderSlots")]
    public int? PowderSlots { get; set; }
    
    [JsonPropertyName("lore")]
    public string? Lore { get; set; }
    
    [JsonPropertyName("identifications")]
    public Dictionary<string, object>? Identifications { get; set; }
    
    [JsonPropertyName("base")]
    public Dictionary<string, object>? Base { get; set; }

    public Dictionary<string, Identification>? GetIdentifications()
    {
        if (Identifications == null)
            return null;

        var dic = new Dictionary<string, Identification>();
        foreach (var pair in Identifications)
        {
            if (pair.Value is int num)
            {
                dic.Add(pair.Key, new Identification()
                {
                    Min = num,
                    Raw = num,
                    Max = num
                });
                continue;
            }

            if (pair.Value is Identification iden)
                dic.Add(pair.Key, iden);
        }

        return dic;
    }
    
    public Dictionary<string, Identification>? GetBase()
    {
        if (Base == null)
            return null;

        var dic = new Dictionary<string, Identification>();
        foreach (var pair in Base)
        {
            if (pair.Value is int num)
            {
                dic.Add(pair.Key, new Identification()
                {
                    Min = num,
                    Raw = num,
                    Max = num
                });
                continue;
            }

            if (pair.Value is Identification iden)
                dic.Add(pair.Key, iden);
        }

        return dic;
    }
}