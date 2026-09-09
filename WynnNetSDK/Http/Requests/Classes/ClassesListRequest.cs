using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

/// <summary>
/// A request to list all classes from the Wynncraft API.
/// </summary>
public class ClassesListRequest : HttpRequestBase<Dictionary<string, Class>>
{
    /// <summary>
    /// Creates a new request to list all classes.
    /// </summary>
    public ClassesListRequest() 
        : base(HttpMethod.Get, "/v3/classes")
    {
    }
}