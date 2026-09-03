using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.News;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.News;
using Tavstal.WynnNetSDK.Models.News.Enums;
using Tavstal.WynnNetSDK.Models.News.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class NewsClient : HttpClientBase
{
    public NewsClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<ArticleResult, ErrorResponse>> ListAsync(EArticleType type, int? page = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsListRequest(type, page), TimeSpan.FromMinutes(2), cancellationToken);
    
    public Task<Result<Article, ErrorResponse>> FetchAsync(EArticleType type, string pk, CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsFetchRequest(type, pk), TimeSpan.FromMinutes(2), cancellationToken);
    
    public Task<Result<List<LegacyArticle>, ErrorResponse>> GetLegacyAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsGetLegacyRequest(),  TimeSpan.FromMinutes(60), cancellationToken);
    
    public Task<Result<Dictionary<string, string>, ErrorResponse>> ListVideosAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new NewsListVideosRequest(), TimeSpan.FromMinutes(2), cancellationToken);
}
