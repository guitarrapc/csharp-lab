using Logic.Core;

namespace Logic.Tests;

public class StringFormatTest
{
    [Fact]
    public void CompositeTest()
    {
        var formatter = new StringFormat("Hello, {0}! I'll give you {1} apples.");
        formatter.Composite("foo", 100).Should().Be("Hello, foo! I'll give you 100 apples.");
    }

    [Fact]
    public void FormatTest()
    {
        var formatter = new StringFormat("Hello, {0}! I'll give you {1} apples.");
        formatter.Format("foo", 100).Should().Be("Hello, foo! I'll give you 100 apples.");
    }
}
