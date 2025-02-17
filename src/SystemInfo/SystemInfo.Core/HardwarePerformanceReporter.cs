using System.Collections.Concurrent;
using System.Diagnostics;

namespace SystemInfo.Core;

public class HardwarePerformanceReporter
{
    private readonly TimeSpan _samplingInterval;
    private readonly TimeProvider _timeProvider;
    private readonly Process _currentProcess;
    private readonly int _cpuCores;
    private readonly ConcurrentBag<double> _cpuUsages;
    private readonly ConcurrentBag<double> _memoryUsages;
    private CancellationTokenSource _cancellationTokenSource;
    private bool _running;

    public HardwarePerformanceReporter() : this(TimeProvider.System, TimeSpan.FromMilliseconds(100))
    { }

    public HardwarePerformanceReporter(TimeProvider timeProvider, TimeSpan samplingInterval)
    {
        _samplingInterval = samplingInterval;
        _timeProvider = timeProvider;
        _currentProcess = Process.GetCurrentProcess();
        _cpuCores = Environment.ProcessorCount;
        _cpuUsages = new ConcurrentBag<double>();
        _memoryUsages = new ConcurrentBag<double>();
        _cancellationTokenSource = new CancellationTokenSource();
    }

    public void Start()
    {
        _running = true;
        var prevMemory = _currentProcess.WorkingSet64;
        Task.Run(async () =>
        {
            while (_running)
            {
                // begin
                var start = _timeProvider.GetTimestamp();
                TimeSpan startCpuTime = _currentProcess.TotalProcessorTime;
                await Task.Delay(_samplingInterval, _cancellationTokenSource.Token).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

                if (_cancellationTokenSource.IsCancellationRequested) break;

                // end
                TimeSpan endCpuTime = _currentProcess.TotalProcessorTime;
                var duration = _timeProvider.GetElapsedTime(start);

                // CPU usage
                var cpuUsedMs = (endCpuTime - startCpuTime).TotalMilliseconds;
                var totalMsPassed = duration.TotalMilliseconds;
                var cpuUsagePercentage = (cpuUsedMs / (totalMsPassed * _cpuCores)) * 100;
                _cpuUsages.Add(cpuUsagePercentage);

                // Memory usage = working set
                var currentMemory = _currentProcess.WorkingSet64;
                _memoryUsages.Add(currentMemory);
            }
        }, _cancellationTokenSource.Token).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
    }

    public void Stop()
    {
        _running = false;
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();
    }

    public HardwarePerformanceResult GetResult()
    {
        var filteredCpuUsages = OutlinerHelper.RemoveOutlinerByIQR(_cpuUsages.ToArray(), 100.0);
        var maxCpuUsage = _cpuUsages.Count > 0 ? filteredCpuUsages.Max() : 0d;
        var avgCpuUsage = _cpuUsages.Count > 0 ? filteredCpuUsages.Average() : 0d;
        var maxMemoryUsage = _memoryUsages.Count > 0 ? _memoryUsages.Max() / 1024 / 1024 : 0d;
        var avgMemoryUsage = _memoryUsages.Count > 0 ? _memoryUsages.Average() / 1024 / 1024 : 0d;

        return new HardwarePerformanceResult(maxCpuUsage, avgCpuUsage, maxMemoryUsage, avgMemoryUsage);
    }

    public HardwarePerformanceResult GetResultAndClear()
    {
        var result = GetResult();
        _cpuUsages.Clear();
        _memoryUsages.Clear();

        return result;
    }
}

public record HardwarePerformanceResult(double MaxCpuUsagePercent, double AvgCpuUsagePercent, double MaxMemoryUsageMB, double AvgMemoryUsageMB);
