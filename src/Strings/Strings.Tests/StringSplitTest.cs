using Strings.Core;

namespace Strings.Tests;

public class StringSplitTest
{
    [Test]
    public async Task SplitMatchToSplitNoAlloc()
    {
        var value = "foo.bar.piyo.fuga";
        var actual = new List<string>(8);

        {
            foreach (var item in value.SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = value.Split('.');
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = value.Split('.');
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }
    }

    [Test]
    public async Task SplitStringTest()
    {
        var value = "foo.bar.piyo.fuga";
        var actual = new List<string>(8);

        {
            foreach (var item in value.SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = new[] { "foo", "bar", "piyo", "fuga" };
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = new[] { "foo", "bar", "piyo", "fuga" };
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }
    }

    [Test]
    public async Task SplitIntTest()
    {
        var value = "1,2,3,4,5,6,7,8,9,10";
        var actual = new List<int>(8);

        {
            foreach (var item in value.SplitNoAlloc(','))
            {
                actual.Add(int.Parse(item.Word));
            }
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc(','))
            {
                actual.Add(int.Parse(item.Word));
            }
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            await Assert.That(actual.SequenceEqual(expected)).IsTrue();
            actual.Clear();
        }
    }
}
