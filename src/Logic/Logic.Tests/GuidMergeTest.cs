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

            Assert.Equal(fair, fast);
            Assert.Equal(slow, fast);
            Assert.Equal(slow, fair);

            Assert.NotEqual(a, fast);
            Assert.NotEqual(b, fast);
        }
    }
}
