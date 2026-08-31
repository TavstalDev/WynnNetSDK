using Tavstal.WynnNetSDK.Models.News;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsListRequest : HttpRequestBase<ArticleResult>
{
    public NewsListRequest(EArticleType type, int? page = null) 
        : base(HttpMethod.Get, $"/v3/publisher/articles/list/{type}")
    {
        List<string> queryParams = [];
        if (page is > 0)
            queryParams.Add($"page={page}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}