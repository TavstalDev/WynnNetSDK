using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class SearchClient : HttpClientBase
{
    public SearchClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<bool, ErrorResponse>> SearchAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new SearchRequest(query), cancellationToken);
}
