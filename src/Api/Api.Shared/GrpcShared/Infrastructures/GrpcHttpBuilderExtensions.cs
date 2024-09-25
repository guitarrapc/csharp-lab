#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace Api.Shared.GrpcShared.Infrastructures;

public interface IGrpcHttpBuilder
{
    IServiceCollection Services { get; }
}
public class GrpcHttpBuilder(IServiceCollection services) : IGrpcHttpBuilder
{
    public IServiceCollection Services { get; } = services;
}

public static class GrpcHttpBuilderExtensions
{
    /// <summary>
    /// Enable HTTP/1 and HTTP/2 support
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="port"></param>
    /// <returns></returns>
    public static IGrpcHttpBuilder ConfigureHttp2Endpoint(this WebApplicationBuilder builder, int port = 5000)
    {
        builder.Logging.ConfigureSingleLineLogger();

        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                // gRPC is HTTP/2. Set Http2 to accept Insecure HTTP/2
                listenOptions.Protocols = HttpProtocols.Http2;
            });
        });

        return new GrpcHttpBuilder(builder.Services);
    }

    /// <summary>
    /// Enable HTTP/3 support
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="port"></param>
    /// <param name="useClientAuth"></param>
    /// <returns></returns>
    public static IGrpcHttpBuilder ConfigureHttp3Endpoint(this WebApplicationBuilder builder, int port = 5001)
    {
        builder.Logging.ConfigureSingleLineLogger();

        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });

        return new GrpcHttpBuilder(builder.Services);
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
    public static IGrpcHttpBuilder EnableSelfcheck(this IGrpcHttpBuilder builder) => builder.EnableSelfcheck(_ => { });

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IGrpcHttpBuilder EnableSelfcheck(this IGrpcHttpBuilder builder, Action<SelfcheckServiceOptions> configure)
    {
        var options = new SelfcheckServiceOptions();
        configure(options);
        builder.Services.AddSingleton(options);
        builder.Services.AddSingleton<GrpcSelfcheckUnaryClient>();
        builder.Services.AddSingleton<GrpcSelfcheckDuplexClient>();
        builder.Services.AddHostedService<GrpcSelfcheckBackgroundService>();

        return builder;
    }
}
