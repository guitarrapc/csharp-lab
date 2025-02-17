using Logic.Core;
using System.Diagnostics;
using xRetry;

namespace Logic.Tests;

public class ValueTaskDelayTest
{
    // Almost stable, but delay's randomness happen on poor machine like GitHub Actions CI. Retry cover this situation.
    [RetryTheory]
    [InlineData(new[] { 100.0, 100.0, 100.0, 100.0 })]
    public async Task TaskDelayElapsedTest(double[] expected)
    {
        var offset = 45; // shoganai.
        var sw = Stopwatch.StartNew();

        double prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            await Task.Delay(100);
            var actual = sw.Elapsed.TotalMilliseconds - prev;
            Assert.InRange(actual, expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    // Almost stable, but delay's randomness happen on poor machine like GitHub Actions CI. Retry cover this situation.
    [RetryTheory]
    [InlineData(new[] { 100.0, 100.0, 100.0, 100.0 })]
    public async Task ValueTaskDelayElapsedTest(double[] expected)
    {
        var offset = 45; // shoganai.
        var sw = Stopwatch.StartNew();

        double prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            await ValueTaskExtension.Delay(100);
            var actual = sw.Elapsed.TotalMilliseconds - prev;
            Assert.InRange(actual, expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    [Fact]
    public async Task ValueTaskDelayTimeoutTest()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100));
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await ValueTaskExtension.Delay(TimeSpan.FromMilliseconds(1000), cts.Token));
    }
}
