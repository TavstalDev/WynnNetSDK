using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public abstract class TestBase
{
    protected readonly ITestOutputHelper _testOutputHelper;
    protected readonly List<Resource> _resources = [];

    protected TestBase(ITestOutputHelper testOutputHelper, string[] responsePaths)
    {
        _testOutputHelper = testOutputHelper;
        foreach (string path in responsePaths)
        {
            try
            {
                _resources.Add(Resource.FromFile(path));
            }
            catch (Exception ex)
            {
                _testOutputHelper.WriteLine($"Failed to load resource, {path}: {ex}");
            }
        }
    }
}