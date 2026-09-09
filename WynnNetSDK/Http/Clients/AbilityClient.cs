using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Abilities;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Abilities.Responses;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for ability-related API endpoints.
/// </summary>
public class AbilityClient : HttpClientBase
{
    /// <summary>
    /// Creates a new ability client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public AbilityClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    /// <summary>
    /// Gets the ability tree for a specific class.
    /// </summary>
    /// <param name="class">The class to get the ability tree for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The ability tree result for the given class.</returns>
    public Task<Result<AbilityTreeResult, ErrorResponse>> GetClassTreeAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassTreeRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
    
    /// <summary>
    /// Gets the ability tree as a dictionary of node lists for a specific class.
    /// </summary>
    /// <param name="class">The class to get the ability tree map for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping node IDs to lists of ability nodes.</returns>
    public Task<Result<Dictionary<string, List<AbilityNode>>, ErrorResponse>> GetClassTreeMapAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassTreeMapRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
    
    /// <summary>
    /// Gets the list of aspects for a specific class.
    /// </summary>
    /// <param name="class">The class to get aspects for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of aspects for the given class.</returns>
    public Task<Result<List<Aspect>, ErrorResponse>> GetClassAspectsAsync(EClass @class, CancellationToken cancellationToken = default)
        => ExecuteAsync(new AbilityGetClassAspectsRequest(@class),  TimeSpan.FromHours(1), cancellationToken);
}
