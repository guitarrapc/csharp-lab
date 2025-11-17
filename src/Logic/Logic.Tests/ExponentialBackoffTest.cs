using Logic.Core;
using System.Diagnostics;

namespace Logic.Tests;

public class ExponentialBackoffTest
{
    [Fact]
    public async Task ExponentialBackoffCompletesAllSteps()
    {
        using var cts = new CancellationTokenSource();
        var backoff = new ExponentialBackoff(10, 100);

        // Assume that 6 retries will complete without exceptions
        for (var i = 0; i < 6; i++)
        {
            await backoff.DelayAsync(cts.Token);
        }

        Assert.True(true);
    }

    [Fact]
    public async Task ExponentialBackoffRespectsCancellation()
    {
        using var cts = new CancellationTokenSource(50);
        var backoff = new ExponentialBackoff(1000, 5000);

        await Assert.ThrowsAsync<OperationCanceledException>(async () => await backoff.DelayAsync(cts.Token));
    }

    [Fact]
    public async Task ExponentialBackoffRespectsMaxRetries()
    {
        using var cts = new CancellationTokenSource();
        var backoff = new ExponentialBackoff(10, 100, maxRetries: 3);

        for (var i = 0; i < 3; i++)
        {
            await backoff.DelayAsync(cts.Token);
        }

        await Assert.ThrowsAsync<OperationCanceledException>(async () => await backoff.DelayAsync(cts.Token));
    }

    [Fact]
    public async Task ExponentialBackoffRespectsTimeout()
    {
        using var cts = new CancellationTokenSource();
        var backoff = new ExponentialBackoff(100, 1000, timeout: TimeSpan.FromMilliseconds(250));

        await backoff.DelayAsync(cts.Token);
        await backoff.DelayAsync(cts.Token);

        await Assert.ThrowsAsync<OperationCanceledException>(async () => await backoff.DelayAsync(cts.Token));
    }
}
