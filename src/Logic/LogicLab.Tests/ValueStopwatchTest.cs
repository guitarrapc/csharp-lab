using System.Diagnostics;
using xRetry;

namespace LogicLab.Tests;

public class ValueStopwatchTest
{
    [RetryTheory]
    [InlineData(new[] { 100.0, 100.0, 100.0, 100.0 })]
    public async Task StopwatchElapsedTest(double[] expected)
    {
        var offset = 40; // shoganai.
        var sw = Stopwatch.StartNew();

        double prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            Thread.Sleep(100);
            var actual = sw.Elapsed.TotalMilliseconds - prev;
            actual.Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.ElapsedMilliseconds;
        }
    }

    [RetryTheory]
    [InlineData(new[] { 100.0, 100.0, 100.0, 100.0 })]
    public async Task ValueStopwatchElapsedTest(double[] expected)
    {
        var offset = 40; // shoganai.
        var sw = ValueStopwatch.StartNew();

        double prev = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            Thread.Sleep(100);
            var actual = sw.GetElapsedTime().TotalMilliseconds - prev;
            actual.Should().BeInRange(expected[i] - 5, expected[i] + offset);
            prev = sw.GetElapsedTime().TotalMilliseconds;
        }
    }
}
