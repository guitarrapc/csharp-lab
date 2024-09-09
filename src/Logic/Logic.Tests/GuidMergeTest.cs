using Logic.Core;

namespace Logic.Tests;

public class GuidMergeTest
{
    [Fact]
    public async Task CreateGuidFromNamesTest()
    {
        // Should not throw
        GuidMerge.CreateGuidFromNames("asdfasdfasdfasdf", "takoyakiokonomiyaki");
    }

    [Fact]
    public async Task MergeGuidTest()
    {
        for (var i = 0; i < 10; i++)
        {
            var a = Guid.NewGuid();
            var b = Guid.NewGuid();

            var fast = GuidMerge.FastMerge(a, b);
            var fair = GuidMerge.FairMerge(a, b);
            var slow = GuidMerge.SlowMerge(a, b);

            fast.Should().Be(fair);
            fast.Should().Be(slow);
            fair.Should().Be(slow);

            fast.Should().NotBe(a);
            fast.Should().NotBe(b);
        }
    }
}
