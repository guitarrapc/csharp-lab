using Logic.Core;

namespace Logic.Tests;

public class GuidMergeTest
{
    [Test]
    public async Task CreateGuidFromNamesTest()
    {
        // Should not throw
        GuidMerge.CreateGuidFromNames("asdfasdfasdfasdf", "takoyakiokonomiyaki");
    }

    [Test]
    public async Task MergeGuidTest()
    {
        for (var i = 0; i < 10; i++)
        {
            var a = Guid.NewGuid();
            var b = Guid.NewGuid();

            var fast = GuidMerge.FastMerge(a, b);
            var fair = GuidMerge.FairMerge(a, b);
            var slow = GuidMerge.SlowMerge(a, b);

            await Assert.That(fast).IsEqualTo(fair);
            await Assert.That(fast).IsEqualTo(slow);
            await Assert.That(fair).IsEqualTo(slow);

            await Assert.That(fast).IsNotEqualTo(a);
            await Assert.That(fast).IsNotEqualTo(b);
        }
    }
}
