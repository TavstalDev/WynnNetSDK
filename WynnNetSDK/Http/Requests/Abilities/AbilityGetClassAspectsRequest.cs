using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

/// <summary>
/// A request to get the class aspects from the Wynncraft API.
/// </summary>
public class AbilityGetClassAspectsRequest : HttpRequestBase<List<Aspect>>
{
    /// <summary>
    /// Creates a new request to get the class aspects.
    /// </summary>
    /// <param name="class">The class to get aspects for.</param>
    public AbilityGetClassAspectsRequest(EClass @class)
        : base(HttpMethod.Get, $"/v3/aspects/{@class}")
    {
    }
}
