using DatabaseSqliteInmemoryEF;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ZLogger;

var builder = Host.CreateDefaultBuilder(args);

// Add Application Logics.
builder.ConfigureServices((hostContext, services) =>
{
    services.AddCsharpLabService(hostContext.Configuration);
});

// Swap logger with ZLogger
builder.ConfigureZLoggerLogging();

var app = builder.Build();
app.Run();

public static class StartupExtensions
{
    public static void ConfigureZLoggerLogging(this IHostBuilder builder)
    {
        builder.ConfigureLogging((hostContext, logging) =>
        {
            logging.ClearProviders();
            logging.AddZLoggerConsole();
        });
    }
}
