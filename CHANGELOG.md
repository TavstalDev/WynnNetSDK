# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
<details>
<summary>In development changes</summary>

</details>

## [1.0.1] - 2026.09.22
<details>
<summary>Bug fixes, model corrections, and improved enum serialization.</summary>

### Fixed

- **Ranking property type** changed to `Dictionary<string, int>`
- **Integer properties** throughout leaderboard metadata and player stats changed to `ulong`
- **LastJoin property** type changed to `DateTime?`
- **Veteran property** type updated to `bool?`
- **RaidStats property** removed from `GuildMemberGlobalData`
- **Empty JSON handling** in `LeaderboardEntryDeserializer` and `LeaderboardMetadataDeserializer`
- **Tier values** now serialized to lowercase in JSON

### Added

- **`JsonPropertyNameStringEnumConverter`** for enum serialization

### Changed

- **Deserialization tests** updated for `LeaderboardEntry`
- **README** now includes stars and forks badges

</details>

## [1.0.0] - 2026.09.13
<details>
<summary>Initial release.</summary>

### Added

- **Core clients and requests** for all Wynncraft API areas: Ability, Classes, Guild, Items, Leaderboard, Map, News, Player, Recipes, and Search
- **Player models**: SkillPoints, PlayerDataRestrictions, PlayerDungeons, PlayerPvpInfo, PlayerRaidStats, PlayerListOnlineResponse, PlayerGlobalData, PlayerGuildInfo, PlayerInfo, PlayerCharacter, PlayerProfessionInfo
- **Common models**: EColor, EScaleLevel, Vector2, Vector3
- **Guild models**: detailed info, members, banners, territories, season rewards
- **Item models**: full item database support, search, and filter metadata
- **Leaderboard models**: entry deserialization for player and guild entries, including metadata handling
- **News models**: article fetching and listing by type
- **Map models**: camps, events, markers, player locations, gathering nodes, loot pools, quests, and raids
- **Ability and Classes models**: Class, ClassDetail, Archtype, Aspect, EClass, ability trees and aspects
- **Recipe models**: search and list request handling with material support
- **Search models**: SearchResult and SearchGuildInfo with endpoint testing
- **`Result<T, ErrorResponse>` pattern** for error handling without exceptions
- **`ICacheManager` interface** with per-endpoint default cache durations
- **Rate limiting** via `RateLimitException` with RPM tracking and reset time
- **Automatic retry logic** for failed and rate-limited requests (configurable via `WynnClientOptions`)
- **Source-generated JSON serialization** using `System.Text.Json` (trim-safe, AOT-compatible)
- **Custom JSON converters** for leaderboard deserialization
- **Test suite** with xUnit, FluentAssertions, and 40+ JSON fixture files
- **API reference documentation** (`docs/API_REFERENCE.md`)
- **Contributing guidelines** (`docs/CONTRIBUTING.md`)
- **GitHub Actions workflows** for CI builds and releases
- **Dependabot configuration** for GitHub Actions and NuGet updates
- **Error-handling tests** for network failures and unexpected send errors (must return `Result.Error`, never throw)
- **Rate-limit recovery test** covering automatic counter re-arming after the window passes
- **Advanced custom requests documentation** in the API reference (`HttpRequestBase`, `SendAsync`, `IWynnHttpClient`)
- **SourceLink support** via `Microsoft.SourceLink.GitHub` for source debugging
- **`JsonElement`-based icon and value properties** on ability and player character models
- **Null-safe leaderboards**: `SubType` is nullable and `Votes` is a `JsonElement`
- **Nullable `Prev` and `Next` properties** on `PageController`
- **Simplified `WynnEnvironment` constructor** taking the base URL and token
- **Consistent request classes** across leaderboard, ability, and player areas (including class aspects/trees and generic player requests)
- **Clear exception contract**: HTTP status, network, and deserialization failures are returned as `Result.Error`; only `RateLimitException` and `OperationCanceledException` can escape a call
- **Lazy rate-limit re-arm**: the per-client RPM counter resumes automatically once the rate-limit window has passed
- **Polished models**: corrected `Total` in `PlayerListOnlineResponse`, fixed `Vector3` property types, and initialized `GuildTerritory` list properties

</details>

[unreleased]: https://github.com/TavstalDev/WynnNetSDK/compare/v1.0.1...HEAD
[1.0.1]: https://github.com/TavstalDev/WynnNetSDK/releases/tag/v1.0.1
[1.0.0]: https://github.com/TavstalDev/WynnNetSDK/releases/tag/v1.0.0