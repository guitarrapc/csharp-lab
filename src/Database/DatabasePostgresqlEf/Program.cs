using DatabasePostgresqlEf;
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
builder.ConfigureLogging((hostContext, logging) =>
{
    logging.ClearProviders();
    logging.AddZLoggerConsole();
});

var app = builder.Build();
app.Run();
