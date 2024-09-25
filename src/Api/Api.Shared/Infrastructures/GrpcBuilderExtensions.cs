using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Shared.Infrastructures;

public interface IGrpcHttp2Builder
{
    IServiceCollection Services { get; }
}
public class GrpcHttp2Builder(IServiceCollection services) : IGrpcHttp2Builder
{
    public IServiceCollection Services { get; } = services;
}

public static class GrpcBuilderExtensions
{
    /// <summary>
    /// Enable HTTP/1 and HTTP/2 support
    /// </summary>
    /// <param name="builder"></param>
    public static IGrpcHttp2Builder ConfigureHttp2Endpoint(this WebApplicationBuilder builder, int port = 5159)
    {
        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                // gRPC is HTTP/2. Set Http2 to accept Insecure HTTP/2
                listenOptions.Protocols = HttpProtocols.Http2;
            });
        });

        return new GrpcHttp2Builder(builder.Services);
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IGrpcHttp2Builder EnableSelfcheck(this IGrpcHttp2Builder builder) => EnableSelfcheck(builder, _ => { });

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IGrpcHttp2Builder EnableSelfcheck(this IGrpcHttp2Builder builder, Action<SelfcheckServiceOptions> configure)
    {
        var options = new SelfcheckServiceOptions();
        configure(options);
        builder.Services.AddSingleton<SelfcheckServiceOptions>();
        builder.Services.AddSingleton<GrpcSelfcheckUnaryClient>();
        builder.Services.AddSingleton<GrpcSelfcheckDuplexClient>();
        builder.Services.AddHostedService<GrpcSelfcheckBackgroundService>();

        // Set GrpcChannel Pool
        builder.Services.AddSingleton<GrpcChannelPool>();

        return builder;
    }
}
