using Logic.Core;

namespace Logic.Tests;

public class ValueTaskDelayTest
{
    [Fact]
    public async Task TaskDelayElapsedTest()
    {
        await Task.Delay(100);
        Assert.True(true);
    }

    [Fact]
    public async Task ValueTaskDelayElapsedTest()
    {
        await ValueTaskExtension.Delay(100);
        Assert.True(true);
    }

    [Fact]
    public async Task ValueTaskDelayTimeoutTest()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100));
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await ValueTaskExtension.Delay(TimeSpan.FromMilliseconds(1000), cts.Token));
    }
}
