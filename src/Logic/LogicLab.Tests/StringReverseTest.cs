namespace LogicLab.Tests;

public class StringReverseTest
{
    private readonly string _source;
    private readonly StringReverse _stringReverse;
    private readonly string _expected;

    public StringReverseTest()
    {
        _source = StringReverse.GenerateText();
        _expected = string.Concat(Enumerable.Reverse(_source));
        _stringReverse = new StringReverse();
    }

    [Fact]
    public async Task ArrayReverseStringTest()
    {
        _stringReverse.RecursiveStringReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task EnumerableReverseTest()
    {
        _stringReverse.EnumerableReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task RecursiveStringReverseTest()
    {
        _stringReverse.RecursiveStringReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task ReverseXorTest()
    {
        _stringReverse.ReverseXor(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task StringCreateTest()
    {
        _stringReverse.StringSpan(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task StringExtensionReverseTest()
    {
        _stringReverse.StringExtensionReverse(_source).Should().Be(_expected);
    }

    [Fact]
    public async Task TextElementEnumeratorTest()
    {
        _stringReverse.TextElementEnumerator(_source).Should().Be(_expected);
    }
}
