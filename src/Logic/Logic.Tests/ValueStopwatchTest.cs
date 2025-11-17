using Logic.Core;
using System.Diagnostics;

namespace Logic.Tests;

public class ValueStopwatchTest
{
    [Fact]
    public void StopwatchMeasuresElapsedTime()
    {
        var sw = Stopwatch.StartNew();
        Thread.Sleep(50);

        // Check that at least the minimum time has elapsed
        Assert.True(sw.Elapsed.TotalMilliseconds >= 40);
    }

    [Fact]
    public void ValueStopwatchMeasuresElapsedTime()
    {
        var sw = ValueStopwatch.StartNew();
        Thread.Sleep(50);

        // Check that at least the minimum time has elapsed
        Assert.True(sw.GetElapsedTime().TotalMilliseconds >= 40);
    }

    [Fact]
    public void ValueStopwatchTimeIncreases()
    {
        var sw = ValueStopwatch.StartNew();
        var first = sw.GetElapsedTime();

        Thread.Sleep(10);

        var second = sw.GetElapsedTime();

        // Ensure time has progressed
        Assert.True(second > first);
    }
}
