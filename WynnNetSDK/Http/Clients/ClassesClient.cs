using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Classes;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for class-related API endpoints.
/// </summary>
public class ClassesClient : HttpClientBase
{
    /// <summary>
    /// Creates a new classes client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public ClassesClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists all classes available in Wynncraft.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping class names to class data.</returns>
    public Task<Result<Dictionary<string, Class>, ErrorResponse>> ListAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesListRequest(), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Gets detailed information about a specific class.
    /// </summary>
    /// <param name="class">The class to get details for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the given class.</returns>
    public Task<Result<ClassDetail, ErrorResponse>> GetAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new ClassesGetRequest(@class), TimeSpan.FromHours(1), cancellationToken);
}
