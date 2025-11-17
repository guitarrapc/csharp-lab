using System.Diagnostics;
using System.Runtime.InteropServices;
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

public static class StartupInfo
{
    private static string cpuModel = !string.IsNullOrWhiteSpace(CpuModel.Current.ModelName) ? CpuModel.Current.ModelName : CpuModel.Current.UnkownReason;

    /// <summary>
    /// Get and print startup information about the operating system and CPU.
    /// </summary>
    public static void Print()
    {
        // Example output:
        // ---------------------
        // Windows
        // ---------------------
        // Startup info:
        // * OS       : Microsoft Windows 10.0.26100
        // * CPU Arch : X64
        // * CPU Model: AMD Ryzen 9 7950X3D 16-Core Processor
        // * CPU Cores: 32
        //
        // ---------------------
        // Linux Ubuntu 24.04
        // ---------------------
        // Startup info:
        // * OS       : Ubuntu 24.04.3 LTS
        // * CPU Arch : X64
        // * CPU Model: AMD Ryzen 9 7950X3D 16 - Core Processor
        // * CPU Cores: 8
        //
        // ---------------------
        // macOS Sequoia 15.6.1
        // ---------------------
        // Startup info:
        // * OS       : macOS Sequoia 15.6.1
        // * CPU Arch : Arm64
        // * CPU Model: Apple M2
        // * CPU Cores: 8

        Console.WriteLine($$"""
        Startup info:
          * OS       : {{RuntimeInformation.OSDescription}}
          * CPU Arch : {{RuntimeInformation.ProcessArchitecture}}
          * CPU Model: {{cpuModel}}
          * CPU Cores: {{Environment.ProcessorCount}}
        """);
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
