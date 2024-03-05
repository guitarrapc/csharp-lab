using Strings.Core;

namespace Strings.Tests;

public class StringReverseTest
{
    private readonly string _source;
    private readonly string _expected;

    public StringReverseTest()
    {
        _source = StringReverse.GenerateText();
        _expected = string.Concat(Enumerable.Reverse(_source));
    }

    [Fact]
    public async Task ArrayReverseStringTest()
    {
        StringReverse.RecursiveReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task EnumerableReverseTest()
    {
        StringReverse.EnumerableReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task RecursiveStringReverseTest()
    {
        StringReverse.RecursiveReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task ReverseXorTest()
    {
        StringReverse.ReverseXor(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task StringCreateTest()
    {
        StringReverse.StringSpan(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task StringExtensionReverseTest()
    {
        StringReverse.StringExtensionReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task TextElementEnumeratorTest()
    {
        StringReverse.TextElementEnumerator(_source).Should().Be(_expected);
    }
}
