using System.Text;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Builds the User-Agent header string sent with every request.
/// </summary>
public static class UserAgent
{
    private static int OperatingSystemBitness => Environment.Is64BitOperatingSystem ? 64 : 32;

    private static string OperatingSystemName => Environment.OSVersion.ToString();

    private static string DotNetClrVersion => Environment.Version.ToString().Trim();

    private static string DotNetVersion => Environment.Version.ToString();

    /// <summary>
    /// Builds a User-Agent header value that includes the application name, .NET version, and OS info.
    /// </summary>
    /// <param name="applicationName">The name of the calling application.</param>
    /// <returns>A formatted User-Agent string.</returns>
    public static string GetUserAgentHeader(string applicationName = "Tavstal/WynnNetSDK")
    {
        StringBuilder strngBuilder = new StringBuilder(applicationName);
        strngBuilder.Append(" (");
        strngBuilder.Append("lang=DOTNET;");
        strngBuilder.Append("v=" + DotNetVersion + ";");
        strngBuilder.Append("clr=" + DotNetClrVersion + ";");
        strngBuilder.Append("bit=" + OperatingSystemBitness + ";");
        strngBuilder.Append("os=" + OperatingSystemName + ";");
        strngBuilder.Append(')');
        return strngBuilder.ToString();
    }
}
