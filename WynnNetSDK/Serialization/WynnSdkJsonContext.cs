using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Icon;
using Tavstal.WynnNetSDK.Models.Leaderboard;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Models.News;
using Tavstal.WynnNetSDK.Models.News.Polls;

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
public partial class WynnNetSDKJsonContext : JsonSerializerContext;