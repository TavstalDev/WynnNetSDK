using Tavstal.WynnNetSDK.Http.Requests.Guild;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class GuildClient : HttpClientBase
{
    public GuildClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByNameAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByNameRequest(query), cancellationToken);
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByUuidAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByUuidRequest(query), cancellationToken);
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByPrefixAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetPrefixRequest(query), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildResult>, ErrorResponse>> ListAsync(EIdentifier? identifier = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListRequest(identifier), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildSeason>, ErrorResponse>> ListSeasonsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListSeasonsRequest(), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildTerritory>, ErrorResponse>> ListTerritoriesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListTerritoriesRequest(), cancellationToken);
}
