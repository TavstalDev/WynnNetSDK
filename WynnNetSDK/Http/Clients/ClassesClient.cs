using Tavstal.WynnNetSDK.Http.Requests.Classes;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class ClassesClient : HttpClientBase
{
    public ClassesClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<Dictionary<string, Class>, ErrorResponse>> ListAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesListRequest(), cancellationToken);
    
    public Task<Result<ClassDetail, ErrorResponse>> GetAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesGetRequest(@class), cancellationToken);
}
