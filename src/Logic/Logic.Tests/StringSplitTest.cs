namespace Logic.Tests;

public class StringSplitTest
{
    [Fact]
    public void SplitMatchToSplitNoAlloc()
    {
        var value = "foo.bar.piyo.fuga";
        var actual = new List<string>(8);

        {
            foreach (var item in value.SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = value.Split('.');
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = value.Split('.');
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }
    }

    [Fact]
    public void SplitStringTest()
    {
        var value = "foo.bar.piyo.fuga";
        var actual = new List<string>(8);

        {
            foreach (var item in value.SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = new[] { "foo", "bar", "piyo", "fuga" };
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc('.'))
            {
                actual.Add(item.Word.ToString());
            }
            var expected = new[] { "foo", "bar", "piyo", "fuga" };
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }
    }

    [Fact]
    public void SplitIntTest()
    {
        var value = "1,2,3,4,5,6,7,8,9,10";
        var actual = new List<int>(8);

        {
            foreach (var item in value.SplitNoAlloc(','))
            {
                actual.Add(int.Parse(item.Word));
            }
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }

        {
            foreach (var item in value.AsSpan().SplitNoAlloc(','))
            {
                actual.Add(int.Parse(item.Word));
            }
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            actual.SequenceEqual(expected).Should().BeTrue();
            actual.Clear();
        }
    }
}
