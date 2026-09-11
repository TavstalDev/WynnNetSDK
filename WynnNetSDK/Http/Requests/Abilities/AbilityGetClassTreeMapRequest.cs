using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

/// <summary>
/// A request to get the ability tree map for a class from the Wynncraft API.
/// </summary>
public class AbilityGetClassTreeMapRequest : HttpRequestBase<Dictionary<string, List<AbilityNode>>>
{
    /// <summary>
    /// Creates a new request to get the ability tree map for a class.
    /// </summary>
    /// <param name="class">The class to get the ability tree map for.</param>
    public AbilityGetClassTreeMapRequest(EClass @class)
        : base(HttpMethod.Get, $"/v3/ability/map/{@class}")
    {
    }
}
