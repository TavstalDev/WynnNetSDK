using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Abilities;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Abilities.Responses;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class AbilityClient : HttpClientBase
{
    public AbilityClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<AbilityTreeResult, ErrorResponse>> GetClassTreeAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassTreeRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<Dictionary<string, List<AbilityNode>>, ErrorResponse>> GetClassTreeMapAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassTreeMapRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<List<Aspect>, ErrorResponse>> GetClassAspectsAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassAspectsRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
}
