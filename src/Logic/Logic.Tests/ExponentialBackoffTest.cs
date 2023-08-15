using System.Diagnostics;
using xRetry;

namespace Logic.Tests;

public class ExponentialBackoffTest
{
    // Almost stable, but delay's randomness happen on poor machine like GitHub Actions CI. Retry cover this situation.
    [RetryTheory]
    [InlineData(30, 500, new[] { 30.0, 60.0, 120.0, 240.0, 480.0, 500.0, 500.0 })]
    public async Task ExponentialBackOff30Test(int delayMs, int maxDelayMs, double[] expected)
    {
        var offset = 40; // shoganai
        using var cts = new CancellationTokenSource(); // cancel by test
        var backoff = new ExponentialBackoff(delayMs, maxDelayMs);
        var sw = Stopwatch.StartNew();
        long prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            await backoff.DelayAsync(cts.Token);
            var actual = sw.Elapsed.TotalMilliseconds - prev;
            (actual).Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    // Almost stable, but delay's randomness happen on poor machine like GitHub Actions CI. Retry cover this situation.
    [RetryTheory]
    [InlineData(100, 1000, new[] { 100.0, 200.0, 400.0, 800.0, 1000.0, 1000.0 })]
    public async Task ExponentialBackOff100Test(int delayMs, int maxDelayMs, double[] expected)
    {
        var offset = 40; // shoganai
        using var cts = new CancellationTokenSource(); // cancel by test
        var backoff = new ExponentialBackoff(delayMs, maxDelayMs);
        var sw = Stopwatch.StartNew();
        long prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            await backoff.DelayAsync(cts.Token);
            var actual = sw.Elapsed.TotalMilliseconds - prev;
            (actual).Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }
}
