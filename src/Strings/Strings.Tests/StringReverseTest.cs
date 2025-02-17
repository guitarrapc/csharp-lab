using Strings.Core;

namespace Strings.Tests;

public class StringReverseTest
{
    private readonly string _source;
    private readonly string _expected;

    public StringReverseTest()
    {
        _source = StringReverse.GenerateText();
        _expected = string.Concat(_source.Reverse());
    }

    [Fact]
    public async Task ArrayReverseStringTest()
    {
        Assert.Equal(_expected, StringReverse.RecursiveReverse(_source));
    }

    [Fact]
    public async Task EnumerableReverseTest()
    {
        Assert.Equal(_expected, StringReverse.EnumerableReverse(_source));
    }

    [Fact]
    public async Task RecursiveStringReverseTest()
    {
        Assert.Equal(_expected, StringReverse.RecursiveReverse(_source));
    }

    [Fact]
    public async Task ReverseXorTest()
    {
        Assert.Equal(_expected, StringReverse.ReverseXor(_source));
    }

    [Fact]
    public async Task StringCreateTest()
    {
        Assert.Equal(_expected, StringReverse.StringSpan(_source));
    }

    [Fact]
    public async Task StringExtensionReverseTest()
    {
        Assert.Equal(_expected, StringReverse.StringExtensionReverse(_source));
    }

    [Fact]
    public async Task TextElementEnumeratorTest()
    {
        Assert.Equal(_expected, StringReverse.TextElementEnumerator(_source));
    }
}
