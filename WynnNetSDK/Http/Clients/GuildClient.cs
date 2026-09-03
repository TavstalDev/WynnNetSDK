using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Guild;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class GuildClient : HttpClientBase
{
    public GuildClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByNameAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByNameRequest(query), TimeSpan.FromSeconds(120), cancellationToken);
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByUuidAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByUuidRequest(query), TimeSpan.FromSeconds(120), cancellationToken);
    
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByPrefixAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetPrefixRequest(query), TimeSpan.FromSeconds(120), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildResult>, ErrorResponse>> ListAsync(EIdentifier? identifier = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListRequest(identifier),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildSeason>, ErrorResponse>> ListSeasonsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListSeasonsRequest(), TimeSpan.FromMinutes(10), cancellationToken);
    
    public Task<Result<Dictionary<string, GuildTerritory>, ErrorResponse>> ListTerritoriesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListTerritoriesRequest(), TimeSpan.FromSeconds(10), cancellationToken);
}
