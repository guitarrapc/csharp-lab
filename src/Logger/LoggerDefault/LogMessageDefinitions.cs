using Microsoft.Extensions.Logging;

namespace LoggerDefault;

public static partial class LogMessageDefinitions
{
    private static readonly Action<ILogger, int, int, Exception?> workerRunningDefinition = LoggerMessage.Define<int, int>(LogLevel.Information, 1001, "This is a log message with paramters {First}, {Second}");

    public static void LogDefineMessage(this ILogger logger, int first, int second)
    {
        workerRunningDefinition(logger, first, second, null);
    }
}

