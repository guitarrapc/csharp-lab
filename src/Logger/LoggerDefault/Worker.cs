namespace DefaultLogger;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        LogMessageParameter();
        LogMessageTemplateFormatting();
        LogException(1);

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }

    private void LogMessageParameter()
    {
        // Logger with Parameter use Placeholder & Parameter Name binding.
        var p1 = "param1";
        var p2 = "param2";
        _logger.LogInformation("Parameter values: {p2}, {p1}", p1, p2);

        // Other type can use as parameter. If PlaceHolder is not Parameter Name, inject via order.
        var id = Guid.NewGuid();
        _logger.LogInformation("Getting item {Id} at {RunTime}", id, DateTime.Now);
    }

    private void LogMessageTemplateFormatting()
    {
        // Placeholder can use formatting. In this case "MMMM dd, yyyy" date format.
        _logger.LogInformation("Logged on {PlaceHolderName:MMMM dd, yyyy}", DateTimeOffset.UtcNow);
    }

    private void LogException(int id)
    {
        try
        {
            if (id == 1)
            {
                throw new Exception("Default Id detected.");
            }
        }
        catch (Exception ex)
        {
            _logger.LogWarning(SampleEventId.UserModelError, ex, "Failed to process iteration: {Id}", id);
        }
    }
}

public static class SampleEventId
{
    public static int Foo = 1000;
    public static int Bar = 1001;
    public static int Piyo = 1002;

    public static int UserModelCreate = 1100;
    public static int UserModelUpdate = 1101;
    public static int UserModelDelete = 1102;
    public static int UserModelError = 1199;
}
