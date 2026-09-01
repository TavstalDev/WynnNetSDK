using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Abilities.Responses;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Icon;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Models.Items.Sets;
using Tavstal.WynnNetSDK.Models.Leaderboard;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Models.Map;
using Tavstal.WynnNetSDK.Models.News;
using Tavstal.WynnNetSDK.Models.News.Polls;
using Tavstal.WynnNetSDK.Models.News.Responses;
using Tavstal.WynnNetSDK.Models.Player;
using Tavstal.WynnNetSDK.Models.Player.Responses;
using Tavstal.WynnNetSDK.Models.Recipes;
using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Serialization;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, UseStringEnumConverter = true)]
[JsonSerializable(typeof(ErrorResponse))]
[JsonSerializable(typeof(ItemSearchRequestBody))]
[JsonSerializable(typeof(RecipesSearchRequestBody))]
[JsonSerializable(typeof(Identification))]
[JsonSerializable(typeof(ItemIcon))]
[JsonSerializable(typeof(LeaderboardEntry))]
[JsonSerializable(typeof(LeaderboardGuildEntry))]
[JsonSerializable(typeof(LeaderboardGuildLegacyEntry))]
[JsonSerializable(typeof(LeaderboardPlayerEntry))]
[JsonSerializable(typeof(LeaderboardMetadata))]
[JsonSerializable(typeof(LeaderboardMetadataCompletionsGambits))]
[JsonSerializable(typeof(LeaderboardMetadataPlaytime))]
[JsonSerializable(typeof(LeaderboardMetadataSeason))]
[JsonSerializable(typeof(LeaderboardMetadataTotalLevelXpPlaytime))]
[JsonSerializable(typeof(LeaderboardMetadataXpPlaytime))]
[JsonSerializable(typeof(PublisherPollQuestion))]
[JsonSerializable(typeof(List<string>))]
[JsonSerializable(typeof(Dictionary<string, string>))]
[JsonSerializable(typeof(List<Aspect>))]
[JsonSerializable(typeof(Dictionary<string, List<AbilityNode>>))]
[JsonSerializable(typeof(AbilityTreeResult))]
[JsonSerializable(typeof(Dictionary<string, Class>))]
[JsonSerializable(typeof(ClassDetail))]
[JsonSerializable(typeof(GuildDetailedInfo))]
[JsonSerializable(typeof(Dictionary<string, GuildResult>))]
[JsonSerializable(typeof(Dictionary<string, GuildSeason>))]
[JsonSerializable(typeof(Dictionary<string, GuildTerritory>))]
[JsonSerializable(typeof(ItemResult))]
[JsonSerializable(typeof(Dictionary<string, ItemSet>))]
[JsonSerializable(typeof(List<Item>))]
[JsonSerializable(typeof(ItemMetaResult))]
[JsonSerializable(typeof(ItemMetaStaticResult))]
[JsonSerializable(typeof(List<MapCamp>))]
[JsonSerializable(typeof(List<MapWorldEvent>))]
[JsonSerializable(typeof(List<MapGatherNode>))]
[JsonSerializable(typeof(List<MapLootPool>))]
[JsonSerializable(typeof(List<MapMarker>))]
[JsonSerializable(typeof(List<MapPlayerInfo>))]
[JsonSerializable(typeof(MapQuests))]
[JsonSerializable(typeof(ArticleResult))]
[JsonSerializable(typeof(Article))]
[JsonSerializable(typeof(List<LegacyArticle>))]
[JsonSerializable(typeof(PlayerListOnlineResponse))]
[JsonSerializable(typeof(PlayerDetailedInfo))]
[JsonSerializable(typeof(Dictionary<string, PlayerInfo>))]
[JsonSerializable(typeof(Dictionary<string, PlayerCharacter>))]
[JsonSerializable(typeof(PlayerDetailedCharacter))]
[JsonSerializable(typeof(Dictionary<string, AbilityMap>))]
[JsonSerializable(typeof(RecipeResult))]
[JsonSerializable(typeof(Recipe))]
[JsonSerializable(typeof(Dictionary<string, LeaderboardEntry>))]
[JsonSerializable(typeof(Dictionary<string, List<AbilityMap>>))]
public partial class WynnNetSDKJsonContext : JsonSerializerContext;