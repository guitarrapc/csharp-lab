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
        var logLevelStr = builder.Configuration.GetValue<string?>("CSHARPLAB_LOG_LEVEL") ?? "Information";
        var enableConsoleLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_CONSOLE_LOGGING") ?? true;
        var enableFileLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_FILE_LOGGING") ?? false;
        var enableStreamLogging = builder.Configuration.GetValue<bool?>("CSHARPLAB_ENABLE_STREAM_LOGGING") ?? false;
        var fileLoggingPath = builder.Configuration.GetValue<string?>("CSHARPLAB_FILE_LOGGING_PATH") ?? "./app.log";
        var streamLoggingHost = builder.Configuration.GetValue<string?>("CSHARPLAB_STREAM_LOGGING_HOST") ?? "127.0.0.1";
        var streamLoggingPort = builder.Configuration.GetValue<int?>("CSHARPLAB_STREAM_LOGGING_PORT") ?? 12345;

        builder.Services.AddLogging(configure =>
        {
            configure.ClearProviders();

            Console.WriteLine(@$"[Logging] Debugging Configuration:
  CSHARPLAB_LOG_LEVEL: {logLevelStr}
  CSHARPLAB_ENABLE_CONSOLE_LOGGING: {enableConsoleLogging}
  CSHARPLAB_ENABLE_FILE_LOGGING: {enableFileLogging}
  CSHARPLAB_ENABLE_STREAM_LOGGING: {enableStreamLogging}
  CSHARPLAB_FILE_LOGGING_PATH: {fileLoggingPath}
  CSHARPLAB_STREAM_LOGGING_HOST: {streamLoggingHost}
  CSHARPLAB_STREAM_LOGGING_PORT: {streamLoggingPort}");

            // Fatal, Error, Warning, Information, Debug, Trace
            if (Enum.TryParse<LogLevel>(logLevelStr, true, out var logLevel))
            {
                configure.SetMinimumLevel(logLevel);
            }

            // Console Logging
            if (enableConsoleLogging)
            {
                Console.WriteLine("[Logging] Console Logging Enabled.");
                configure.AddZLoggerConsole();
            }
            // File Logging
            if (enableFileLogging)
            {
                if (!string.IsNullOrEmpty(fileLoggingPath))
                {
                    Console.WriteLine($"[Logging] File Logging Enabled.");
                    configure.AddZLoggerFile(fileLoggingPath);
                }
            }
            // Stream Logging
            if (enableStreamLogging)
            {
                Console.WriteLine("[Logging] Stream Logging Enabled.");
                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.RetryableSocketConnect(streamLoggingHost, streamLoggingPort);
                var network = new NetworkStream(socket);
                configure.AddZLoggerStream(network);
            }
        });
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
                var sleep = (int)Math.Min(1 * Math.Pow(2, current -1), retryMaxSecond);
                Console.WriteLine($"Retry connecting socket. Host: {host}; Port: {port}; Retrying: {current}/{retryCount}; Sleep: {sleep}sec");
                Thread.Sleep(1000 * sleep);
            }
        } while (current <= retryCount);
    }
}
