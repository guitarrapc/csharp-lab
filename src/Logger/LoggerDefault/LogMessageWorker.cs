namespace LoggerDefault;

// see: https://andrewlock.net/exploring-dotnet-6-part-8-improving-logging-performance-with-source-generators/
public partial class LogMessageWorker : BackgroundService
{
    private readonly string _workerName;
    private readonly ILogger<LogMessageWorker> _logger;

    public LogMessageWorker(ILoggerFactory loggerFactory)
    {
        _workerName = Guid.NewGuid().ToString();
        _logger = loggerFactory.CreateLogger<LogMessageWorker>();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        WorkerStarted(_workerName);
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
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
