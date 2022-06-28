using LoggerBlazorApp.Data;
using LoggerBlazorApp.Middlewares;
using System.Net.Sockets;
using ZLogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLogging(configure =>
{
    configure.ClearProviders();

    var logLevelStr = Environment.GetEnvironmentVariable("CSHARPLAB_LOG_LEVEL", EnvironmentVariableTarget.Process) ?? "Information";
    var enableConsoleLogging = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_CONSOLE_LOGGING", EnvironmentVariableTarget.Process) ?? "true";
    var enableFileLogging = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_FILE_LOGGING", EnvironmentVariableTarget.Process) ?? "false";
    var enableStreamLogging = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_STREAM_LOGGING", EnvironmentVariableTarget.Process) ?? "false";
    var fileLoggingPath = Environment.GetEnvironmentVariable("CSHARPLAB_FILE_LOGGING_PATH", EnvironmentVariableTarget.Process) ?? $"./app.log";
    var streamLoggingHost = Environment.GetEnvironmentVariable("CSHARPLAB_STREAM_LOGGING_HOST", EnvironmentVariableTarget.Process) ?? "127.0.0.1";
    var streamLoggingPortStr = Environment.GetEnvironmentVariable("CSHARPLAB_STREAM_LOGGING_PORT", EnvironmentVariableTarget.Process) ?? "12345";

    Console.WriteLine(@$"[Logging] Debugging Configuration:
  CSHARPLAB_LOG_LEVEL: {logLevelStr}
  CSHARPLAB_ENABLE_CONSOLE_LOGGING: {enableConsoleLogging}
  CSHARPLAB_ENABLE_FILE_LOGGING: {enableFileLogging}
  CSHARPLAB_ENABLE_STREAM_LOGGING: {enableStreamLogging}
  CSHARPLAB_FILE_LOGGING_PATH: {fileLoggingPath}
  CSHARPLAB_STREAM_LOGGING_HOST: {streamLoggingHost}
  CSHARPLAB_STREAM_LOGGING_PORT: {streamLoggingPortStr}");

    // Fatal, Error, Warning, Information, Debug, Trace
    if (Enum.TryParse<LogLevel>(logLevelStr, true, out var logLevel))
    {
        configure.SetMinimumLevel(logLevel);
    }

    // Console Logging
    if (enableConsoleLogging == "true")
    {
        Console.WriteLine("[Logging] Console Logging Enabled.");
        configure.AddZLoggerConsole();
    }
    // File Logging
    if (enableFileLogging == "true")
    {
        if (!string.IsNullOrEmpty(fileLoggingPath))
        {
            Console.WriteLine($"[Logging] File Logging Enabled.");
            configure.AddZLoggerFile(fileLoggingPath);
        }
    }
    // Stream Logging
    if (enableStreamLogging == "true")
    {
        if (int.TryParse(streamLoggingPortStr, out var port))
        {
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.RetryableSocketConnect(streamLoggingHost, port);
            var network = new NetworkStream(socket);

            Console.WriteLine("[Logging] Stream Logging Enabled.");
            configure.AddZLoggerStream(network);
        }
    }
});
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
    public static void RetryableSocketConnect(this Socket socket, string host, int port, int retryCount = 5, int retryMaxSecond = 10)
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
                var sleep = (int)Math.Min(1 * Math.Pow(2, current -1), retryMaxSecond);
                Console.WriteLine($"Retry connecting socket. Host: {host}; Port: {port}; Current: {current++}; RetryLimit: {retryCount}; Sleep: {sleep}");
                Thread.Sleep(1000 * sleep);
            }
        } while (current <= retryCount);
    }
}
