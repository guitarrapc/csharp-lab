using Logic.Core;

namespace Logic.Tests;

public class ValueTaskDelayTest
{
    [Test]
    public async Task TaskDelayElapsedTest(CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken);
    }

    [Test]
    public async Task ValueTaskDelayElapsedTest(CancellationToken cancellationToken)
    {
        await ValueTaskExtension.Delay(100, cancellationToken);
    }

    [Test]
    public async Task ValueTaskDelayTimeoutTest()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100));
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await ValueTaskExtension.Delay(TimeSpan.FromMilliseconds(1000), cts.Token));
    }
}
