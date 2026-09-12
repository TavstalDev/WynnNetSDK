using Tavstal.WynnNetSDK.Http;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class ResultTests
{
    [Fact(DisplayName = "N/A - Success result exposes the value")]
    public void SuccessExposesValue()
    {
        var result = Result<string, string>.Success("data");

        result.IsSuccess.Should().BeTrue();
        result.IsError.Should().BeFalse();
        result.Value.Should().Be("data");
        result.Error.Should().BeNull();
    }

    [Fact(DisplayName = "N/A - Failure result exposes the error")]
    public void FailureExposesError()
    {
        var result = Result<string, string>.Failure("boom");

        result.IsSuccess.Should().BeFalse();
        result.IsError.Should().BeTrue();
        result.Value.Should().BeNull();
        result.Error.Should().Be("boom");
    }

    [Fact(DisplayName = "N/A - Match runs the success callback on success")]
    public void MatchOnSuccess()
        => Result<string, string>.Success("data").Match(v => $"ok:{v}", _ => "error").Should().Be("ok:data");

    [Fact(DisplayName = "N/A - Match runs the failure callback on failure")]
    public void MatchOnFailure()
        => Result<string, string>.Failure("boom").Match(_ => "ok", error => $"error:{error}").Should().Be("error:boom");

    [Fact(DisplayName = "N/A - Switch runs only the matching action")]
    public void SwitchRunsOwnAction()
    {
        var branches = new List<string>();
        Result<string, string>.Success("data").Switch(_ => branches.Add("success"), _ => branches.Add("failure"));
        Result<string, string>.Failure("boom").Switch(_ => branches.Add("success"), _ => branches.Add("failure"));
        branches.Should().Equal("success", "failure");
    }
}