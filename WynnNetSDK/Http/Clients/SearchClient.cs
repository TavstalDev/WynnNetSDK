using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Search;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class SearchClient : HttpClientBase
{
    public SearchClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<SearchResult, ErrorResponse>> SearchAsync(string query, bool onlyOneResult = false, CancellationToken cancellationToken = default)
        => ExecuteAsync(new SearchRequest(query, onlyOneResult),  TimeSpan.FromMinutes(10), cancellationToken);
}
