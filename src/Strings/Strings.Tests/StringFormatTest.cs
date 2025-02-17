using Strings.Core;

namespace Strings.Tests;

public class StringFormatTest
{
    [Fact]
    public void CompositeTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        Assert.Equal($"{datetime:t}: Hello, foo! I'll give you 100 apples.", formatter.Composite(datetime, "foo", 100));
    }

    [Fact]
    public void FormatTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        Assert.Equal($"{datetime:t}: Hello, foo! I'll give you 100 apples.", formatter.Format(datetime, "foo", 100));
    }
}
