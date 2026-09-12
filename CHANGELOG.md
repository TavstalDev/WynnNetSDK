# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
<details>
<summary>In development changes</summary>

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

### Changed

- Updated ability and player character models to use `JsonElement` for icon and value properties
- Changed leaderboard `SubType` to nullable and `Votes` to `JsonElement` for improved data handling
- Changed `PageController.Prev` and `Next` properties to nullable integers
- Simplified `WynnEnvironment` constructor by removing `webUrl` parameter
- Renamed leaderboard request classes for consistency
- Refactored ability request classes to support class aspects and trees
- Refactored player request classes to include generic types

### Fixed

- Corrected spelling of 'Total' in `PlayerListOnlineResponse`
- Fixed `Vector3` property types
- Initialized list properties in `GuildTerritory` class

</details>

[unreleased]: https://github.com/TavstalDev/WynnNetSDK/compare/v1.0.0...HEAD
[1.0.0]: https://github.com/TavstalDev/WynnNetSDK/releases/tag/v1.0.0