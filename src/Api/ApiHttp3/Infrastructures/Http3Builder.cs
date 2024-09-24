using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Net.Http.Headers;

namespace ApiHttp3.Infrastructures;

public interface IHttp3Builder
{
    IServiceCollection Services { get; }
}
public class Http3Builder(IServiceCollection services) : IHttp3Builder
{
    public IServiceCollection Services { get; } = services;
}

public static class Http3BuilderExtensions
{
    /// <summary>
    /// Enable HTTP/3 support
    /// </summary>
    /// <param name="builder"></param>
    public static IHttp3Builder ConfigureHttp3Endpoint(this WebApplicationBuilder builder, int port = 5001)
    {
        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http3?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });

        return new Http3Builder(builder.Services);
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IHttp3Builder EnableSelfcheck(this IHttp3Builder builder)
    {
        builder.Services.AddSingleton<SelfcheckServiceOptions>();
        builder.Services.AddSingleton<SelfcheckHttp3Client>();
        builder.Services.AddHostedService<SelfcheckBackgroundService>();

        // Set HttpClient configuratioan
        builder.Services.AddHttpClient("SelfcheckHttp3", static (sp, httpClient) =>
        {
            var op = sp.GetRequiredService<SelfcheckServiceOptions>();

            httpClient.BaseAddress = op.BaseAddress;
            httpClient.DefaultRequestVersion = new Version(3, 0);
            httpClient.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;
            httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
        })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                // allow self certificate
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
            });

        return builder;
    }
}
