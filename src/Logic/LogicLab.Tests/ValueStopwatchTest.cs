namespace LogicLab.Tests;

public class ValueStopwatchTest
{
    [Fact]
    public async Task StopwatchTest()
    {
        var offset = 40; // shoganai.
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
