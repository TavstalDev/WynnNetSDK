using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

/// <summary>
/// A request to get detailed information about a class from the Wynncraft API.
/// </summary>
public class ClassesGetRequest : HttpRequestBase<ClassDetail>
{
    /// <summary>
    /// Creates a new request to get detailed information about a class.
    /// </summary>
    /// <param name="class">The class to get information for.</param>
    public ClassesGetRequest(EClass @class)
        : base(HttpMethod.Get, $"/v3/classes/{@class}")
    {
    }
}
