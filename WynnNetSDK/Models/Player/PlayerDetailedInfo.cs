using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerDetailedInfo
{
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
    
    [JsonPropertyName("online")]
    public bool Online { get; set; }
    
    [JsonPropertyName("server")]
    public string? Server { get; set; }
    
    [JsonPropertyName("activeCharacter")]
    public string? ActiveCharacter { get; set; }
    
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;
    
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;
    
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;
    
    [JsonPropertyName("supportRank")]
    public string SupportRank { get; set; } = string.Empty;
    
    [JsonPropertyName("shortenedRank")]
    public string ShortenedRank { get; set; } = string.Empty;
    
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string> LegacyRankColour { get; set; } = new();
    
    [JsonPropertyName("rankBadge")]
    public string RankBadge { get; set; } = string.Empty;
    
    [JsonPropertyName("veteran")]
    public bool Veteran { get; set; }
    
    [JsonPropertyName("lastJoin")]
    public DateTime LastJoin { get; set; }
    
    [JsonPropertyName("guild")]
    public PlayerGuildInfo? Guild { get; set; }
    
    [JsonPropertyName("ranking")]
    public Dictionary<string, int> Ranking { get; set; } = new();
    
    [JsonPropertyName("previousRanking")]
    public Dictionary<string, int> PreviousRanking { get; set; } = new();
    
    [JsonPropertyName("firstJoin")]
    public DateTime FirstJoin { get; set; }
    
    [JsonPropertyName("playtime")]
    public float Playtime { get; set; }
    
    [JsonPropertyName("globalData")]
    public PlayerGlobalData GlobalData { get; set; } = new();
    
    [JsonPropertyName("featuredStats")]
    [Obsolete("Please use FeaturedStatsAsString().")]
    public Dictionary<string, JsonElement> FeaturedStats { get; set; } = new();
    
    [JsonPropertyName("wallpaper")]
    public string Wallpaper { get; set; } = "default";
    
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; } = "default";
    
    [JsonPropertyName("restrictions")]
    public PlayerDataRestrictions Restrictions { get; set; } = new();
    
    [JsonPropertyName("characters")]
    public Dictionary<string, PlayerDetailedCharacter> Characters { get; set; } = new();

    public Dictionary<string, string> FeaturedStatsAsString()
    {
        Dictionary<string, string> result = [];
        foreach (var elem in FeaturedStats)
        {
            switch (elem.Value.ValueKind)
            {
                case JsonValueKind.String:
                {
                    result[elem.Key] = elem.Value.GetRawText();
                    continue;
                }
                case JsonValueKind.Number:
                {
                    result[elem.Key] = elem.Value.GetInt32().ToString();
                    continue;
                }
            }
        }
        return result;
    }
}