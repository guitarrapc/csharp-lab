using Cysharp.Text;
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
            logging.AddZLoggerConsole(options =>
            {
#if DEBUG
                // \u001b[31m => Red(ANSI Escape Code)
                // \u001b[0m => Reset
                // \u001b[38;5;***m => 256 Colors(08 is Gray)
                options.PrefixFormatter = (writer, info) =>
                {
                    if (info.LogLevel == LogLevel.Error)
                    {
                        ZString.Utf8Format(writer, "\u001b[31m{0}|{1}|", DateTime.Now, info.LogLevel);
                    }
                    else
                    {
                        if (info.CategoryName is "Microsoft.EntityFrameworkCore.Database.Command")
                        {
                            // Bit darker then application
                            ZString.Utf8Format(writer, "\u001b[38;5;246m{0}|{1}|", DateTime.Now, info.LogLevel);
                        }
                        else if (!info.CategoryName.StartsWith("DatabaseSqliteInmemoryEF")) // your application namespace.
                        {
                            // dim coloring
                            ZString.Utf8Format(writer, "\u001b[38;5;08m{0}|{1}|", DateTime.Now, info.LogLevel);
                        }
                        else
                        {
                            // Application show with no color control.
                            ZString.Utf8Format(writer, "{0}|{1}|", DateTime.Now, info.LogLevel);
                        }
                    }
                };
                options.SuffixFormatter = (writer, info) =>
                {
                    if (info.LogLevel == LogLevel.Error || !info.CategoryName.StartsWith("MyApp"))
                    {
                        ZString.Utf8Format(writer, "\u001b[0m", "");
                    }
                };
#endif
            }, configureEnableAnsiEscapeCode: true);
        });
    }
}
