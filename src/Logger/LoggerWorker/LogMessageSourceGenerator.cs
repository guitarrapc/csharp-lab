using System.Diagnostics;

namespace LoggerWorker;

// see: https://andrewlock.net/exploring-dotnet-6-part-8-improving-logging-performance-with-source-generators/
public partial class LogMessageSourceGenerator : BackgroundService
{
    private readonly string _workerName;
    private readonly ILogger<LogMessageSourceGenerator> _logger;
    private readonly Stopwatch _stopwatch;

    public LogMessageSourceGenerator(ILoggerFactory loggerFactory)
    {
        _workerName = Guid.NewGuid().ToString();
        _logger = loggerFactory.CreateLogger<LogMessageSourceGenerator>();
        _stopwatch = Stopwatch.StartNew();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        WorkerStarted(_workerName);
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.WorkerRunning(_workerName, _stopwatch.Elapsed.TotalSeconds);
                _logger.LogWorkerRunningMessage(_workerName, _stopwatch.Elapsed);
                await Task.Delay(1000, stoppingToken);
            }
        }
        catch (OperationCanceledException)
        {
        }
        finally
        {
            WorkerStopped(_workerName);
        }
    }

    [LoggerMessage(EventId = 100, Level = LogLevel.Information, Message = "Begin worker {WorkerName}.")]
    partial void WorkerStarted(string workerName);

    [LoggerMessage(EventId = 101, Level = LogLevel.Information, Message = "Stop worker {WorkerName}.")]
    partial void WorkerStopped(string workerName);
}

public static partial class LogMessageDefinitions
{
    private static readonly Action<ILogger, string, double, Exception?> workerRunningDefinition = LoggerMessage.Define<string, double>(LogLevel.Information, 1001, "Worker running {workerName} for {elapsedSeconds}sec.");

    public static void LogWorkerRunningMessage(this ILogger logger, string workerName, TimeSpan elapsed)
    {
        workerRunningDefinition(logger, workerName, elapsed.TotalSeconds, null);
    }
}

public static partial class LogMessageGenerator
{
    [LoggerMessage(EventId = 1001, Level = LogLevel.Information, Message = "Worker running {workerName} for {elapsedSeconds}sec.")]
    public static partial void WorkerRunning(this ILogger logger, string workerName, double elapsedSeconds);
}
