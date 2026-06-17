using Logic.Core;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Logic.Tests;

public class ValueStopwatchTest
{
    [Test]
    public async Task StopwatchMeasuresElapsedTime()
    {
        var sw = Stopwatch.StartNew();
        Thread.Sleep(50);

        // Check that at least the minimum time has elapsed
        await Assert.That(sw.Elapsed.TotalMilliseconds >= 40).IsTrue();
    }

    [Test]
    public async Task ValueStopwatchMeasuresElapsedTime()
    {
        var sw = ValueStopwatch.StartNew();
        Thread.Sleep(50);

        // Check that at least the minimum time has elapsed
        await Assert.That(sw.GetElapsedTime().TotalMilliseconds >= 40).IsTrue();
    }

    [Test]
    public async Task ValueStopwatchTimeIncreases()
    {
        var sw = ValueStopwatch.StartNew();
        var first = sw.GetElapsedTime();

        Thread.Sleep(10);

        var second = sw.GetElapsedTime();

        // Ensure time has progressed
        await Assert.That(second > first).IsTrue();
    }
}