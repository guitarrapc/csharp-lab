using Logic.Core;

namespace Logic.Tests;

public class BinaryArrayConverterTest
{
    [Fact]
    public async Task ToBinaryArrayIntTest()
    {
        var actual = BinaryArrayConverter.ToBinaryArrayInt(192);
        var expected = new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 };
        Assert.True(actual.SequenceEqual(expected));

        var actual2 = BinaryArrayConverter.ToBinaryArrayInt(168);
        var expected2 = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0 };
        Assert.True(actual2.SequenceEqual(expected2));

        byte[]? min = BinaryArrayConverter.ToBinaryArrayInt(0);
        var expectedMin = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        Assert.True(min.SequenceEqual(expectedMin));

        byte[]? max = BinaryArrayConverter.ToBinaryArrayInt(255);
        var expectedMax = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        Assert.True(max.SequenceEqual(expectedMax));
    }

    [Fact]
    public async Task ToBinaryArrayConvertToStringTest()
    {
        var actual = BinaryArrayConverter.ToBinaryArrayConvertToString(192);
        var expected = new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 };
        Assert.True(actual.SequenceEqual(expected));

        var actual2 = BinaryArrayConverter.ToBinaryArrayConvertToString(168);
        var expected2 = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0 };
        Assert.True(actual2.SequenceEqual(expected2));

        byte[]? min = BinaryArrayConverter.ToBinaryArrayConvertToString(0);
        var expectedMin = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        Assert.True(min.SequenceEqual(expectedMin));

        byte[]? max = BinaryArrayConverter.ToBinaryArrayConvertToString(255);
        var expectedMax = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        Assert.True(max.SequenceEqual(expectedMax));
    }

    [Fact]
    public async Task ToBinaryArrayIntModTest()
    {
        var actual = BinaryArrayConverter.ToBinaryArrayIntMod(192);
        var expected = new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 };
        Assert.True(actual.SequenceEqual(expected));

        var actual2 = BinaryArrayConverter.ToBinaryArrayIntMod(168);
        var expected2 = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0 };
        Assert.True(actual2.SequenceEqual(expected2));

        byte[]? min = BinaryArrayConverter.ToBinaryArrayIntMod(0);
        var expectedMin = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        Assert.True(min.SequenceEqual(expectedMin));

        byte[]? max = BinaryArrayConverter.ToBinaryArrayIntMod(255);
        var expectedMax = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        Assert.True(max.SequenceEqual(expectedMax));
    }

    [Fact]
    public async Task ToBinaryArrayIntModNumberTest()
    {
        var actual = BinaryArrayConverter.ToBinaryArrayIntModNumber(192);
        var expected = new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 };
        Assert.True(actual.SequenceEqual(expected));

        var actual2 = BinaryArrayConverter.ToBinaryArrayIntModNumber(168);
        var expected2 = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0 };
        Assert.True(actual2.SequenceEqual(expected2));

        byte[]? min = BinaryArrayConverter.ToBinaryArrayIntModNumber(0);
        var expectedMin = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        Assert.True(min.SequenceEqual(expectedMin));

        byte[]? max = BinaryArrayConverter.ToBinaryArrayIntModNumber(255);
        var expectedMax = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        Assert.True(max.SequenceEqual(expectedMax));
    }
}
