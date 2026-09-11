using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player;
using Tavstal.WynnNetSDK.Models.Player.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for player-related API endpoints.
/// </summary>
public class PlayerClient : HttpClientBase
{
    /// <summary>
    /// Creates a new player client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public PlayerClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists online players, optionally filtered by identifier type and server name.
    /// </summary>
    /// <param name="identifier">An optional identifier type to filter results by.</param>
    /// <param name="server">An optional server name to filter players by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A response containing online player data.</returns>
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, string? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), TimeSpan.FromSeconds(30), cancellationToken);

    /// <summary>
    /// Lists online players, optionally filtered by identifier type and server ID.
    /// </summary>
    /// <param name="identifier">An optional identifier type to filter results by.</param>
    /// <param name="server">An optional server ID to filter players by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A response containing online player data.</returns>
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, int? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), TimeSpan.FromSeconds(30), cancellationToken);

    /// <summary>
    /// Gets the detailed profile of a player by their username.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the player.</returns>
    public Task<Result<PlayerDetailedInfo, ErrorResponse>> GetProfileAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetProfileRequest(username), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Gets the authenticated user's own player data.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary with the authenticated user's player info.</returns>
    public Task<Result<Dictionary<string, PlayerInfo>, ErrorResponse>> WhoAmIAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerWhoAmIRequest(), null, cancellationToken);

    /// <summary>
    /// Lists all characters for a specific player.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping character UUIDs to character data.</returns>
    public Task<Result<Dictionary<string, PlayerCharacter>, ErrorResponse>> ListCharactersAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListCharactersRequest(username), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Gets detailed information about a specific character.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="uuid">The UUID of the character.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the character.</returns>
    public Task<Result<PlayerDetailedCharacter, ErrorResponse>> GetCharacterAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetCharacterRequest(username, uuid), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Gets the ability map for a specific character.
    /// </summary>
    /// <param name="username">The username of the player.</param>
    /// <param name="uuid">The UUID of the character.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping class names to lists of ability map nodes.</returns>
    public Task<Result<Dictionary<string, List<AbilityMap>>, ErrorResponse>> GetAbilityMapAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetAbilityMapRequest(username, uuid), TimeSpan.FromMinutes(10), cancellationToken);
}
