using System.Diagnostics;

namespace LoggerBlazorApp.Middlewares;

public static class AccessLoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseAccessLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<AccessLoggingMiddleware>();
    }
}

public class AccessLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<AccessLoggingMiddleware> _logger;

    public AccessLoggingMiddleware(RequestDelegate next, ILogger<AccessLoggingMiddleware> logger)
    {
        this._next = next;
        this._logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        var sw = Stopwatch.StartNew();

        await this._next(context);

        // Envoy Style
        // https://www.envoyproxy.io/docs/envoy/latest/configuration/observability/access_log/usage
        // [%START_TIME%] "%REQ(:METHOD)% %REQ(X-ENVOY-ORIGINAL-PATH?:PATH)% %PROTOCOL%"
        // %RESPONSE_CODE% %RESPONSE_FLAGS% %BYTES_RECEIVED% %BYTES_SENT% %DURATION%
        // %RESP(X-ENVOY-UPSTREAM-SERVICE-TIME) %"%REQ(X-FORWARDED-FOR)%" "%REQ(USER-AGENT)%"
        // "%REQ(X-REQUEST-ID)%" "%REQ(:AUTHORITY)%" "%UPSTREAM_HOST%"\n
        var duration = sw.Elapsed.TotalMilliseconds;
        sw.Stop();
        _logger.LogInformation("[{Now}] \"{Method} {Path} {Protocol}\" {StatusCode} - - - {Duration} - \"-\" \"{UserAgent}\" \"-\" \"-\" \"-\"", DateTime.Now, context.Request.Method, context.Request.Path, context.Request.Protocol, context.Response.StatusCode, duration, context.Request.Headers.UserAgent);
    }
}
