using System.Text;

namespace Tavstal.WynnNetSDK.Http;

public static class UserAgent
{
    private static int OperatingSystemBitness => Environment.Is64BitOperatingSystem ? 64 : 32;
    
    private static string OperatingSystemName => Environment.OSVersion.ToString();
    
    private static string DotNetClrVersion => Environment.Version.ToString().Trim();
    
    private static string DotNetVersion => Environment.Version.ToString();
    
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