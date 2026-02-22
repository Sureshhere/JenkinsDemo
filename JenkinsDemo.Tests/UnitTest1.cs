
using Xunit;

namespace JenkinsDemo.Tests;

public class SampleTests
{
    [Fact]
    public void ThisWillFail()
    {
        Assert.True(false);
    }
}