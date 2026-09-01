using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player;
using Tavstal.WynnNetSDK.Models.Player.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class PlayerClient : HttpClientBase
{
    public PlayerClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, string? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), cancellationToken);
    
    public Task<Result<PlayerListOnlineResponse, ErrorResponse>> ListOnlineAsync(EIdentifier? identifier = null, int? server = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListOnlineRequest(identifier, server), cancellationToken);
    
    public Task<Result<PlayerDetailedInfo, ErrorResponse>> GetProfileAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetProfileRequest(username), cancellationToken);
    
    public Task<Result<Dictionary<string, PlayerInfo>, ErrorResponse>> WhoAmIAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerWhoAmIRequest(), cancellationToken);
    
    public Task<Result<Dictionary<string, PlayerCharacter>, ErrorResponse>> ListCharactersAsync(string username, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerListCharactersRequest(username), cancellationToken);

    public Task<Result<PlayerDetailedCharacter, ErrorResponse>> GetCharacterAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetCharacterRequest(username, uuid), cancellationToken);

    public Task<Result<Dictionary<string, List<AbilityMap>>, ErrorResponse>> GetAbilityMapAsync(string username, string uuid, CancellationToken cancellationToken = default)
        => ExecuteAsync(new PlayerGetAbilityMapRequest(username, uuid), cancellationToken);
}
