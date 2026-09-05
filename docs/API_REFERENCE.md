# WynnNetSDK API Reference

This page describes every client, its methods, the parameters and the types they return.

All methods are **async** and return a `Result<T, ErrorResponse>`.

---

## Table of contents

- [Getting started](#getting-started)
- [Clients](#clients)
  - [AbilityClient](#abilityclient)
  - [ClassesClient](#classesclient)
  - [GuildClient](#guildclient)
  - [ItemsClient](#itemsclient)
  - [LeaderboardClient](#leaderboardclient)
  - [MapClient](#mapclient)
  - [NewsClient](#newsclient)
  - [PlayerClient](#playerclient)
  - [RecipesClient](#recipesclient)
  - [SearchClient](#searchclient)
- [Core types](#core-types)
  - [Result&lt;T, TError&gt;](#resultt-terror)
  - [ErrorResponse](#errorresponse)
  - [Enums](#enums)
  - [Request body types](#request-body-types)
- [Caching table](#caching-table)

---

## Getting started

```csharp
using Tavstal.WynnNetSDK.Http;

var client = new WynnHttpClient(new WynnEnvironment(token: "YOUR_API_TOKEN"));
```

The token is required: the `WynnEnvironment` constructor rejects empty tokens. The token is also sent
as a `Bearer` authorization header on every request.

The `WynnHttpClient` gives you one property for each area of the API:

`Ability`, `Classes`, `Guild`, `Items`, `Leaderboard`, `Map`, `News`, `Player`, `Recipes`, `Search`.

You can also implement `IWynnHttpClient` if you want full control. The `WynnHttpClient` also
implements `IDisposable`, so remember to dispose it when you are done.

> **Cache durations:** each method below shows a "Cache" value. This is how long the SDK keeps the
> response in memory **if you passed an `ICacheManager`**. Without a cache manager, every call makes
> a real HTTP request.

---

## Clients

### AbilityClient

`client.Ability`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `GetClassTreeAsync` | `EClass @class`, `CancellationToken?` | `Result<AbilityTreeResult, ErrorResponse>` | 1 hour |
| `GetClassTreeMapAsync` | `EClass @class`, `CancellationToken?` | `Result<Dictionary<string, List<AbilityNode>>, ErrorResponse>` | 1 hour |
| `GetClassAspectsAsync` | `EClass @class`, `CancellationToken?` | `Result<List<Aspect>, ErrorResponse>` | 1 hour |

```csharp
var tree = await client.Ability.GetClassTreeAsync(EClass.MAGE);
```

---

### ClassesClient

`client.Classes`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListAsync` | `CancellationToken?` | `Result<Dictionary<string, Class>, ErrorResponse>` | 1 hour |
| `GetAsync` | `EClass @class`, `CancellationToken?` | `Result<ClassDetail, ErrorResponse>` | 1 hour |

```csharp
var classes = await client.Classes.ListAsync();
```

---

### GuildClient

`client.Guild`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `GetByNameAsync` | `string query`, `CancellationToken?` | `Result<GuildDetailedInfo, ErrorResponse>` | 2 minutes |
| `GetByUuidAsync` | `string query`, `CancellationToken?` | `Result<GuildDetailedInfo, ErrorResponse>` | 2 minutes |
| `GetByPrefixAsync` | `string query`, `CancellationToken?` | `Result<GuildDetailedInfo, ErrorResponse>` | 2 minutes |
| `ListAsync` | `EIdentifier? identifier`, `CancellationToken?` | `Result<Dictionary<string, GuildResult>, ErrorResponse>` | 1 hour |
| `ListSeasonsAsync` | `CancellationToken?` | `Result<Dictionary<string, GuildSeason>, ErrorResponse>` | 10 minutes |
| `ListTerritoriesAsync` | `CancellationToken?` | `Result<Dictionary<string, GuildTerritory>, ErrorResponse>` | 10 seconds |

```csharp
var guild = await client.Guild.GetByNameAsync("Tavstal");
```

> The `query` for guilds can be a name, a UUID, or a tag, depending on which method you call.

---

### ItemsClient

`client.Items`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListAsync` | `int? page`, `bool? fullResult`, `CancellationToken?` | `Result<ItemResult, ErrorResponse>` | 1 hour |
| `ListSetsAsync` | `CancellationToken?` | `Result<Dictionary<string, ItemSet>, ErrorResponse>` | 2 minutes |
| `QuickSearchAsync` | `string query`, `CancellationToken?` | `Result<List<Item>, ErrorResponse>` | 1 hour |
| `SearchAsync` | `ItemSearchRequestBody requestBody`, `int? page`, `bool? fullResult`, `CancellationToken?` | `Result<ItemResult, ErrorResponse>` | 1 hour |
| `GetMetadataAsync` | `CancellationToken?` | `Result<ItemMetaResult, ErrorResponse>` | 3 minutes |
| `GetStaticMetadataAsync` | `CancellationToken?` | `Result<ItemMetaStaticResult, ErrorResponse>` | 3 minutes |

```csharp
var items = await client.Items.ListAsync(page: 1, fullResult: true);
```

---

### LeaderboardClient

`client.Leaderboard`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListTypesAsync` | `CancellationToken?` | `Result<List<string>, ErrorResponse>` | 10 minutes |
| `GetAsync` | `string leaderboardType`, `int resultLimit = 100`, `CancellationToken?` | `Result<Dictionary<string, LeaderboardEntry>, ErrorResponse>` | 10 minutes |

```csharp
var types = await client.Leaderboard.ListTypesAsync();
var ranking = await client.Leaderboard.GetAsync("player_guild", resultLimit: 50);
```

---

### MapClient

`client.Map`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListCampsAsync` | `int? level`, `CancellationToken?` | `Result<List<MapCamp>, ErrorResponse>` | 1 minute |
| `ListEventsAsync` | `CancellationToken?` | `Result<List<MapWorldEvent>, ErrorResponse>` | 2 minutes |
| `ListGatheringNodesAsync` | `CancellationToken?` | `Result<List<MapGatherNode>, ErrorResponse>` | 1 hour |
| `ListLootPoolsAsync` | `int? level`, `CancellationToken?` | `Result<List<MapLootPool>, ErrorResponse>` | 2 minutes |
| `ListMarkersAsync` | `CancellationToken?` | `Result<List<MapMarker>, ErrorResponse>` | 1 hour |
| `ListPlayerLocationsAsync` | `CancellationToken?` | `Result<List<MapPlayerInfo>, ErrorResponse>` | 15 seconds |
| `ListQuestsAsync` | `CancellationToken?` | `Result<MapQuests, ErrorResponse>` | 1 hour |
| `ListRaidsAsync` | `int? level`, `CancellationToken?` | `Result<List<MapCamp>, ErrorResponse>` | 1 minute |

```csharp
var playerLocations = await client.Map.ListPlayerLocationsAsync();
```

---

### NewsClient

`client.News`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListAsync` | `EArticleType type`, `int? page`, `CancellationToken?` | `Result<ArticleResult, ErrorResponse>` | 2 minutes |
| `FetchAsync` | `EArticleType type`, `string pk`, `CancellationToken?` | `Result<Article, ErrorResponse>` | 2 minutes |
| `GetLegacyAsync` | `CancellationToken?` | `Result<List<LegacyArticle>, ErrorResponse>` | 60 minutes |
| `ListVideosAsync` | `CancellationToken?` | `Result<Dictionary<string, string>, ErrorResponse>` | 2 minutes |

```csharp
var articles = await client.News.ListAsync(EArticleType.BLOG, page: 1);
```

---

### PlayerClient

`client.Player`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListOnlineAsync` | `EIdentifier? identifier`, `string? server`, `CancellationToken?` | `Result<PlayerListOnlineResponse, ErrorResponse>` | 30 seconds |
| `ListOnlineAsync` | `EIdentifier? identifier`, `int? server`, `CancellationToken?` | `Result<PlayerListOnlineResponse, ErrorResponse>` | 30 seconds |
| `GetProfileAsync` | `string username`, `CancellationToken?` | `Result<PlayerDetailedInfo, ErrorResponse>` | 2 minutes |
| `WhoAmIAsync` | `CancellationToken?` | `Result<Dictionary<string, PlayerInfo>, ErrorResponse>` | no cache |
| `ListCharactersAsync` | `string username`, `CancellationToken?` | `Result<Dictionary<string, PlayerCharacter>, ErrorResponse>` | 2 minutes |
| `GetCharacterAsync` | `string username`, `string uuid`, `CancellationToken?` | `Result<PlayerDetailedCharacter, ErrorResponse>` | 2 minutes |
| `GetAbilityMapAsync` | `string username`, `string uuid`, `CancellationToken?` | `Result<Dictionary<string, List<AbilityMap>>, ErrorResponse>` | 10 minutes |

```csharp
var profile = await client.Player.GetProfileAsync("Tavstal");
```

> `WhoAmIAsync` requires a valid API token. Without a token the endpoint usually returns an error.

---

### RecipesClient

`client.Recipes`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `ListAsync` | `int? page`, `bool? fullResult`, `CancellationToken?` | `Result<RecipeResult, ErrorResponse>` | 1 hour |
| `SearchAsync` | `RecipesSearchRequestBody requestBody`, `int? page`, `bool? fullResult`, `CancellationToken?` | `Result<RecipeResult, ErrorResponse>` | 1 hour |

```csharp
var recipes = await client.Recipes.ListAsync(page: 1, fullResult: true);
```

---

### SearchClient

`client.Search`

| Method | Parameters | Returns | Cache |
|---|---|---|---|
| `SearchAsync` | `string query`, `bool onlyOneResult = false`, `CancellationToken?` | `Result<SearchResult, ErrorResponse>` | 10 minutes |

```csharp
var search = await client.Search.SearchAsync("Tavstal", onlyOneResult: true);
```

---

## Core types

### Result&lt;T, TError&gt;

`Result<T, ErrorResponse>` is the return type of every method.

| Member | Type | Description |
|---|---|---|
| `IsSuccess` | `bool` | `true` if the request worked and `Value` is available. |
| `IsError` | `bool` | `true` if the request failed and `Error` is available. |
| `Value` | `T?` | The data returned by the API. |
| `Error` | `TError?` | The error returned by the API. |
| `Match(onSuccess, onFailure)` | `TResult` | Runs one of the two callbacks and returns its result. |
| `Switch(onSuccess, onFailure)` | `void` | Runs one of the two callbacks. |

```csharp
result.Match(
    onSuccess: value => $"OK: {value}",
    onFailure: error => $"Failed: {error.Message}"
);
```

### ErrorResponse

`ErrorResponse` is the error type returned by the API.

| Property | Type | Description |
|---|---|---|
| `Name` | `string` | Short error name. |
| `Message` | `string` | Human-readable description of the error. |
| `Code` | `int` | Error code returned by the API (defaults to `-1` when missing). |
| `Objects` | `Dictionary<string, object>?` | Extra details about the error, when available. |

### RateLimitException

`RateLimitException` is thrown (not returned) when you run out of requests per minute.

| Property | Type | Description |
|---|---|---|
| `AvailableAt` | `DateTime` | When the rate limit resets and you can call the API again. |

### Enums

Common enums used across methods:

| Enum | Values |
|---|---|
| `EIdentifier` | `NAME`, `UUID` |
| `EClass` | `ARCHER`, `WARRIOR`, `ASSASSIN`, `MAGE`, `SHAMAN` |
| `EArticleType` | `BLOG`, `EVENT`, `GIVEAWAY`, `ARTICLE`, `POLL` |

The library also contains many more enums used by the models, such as item types (`EItemType`),
tiers (`ETier`), majors (`EMajorId`), and so on. You can find them under
`Tavstal.WynnNetSDK.Models.*.Enums`.

### Request body types

For the search endpoints, you can send a structured body.

**ItemSearchRequestBody** (for `Items.SearchAsync`)

| Property | Type | Description |
|---|---|---|
| `Query` | `string?` | Free text to search for. |
| `Type` | `List<EItemType>?` | Item types to include. |
| `Tier` | `List<ETier>?` | Item tiers to include. |
| `AttackSpeed` | `List<EAttackSpeed>?` | Attack speeds to include. |
| `LevelRange` | `List<int>?` | Level range to include. |
| `Professions` | `List<EGathering>?` | Professions to include. |
| `Identifications` | `List<EIdentification>?` | Identifications to include. |
| `MajorIds` | `List<EMajorId>?` | Major IDs to include. |

**RecipesSearchRequestBody** (for `Recipes.SearchAsync`)

| Property | Type | Description |
|---|---|---|
| `Query` | `List<string>?` | Terms to search for. |
| `Xp` | `List<int>?` | XP values to include. |
| `Type` | `List<string>?` | Recipe types to include. |
| `Skill` | `List<string>?` | Skills to include. |
| `Materials` | `List<string>?` | Materials to include. |
| `Level` | `List<int>?` | Levels to include. |
| `Durability` | `List<int>?` | Durability values to include. |
| `HealthOrDamage` | `List<int>?` | Health or damage values to include. |
| `Duration` | `List<int>?` | Duration values to include. |
| `BasicDuration` | `List<int>?` | Basic duration values to include. |

---

## Caching table

Cache durations used by the SDK when an `ICacheManager` is provided:

| Endpoint | Cache duration |
|---|---|
| Player online lists | 30 seconds |
| Map player locations | 15 seconds |
| Map camps / raids | 1 minute |
| Guild territories | 10 seconds |
| Map events / loot pools | 2 minutes |
| News (list, fetch, videos) | 2 minutes |
| Guild details, player profiles & characters | 2 minutes |
| Item sets | 2 minutes |
| Item metadata | 3 minutes |
| Leaderboard | 10 minutes |
| Guild seasons | 10 minutes |
| Search | 10 minutes |
| Legacy news | 60 minutes |
| Classes, items, recipes, gathering nodes, markers, quests, abilities, guild lists | 1 hour |