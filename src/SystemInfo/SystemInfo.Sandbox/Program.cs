using System.Diagnostics;
using SystemInfo.Core;

var round = 3;
var eachDuration = 10;

StartupInfo.Print();
var reporter = new HardwarePerformanceReporter();
reporter.Start();

Console.WriteLine("""
| CPU(avg) | CPU(max) | Memory(avg) | Memory(max) |
| -------- | -------- | ----------- | ----------- |
""");
for (var i = 0; i < round; i++)
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(eachDuration));

    //Workload.TooMatch(cts.Token);
    Workload.Heavy(cts.Token);
    //Workload.Light(cts.Token);

    using var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));
    var suffix = $" <- begin ({i + 1})";
    try
    {
        while (await timer.WaitForNextTickAsync(cts.Token))
        {
            var result = reporter.GetResultAndClear();
            Console.WriteLine($"| {result.AvgCpuUsagePercent.ToString("#.00").PadLeft(7)}% | {result.MaxCpuUsagePercent.ToString("#.00").PadLeft(7)}% | {result.AvgMemoryUsageMB.ToString("#.00").PadLeft(9)}MB | {result.MaxMemoryUsageMB.ToString("#.00").PadLeft(9)}MB |" + suffix);
            suffix = "";
        }
    }
    catch (OperationCanceledException)
    {
    }
}

public static class Workload
{
    public static void Light(CancellationToken ct) => Run(Math.Min(Environment.ProcessorCount / 2, 2), ct);
    public static void Heavy(CancellationToken ct) => Run(Environment.ProcessorCount - 1, ct);
    public static void TooMatch(CancellationToken ct) => Run(Environment.ProcessorCount + 5, ct);

    private static void Run(int taskCount, CancellationToken ct)
    {
        for (var i = 0; i < taskCount; i++)
        {
            _ = Task.Run(() =>
            {
                while (!ct.IsCancellationRequested)
                {
                    Process.GetCurrentProcess();
                }
            }, ct);
        }

    }
}
