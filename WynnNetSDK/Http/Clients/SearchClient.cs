using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Search;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class SearchClient : HttpClientBase
{
    public SearchClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<SearchResult, ErrorResponse>> SearchAsync(string query, bool onlyOneResult = false, CancellationToken cancellationToken = default)
        => ExecuteAsync(new SearchRequest(query, onlyOneResult), cancellationToken);
}
