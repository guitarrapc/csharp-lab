using LoggerBlazorApp.Data;
using System.Net.Sockets;
using ZLogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLogging(configure =>
{
    configure.ClearProviders();

    var logLevelStr = Environment.GetEnvironmentVariable("CSHARPLAB_LOG_LEVEL", EnvironmentVariableTarget.Process) ?? "Information";
    var enableConsoleLoggingStr = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_CONSOLE_LOGGING", EnvironmentVariableTarget.Process) ?? "true";
    var enableFileLoggingStr = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_FILE_LOGGING", EnvironmentVariableTarget.Process) ?? "false";
    var enableStreamLoggingStr = Environment.GetEnvironmentVariable("CSHARPLAB_ENABLE_STREAM_LOGGING", EnvironmentVariableTarget.Process) ?? "false";
    var fileLoggingPath = Environment.GetEnvironmentVariable("CSHARPLAB_FILE_LOGGING_PATH", EnvironmentVariableTarget.Process) ?? $"./app.log";
    var streamLoggingHost = Environment.GetEnvironmentVariable("CSHARPLAB_STREAM_LOGGING_HOST", EnvironmentVariableTarget.Process) ?? "127.0.0.1";
    var streamLoggingPortStr = Environment.GetEnvironmentVariable("CSHARPLAB_STREAM_LOGGING_PORT", EnvironmentVariableTarget.Process) ?? "12345";

    Console.WriteLine(@$"[Logging] Debugging Configuration:
  CSHARPLAB_LOG_LEVEL: {logLevelStr}
  CSHARPLAB_ENABLE_CONSOLE_LOGGING: {enableConsoleLoggingStr}
  CSHARPLAB_ENABLE_FILE_LOGGING: {enableFileLoggingStr}
  CSHARPLAB_ENABLE_STREAM_LOGGING: {enableStreamLoggingStr}
  CSHARPLAB_FILE_LOGGING_PATH: {fileLoggingPath}
  CSHARPLAB_STREAM_LOGGING_HOST: {streamLoggingHost}
  CSHARPLAB_STREAM_LOGGING_PORT: {streamLoggingPortStr}");

    // Fatal, Error, Warning, Information, Debug, Trace
    if (Enum.TryParse<LogLevel>(logLevelStr, true, out var logLevel))
    {
        configure.SetMinimumLevel(logLevel);
    }

    // Console Logging
    if (enableConsoleLoggingStr == "true")
    {
        Console.WriteLine("[Logging] Console Logging Enabled.");
        configure.AddZLoggerConsole();
    }
    // File Logging
    if (enableFileLoggingStr == "true")
    {
        if (!string.IsNullOrEmpty(fileLoggingPath))
        {
            Console.WriteLine($"[Logging] File Logging Enabled.");
            configure.AddZLoggerFile(fileLoggingPath);
        }
    }
    // Stream Logging
    if (enableStreamLoggingStr == "true")
    {
        if (!int.TryParse(streamLoggingPortStr, out var port))
        {
            var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(streamLoggingHost, port);
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
