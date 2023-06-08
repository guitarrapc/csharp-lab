using System.Diagnostics;

namespace LogicLab.Tests;

public class ValueTaskDelayTest
{
    [Theory]
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
            actual.Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    [Theory]
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
            actual.Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    [Fact]
    public async Task ValueTaskDelayTimeoutTest()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(500));
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await ValueTaskExtension.Delay(TimeSpan.FromMilliseconds(1000), cts.Token));
    }
}
