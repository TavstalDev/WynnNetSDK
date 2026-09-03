using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player;
using Tavstal.WynnNetSDK.Models.Player.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class PlayerClient : HttpClientBase
{
    public PlayerClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, string? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), TimeSpan.FromSeconds(30), cancellationToken);
    
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, int? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), TimeSpan.FromSeconds(30), cancellationToken);
    
    public Task<Result<PlayerDetailedInfo, ErrorResponse>> GetProfileAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetProfileRequest(username), TimeSpan.FromSeconds(120), cancellationToken);
    
    public Task<Result<Dictionary<string, PlayerInfo>, ErrorResponse>> WhoAmIAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerWhoAmIRequest(), null, cancellationToken);
    
    public Task<Result<Dictionary<string, PlayerCharacter>, ErrorResponse>> ListCharactersAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListCharactersRequest(username), TimeSpan.FromSeconds(120), cancellationToken);

    public Task<Result<PlayerDetailedCharacter, ErrorResponse>> GetCharacterAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetCharacterRequest(username, uuid), TimeSpan.FromSeconds(120), cancellationToken);

    public Task<Result<Dictionary<string, List<AbilityMap>>, ErrorResponse>> GetAbilityMapAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetAbilityMapRequest(username, uuid), TimeSpan.FromMinutes(10), cancellationToken);
}
