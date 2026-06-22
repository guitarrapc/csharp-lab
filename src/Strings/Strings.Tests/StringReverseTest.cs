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

    [Test]
    public async Task ArrayReverseStringTest()
    {
        await Assert.That(StringReverse.RecursiveReverse(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task EnumerableReverseTest()
    {
        await Assert.That(StringReverse.EnumerableReverse(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task RecursiveStringReverseTest()
    {
        await Assert.That(StringReverse.RecursiveReverse(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task ReverseXorTest()
    {
        await Assert.That(StringReverse.ReverseXor(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task StringCreateTest()
    {
        await Assert.That(StringReverse.StringSpan(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task StringExtensionReverseTest()
    {
        await Assert.That(StringReverse.StringExtensionReverse(_source)).IsEqualTo(_expected);
    }

    [Test]
    public async Task TextElementEnumeratorTest()
    {
        await Assert.That(StringReverse.TextElementEnumerator(_source)).IsEqualTo(_expected);
    }
}
