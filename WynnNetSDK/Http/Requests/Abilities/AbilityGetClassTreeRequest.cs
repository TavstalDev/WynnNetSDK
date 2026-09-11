using Tavstal.WynnNetSDK.Models.Abilities.Responses;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

/// <summary>
/// A request to get the ability tree for a class from the Wynncraft API.
/// </summary>
public class AbilityGetClassTreeRequest : HttpRequestBase<AbilityTreeResult>
{
    /// <summary>
    /// Creates a new request to get the ability tree for a class.
    /// </summary>
    /// <param name="class">The class to get the ability tree for.</param>
    public AbilityGetClassTreeRequest(EClass @class)
        : base(HttpMethod.Get, $"/v3/ability/tree/{@class}")
    {
    }
}
