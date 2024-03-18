using LoggerBlazorApp.Data;
using LoggerBlazorApp.Middlewares;
using System.Net.Sockets;
using ZLogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.ConfigureLogging();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

app.UseAccessLogging();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

public static class LoggingExtentions
{
    public static void ConfigureLogging(this WebApplicationBuilder builder)
    {
        var structuredLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ZLOGGER_ENABLESTRUCTUREDLOGGING") ?? false;
        var logLevelStr = builder.Configuration.GetValue<string?>("CSHARPLAB_LOG_LEVEL") ?? "Information";
        var enableConsoleLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_CONSOLE_LOGGING") ?? true;
        var enableFileLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_FILE_LOGGING") ?? false;
        var enableStreamLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_STREAM_LOGGING") ?? false;
        var fileLoggingPath = builder.Configuration.GetValue<string?>("CSHARPLAB_FILE_LOGGING_PATH") ?? "./app.log";
        var streamLoggingHost = builder.Configuration.GetValue<string?>("CSHARPLAB_STREAM_LOGGING_HOST") ?? "127.0.0.1";
        var streamLoggingPort = builder.Configuration.GetValue<int?>("CSHARPLAB_STREAM_LOGGING_PORT") ?? 10518;

        Console.WriteLine(@$"[Logging] Debugging Configuration:
  CSHARPLAB_LOG_LEVEL: {logLevelStr}
  CSHARPLAB_ENABLE_CONSOLE_LOGGING: {enableConsoleLogging}
  CSHARPLAB_ENABLE_FILE_LOGGING: {enableFileLogging}
  CSHARPLAB_ENABLE_STREAM_LOGGING: {enableStreamLogging}
  CSHARPLAB_FILE_LOGGING_PATH: {fileLoggingPath}
  CSHARPLAB_STREAM_LOGGING_HOST: {streamLoggingHost}
  CSHARPLAB_STREAM_LOGGING_PORT: {streamLoggingPort}");

        builder.Logging.ClearProviders();
        // Fatal, Error, Warning, Information, Debug, Trace
        if (Enum.TryParse<LogLevel>(logLevelStr, true, out var logLevel))
        {
            builder.Logging.SetMinimumLevel(logLevel);
        }

        // Console Logging
        if (enableConsoleLogging)
        {
            Console.WriteLine("[Logging] Console Logging Enabled.");
            builder.Logging.AddZLoggerConsole(configure =>
            {
                configure.SetZLoggerFormatter(structuredLogging, true);
            });
        }
        // File Logging
        if (enableFileLogging)
        {
            if (!string.IsNullOrEmpty(fileLoggingPath))
            {
                Console.WriteLine($"[Logging] File Logging Enabled.");
                builder.Logging.AddZLoggerFile(fileLoggingPath, configure => configure.SetZLoggerFormatter(structuredLogging));
            }
        }
        // Stream Logging
        if (enableStreamLogging)
        {
            Console.WriteLine("[Logging] Stream Logging Enabled.");
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.RetryableSocketConnect(streamLoggingHost, streamLoggingPort);
            var network = new NetworkStream(socket);
            builder.Logging.AddZLoggerStream(network, configure => configure.SetZLoggerFormatter(structuredLogging));
        }
    }

    private static void RetryableSocketConnect(this Socket socket, string host, int port, int retryCount = 5, int retryMaxSecond = 10)
    {
        var current = 1;
        do
        {
            try
            {
                socket.Connect(host, port);
                break;
            }
            catch (SocketException) when (current < retryCount)
            {
                current++;
                var sleep = (int)Math.Min(1 * Math.Pow(2, current - 1), retryMaxSecond);
                Console.WriteLine($"Retry connecting socket. Host: {host}; Port: {port}; Retrying: {current}/{retryCount}; Sleep: {sleep}sec");
                Thread.Sleep(1000 * sleep);
            }
        } while (current <= retryCount);
    }
}

public static class ZLoggerOptionExtensions
{
    public static void SetZLoggerFormatter(this ZLoggerOptions options, bool structuredLogging, bool useConsoleColor = false)
    {
        if (structuredLogging)
        {
            options.UseJsonFormatter();
        }
        else
        {
            options.UsePlainTextFormatter(formatter =>
            {
                if (useConsoleColor)
                {
                    // \u001b[31m => Red(ANSI Escape Code)
                    // \u001b[0m => Reset
                    // \u001b[38;5;***m => 256 Colors(08 is Gray)
                    formatter.SetPrefixFormatter($"{0}{1}|{2:short}|", (in MessageTemplate writer, in LogInfo info) =>
                    {
                        var escapeSequence = "";
                        if (info.LogLevel >= LogLevel.Error)
                        {
                            escapeSequence = "\u001b[31m";
                        }
                        else if (!info.Category.Name.Contains("MyApp"))
                        {
                            escapeSequence = "\u001b[38;5;08m";
                        }

                        writer.Format(escapeSequence, info.Timestamp, info.LogLevel);
                    });

                    formatter.SetSuffixFormatter($"{0}", (in MessageTemplate writer, in LogInfo info) =>
                    {
                        if (info.LogLevel == LogLevel.Error || !info.Category.Name.Contains("MyApp"))
                        {
                            writer.Format("\u001b[0m");
                        }
                    });
                }
            });
        }
    }
}
