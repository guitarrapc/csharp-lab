using System.Diagnostics;

namespace LogicLab.Tests;

public class ValueTaskDelayTest
{
    [Fact]
    public async Task TaskDelayElapsedTest()
    {
        var offset = 50; // shoganai.
        var sw = Stopwatch.StartNew();
        await Task.Delay(100);
        var actual1 = sw.Elapsed.TotalMilliseconds;
        actual1.Should().BeInRange(100, 100 + offset);
        await Task.Delay(100);
        var actual2 = sw.Elapsed.TotalMilliseconds;
        actual2.Should().BeInRange(200, 200 + offset);
        await Task.Delay(100);
        var actual3 = sw.Elapsed.TotalMilliseconds;
        actual3.Should().BeInRange(300, 300 + offset);
        await Task.Delay(100);
        var actual4 = sw.Elapsed.TotalMilliseconds;
        actual4.Should().BeInRange(400, 400 + offset);
    }

    [Fact]
    public async Task ValueTaskDelayElapsedTest()
    {
        var offset = 45; // shoganai.
        var sw = Stopwatch.StartNew();
        await ValueTaskExtension.Delay(100);
        var actual1 = sw.Elapsed.TotalMilliseconds;
        actual1.Should().BeInRange(100, 100 + offset);
        await ValueTaskExtension.Delay(100);
        var actual2 = sw.Elapsed.TotalMilliseconds;
        actual2.Should().BeInRange(200, 200 + offset);
        await ValueTaskExtension.Delay(100);
        var actual3 = sw.Elapsed.TotalMilliseconds;
        actual3.Should().BeInRange(300, 300 + offset);
        await ValueTaskExtension.Delay(100);
        var actual4 = sw.Elapsed.TotalMilliseconds;
        actual4.Should().BeInRange(400, 400 + offset);
    }

    [Fact]
    public async Task ValueTaskDelayTimeoutTest()
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(500));
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await ValueTaskExtension.Delay(TimeSpan.FromMilliseconds(1000), cts.Token));
    }
}
