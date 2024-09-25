#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace Api.Shared.GrpcShared.Infrastructures;

public interface IGrpcHttp3Builder
{
    IServiceCollection Services { get; }
}
public class GrpcHttp3Builder(IServiceCollection services) : IGrpcHttp3Builder
{
    public IServiceCollection Services { get; } = services;
}

public static class GrpcHttp3BuilderExtensions
{
    /// <summary>
    /// Enable HTTP/1 and HTTP/2 support
    /// </summary>
    /// <param name="builder"></param>
    public static IGrpcHttp3Builder ConfigureHttp3Endpoint(this WebApplicationBuilder builder, int port = 5001, bool useClientAuth = false)
    {
        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });

        return new GrpcHttp3Builder(builder.Services);
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IGrpcHttp3Builder EnableSelfcheck(this IGrpcHttp3Builder builder) => builder.EnableSelfcheck(_ => { });

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IGrpcHttp3Builder EnableSelfcheck(this IGrpcHttp3Builder builder, Action<SelfcheckServiceOptions> configure)
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
