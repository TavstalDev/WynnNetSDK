using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.News;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.News;
using Tavstal.WynnNetSDK.Models.News.Enums;
using Tavstal.WynnNetSDK.Models.News.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for news-related API endpoints.
/// </summary>
public class NewsClient : HttpClientBase
{
    /// <summary>
    /// Creates a new news client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public NewsClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists articles of a specific type with optional pagination.
    /// </summary>
    /// <param name="type">The type of articles to list.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A paginated result containing articles.</returns>
    public Task<Result<ArticleResult, ErrorResponse>> ListAsync(EArticleType type, int? page = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsListRequest(type, page), TimeSpan.FromMinutes(2), cancellationToken);

    /// <summary>
    /// Fetches a single article by its type and primary key.
    /// </summary>
    /// <param name="type">The type of the article.</param>
    /// <param name="pk">The primary key of the article.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The requested article data.</returns>
    public Task<Result<Article, ErrorResponse>> FetchAsync(EArticleType type, string pk, CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsFetchRequest(type, pk), TimeSpan.FromMinutes(2), cancellationToken);

    /// <summary>
    /// Gets all legacy articles.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of legacy articles.</returns>
    public Task<Result<List<LegacyArticle>, ErrorResponse>> GetLegacyAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsGetLegacyRequest(), TimeSpan.FromMinutes(60), cancellationToken);

    /// <summary>
    /// Lists available videos with their titles.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping video IDs to video titles.</returns>
    public Task<Result<Dictionary<string, string>, ErrorResponse>> ListVideosAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsListVideosRequest(), TimeSpan.FromMinutes(2), cancellationToken);
}
