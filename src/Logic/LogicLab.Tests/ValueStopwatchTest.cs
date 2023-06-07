using System.Diagnostics;

namespace LogicLab.Tests;

public class ValueStopwatchTest
{
    [Fact]
    public async Task StopwatchElapsedTest()
    {
        var offset = 45; // shoganai.
        var sw = Stopwatch.StartNew();
        Thread.Sleep(100);
        var actual1 = sw.Elapsed.TotalMilliseconds;
        actual1.Should().BeInRange(100, 100 + offset);
        Thread.Sleep(100);
        var actual2 = sw.Elapsed.TotalMilliseconds;
        actual2.Should().BeInRange(200, 200 + offset);
        Thread.Sleep(100);
        var actual3 = sw.Elapsed.TotalMilliseconds;
        actual3.Should().BeInRange(300, 300 + offset);
        Thread.Sleep(100);
        var actual4 = sw.Elapsed.TotalMilliseconds;
        actual4.Should().BeInRange(400, 400 + offset);
    }

    [Fact]
    public async Task ValueStopwatchElapsedTest()
    {
        var offset = 45; // shoganai.
        var sw = ValueStopwatch.StartNew();
        Thread.Sleep(100);
        var actual1 = sw.GetElapsedTime().TotalMilliseconds;
        actual1.Should().BeInRange(100, 100 + offset);
        Thread.Sleep(100);
        var actual2 = sw.GetElapsedTime().TotalMilliseconds;
        actual2.Should().BeInRange(200, 200 + offset);
        Thread.Sleep(100);
        var actual3 = sw.GetElapsedTime().TotalMilliseconds;
        actual3.Should().BeInRange(300, 300 + offset);
        Thread.Sleep(100);
        var actual4 = sw.GetElapsedTime().TotalMilliseconds;
        actual4.Should().BeInRange(400, 400 + offset);
    }
}
