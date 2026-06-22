#nullable disable
namespace CSharp6.Tests;

public class NullConditionalOperatorTest
{
    [Test]
    public async Task NullConditionalTests()
    {
        var s5 = SampleCsharp5.X(new SampleCsharp5());
        var s6 = SampleCsharp6.X(new SampleCsharp6());

        await Assert.That(s5).IsNull();
        await Assert.That(s6).IsNull();
    }

    public class SampleCsharp5
    {
        public string Name { get; set; }
        public static int? X(SampleCsharp5 s)
        {
            if (s == null) return null;
            var name = s.Name;
            if (name == null) return null;
            return name.Length;
        }
    }

    public class SampleCsharp6
    {
        public string Name { get; set; }
        public static int? X(SampleCsharp6 s)
        {
            // C# 6 introduce null conditional operator by ?.
            return s?.Name?.Length;
        }
    }
}
