using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace LoggerDefault;

public static class NullLoggerExtensions
{
    public static ILoggingBuilder AddNullLogger(this ILoggingBuilder builder)
    {
        builder.Services.AddSingleton<NullLoggerProvider>();
        return builder;
    }
}
