using Logic.Core;

namespace Logic.Tests;

public class StringFormatTest
{
    [Fact]
    public void CompositeTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        formatter.Composite(datetime, "foo", 100).Should().Be($"{datetime:t}: Hello, foo! I'll give you 100 apples.");
    }

    [Fact]
    public void FormatTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        formatter.Format(datetime, "foo", 100).Should().Be($"{datetime:t}: Hello, foo! I'll give you 100 apples.");
    }
}
