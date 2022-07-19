using Microsoft.Extensions.Logging;

namespace LoggerDefault;

public static partial class LogMessageSourceGenerator
{
    [LoggerMessage(EventId = 1001, Level = LogLevel.Information, Message = "This is a log message with paramters {First}, {Second}")]
    public static partial void LogSourceGenMessage(this ILogger logger, int first, int second);

    [LoggerMessage(EventId = 1001, Level = LogLevel.Information, Message = "This is a log message with paramters {First}, {Second}", SkipEnabledCheck = true)]
    public static partial void LogSourceGenMessageSkipEnableCheck(this ILogger logger, int first, int second);
}
