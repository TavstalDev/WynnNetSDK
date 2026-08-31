using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Models.Items.Sets;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class ItemsClient : HttpClientBase
{
    public ItemsClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<ItemResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListRequest(page, fullResult), cancellationToken);
    
    public Task<Result<Dictionary<string, ItemSet>, ErrorResponse>> ListSetsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListSetsRequest(), cancellationToken);
    
    public Task<Result<List<Item>, ErrorResponse>> QuickSearchAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsQuickSearchRequest(query), cancellationToken);
    
    public Task<Result<ItemResult, ErrorResponse>> SearchAsync(ItemSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsSearchRequest(requestBody, page, fullResult), cancellationToken);
    
    public Task<Result<ItemMetaResult, ErrorResponse>> GetMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterMetadataRequest(), cancellationToken);
    
    public Task<Result<ItemMetaStaticResult, ErrorResponse>> GetStaticMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterStaticMetadataRequest(), cancellationToken);
}
