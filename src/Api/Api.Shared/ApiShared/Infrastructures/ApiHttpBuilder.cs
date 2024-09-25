#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Net.Http.Headers;

namespace Api.Shared.ApiShared.Infrastructures;

public interface IApiHttpBuilder
{
    IServiceCollection Services { get; }
}
public class ApiHttpBuilder(IServiceCollection services) : IApiHttpBuilder
{
    public IServiceCollection Services { get; } = services;
}

public static class ApiHttpBuilderExtensions
{
    /// <summary>
    /// Enable HTTP/1 and HTTP/2 support
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="port"></param>
    /// <returns></returns>
    public static IApiHttpBuilder ConfigureHttp12Endpoint(this WebApplicationBuilder builder, int port = 5000)
    {
        builder.Logging.ConfigureSingleLineLogger();

        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
            });
        });

        return new ApiHttpBuilder(builder.Services);
    }

    /// <summary>
    /// Enable HTTP/3 support
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="port"></param>
    /// <returns></returns>
    public static IApiHttpBuilder ConfigureHttp3Endpoint(this WebApplicationBuilder builder, int port = 5001)
    {
        builder.Logging.ConfigureSingleLineLogger();

        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http3?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });

        return new ApiHttpBuilder(builder.Services);
    }

    /// <summary>
    /// Single line logger
    /// </summary>
    /// <param name="logger"></param>
    private static void ConfigureSingleLineLogger(this ILoggingBuilder logger)
    {
        logger.ClearProviders();
        logger.AddSimpleConsole(options =>
        {
            options.TimestampFormat = "yyyy-MM-ddTHH:mm:ss | ";
            options.SingleLine = true;
        });
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IApiHttpBuilder EnableSelfcheck<T>(this IApiHttpBuilder builder) where T : class
    {
        return builder.EnableSelfcheck<T>(_ => { });
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IApiHttpBuilder EnableSelfcheck<T>(this IApiHttpBuilder builder, Action<SelfcheckServiceOptions> configure) where T : class
    {
        var options = new SelfcheckServiceOptions();
        configure(options);
        builder.Services.AddSingleton(options);
        builder.Services.AddSingleton<ApiSelfcheckClient<T>>();
        builder.Services.AddHostedService<ApiSelfcheckBackgroundService<T>>();

        // Set HttpClient configuratioan
        builder.Services.AddHttpClient("SelfcheckHttp", static (sp, httpClient) =>
        {
            var op = sp.GetRequiredService<SelfcheckServiceOptions>();

            httpClient.BaseAddress = op.BaseAddress;
            httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
        });

        return builder;
    }
}
