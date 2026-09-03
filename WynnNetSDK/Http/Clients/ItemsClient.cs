using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Models.Items.Sets;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class ItemsClient : HttpClientBase
{
    public ItemsClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<ItemResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListRequest(page, fullResult),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<Dictionary<string, ItemSet>, ErrorResponse>> ListSetsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListSetsRequest(),  TimeSpan.FromSeconds(120), cancellationToken);
    
    public Task<Result<List<Item>, ErrorResponse>> QuickSearchAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsQuickSearchRequest(query),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<ItemResult, ErrorResponse>> SearchAsync(ItemSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsSearchRequest(requestBody, page, fullResult),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<ItemMetaResult, ErrorResponse>> GetMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterMetadataRequest(),  TimeSpan.FromSeconds(180), cancellationToken);
    
    public Task<Result<ItemMetaStaticResult, ErrorResponse>> GetStaticMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterStaticMetadataRequest(),  TimeSpan.FromSeconds(180), cancellationToken);
}
