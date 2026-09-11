using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Models.Items.Sets;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for item-related API endpoints.
/// </summary>
public class ItemsClient : HttpClientBase
{
    /// <summary>
    /// Creates a new items client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public ItemsClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists items with optional pagination and result formatting.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result data.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A paginated result containing item data.</returns>
    public Task<Result<ItemResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListRequest(page, fullResult), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Lists all item sets.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping set names to item set data.</returns>
    public Task<Result<Dictionary<string, ItemSet>, ErrorResponse>> ListSetsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsListSetsRequest(), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Performs a quick search for items by name.
    /// </summary>
    /// <param name="query">The search query to match item names against.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of items matching the search query.</returns>
    public Task<Result<List<Item>, ErrorResponse>> QuickSearchAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsQuickSearchRequest(query), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Searches for items using detailed filter criteria.
    /// </summary>
    /// <param name="requestBody">The search criteria to filter items by.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result data.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A paginated result containing matching items.</returns>
    public Task<Result<ItemResult, ErrorResponse>> SearchAsync(ItemSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsSearchRequest(requestBody, page, fullResult), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Gets the filter metadata for items.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The item filter metadata result.</returns>
    public Task<Result<ItemMetaResult, ErrorResponse>> GetMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterMetadataRequest(), TimeSpan.FromSeconds(180), cancellationToken);

    /// <summary>
    /// Gets the static filter metadata for items.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The static item filter metadata result.</returns>
    public Task<Result<ItemMetaStaticResult, ErrorResponse>> GetStaticMetadataAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ItemsFilterStaticMetadataRequest(), TimeSpan.FromSeconds(180), cancellationToken);
}
