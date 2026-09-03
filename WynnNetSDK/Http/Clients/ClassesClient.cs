using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Classes;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class ClassesClient : HttpClientBase
{
    public ClassesClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<Dictionary<string, Class>, ErrorResponse>> ListAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesListRequest(),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<ClassDetail, ErrorResponse>> GetAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesGetRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
}
