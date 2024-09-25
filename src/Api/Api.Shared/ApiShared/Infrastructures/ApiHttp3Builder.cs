using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace Api.Shared.ApiShared.Infrastructures;

public interface IApiHttp3Builder
{
    IServiceCollection Services { get; }
}
public class ApiHttp3Builder(IServiceCollection services) : IApiHttp3Builder
{
    public IServiceCollection Services { get; } = services;
}

public static class ApiHttp3BuilderExtensions
{
    /// <summary>
    /// Enable HTTP/3 support
    /// </summary>
    /// <param name="builder"></param>
    public static IApiHttp3Builder ConfigureHttp3Endpoint(this WebApplicationBuilder builder, int port = 5001)
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

        return new ApiHttp3Builder(builder.Services);
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IApiHttp3Builder EnableSelfcheck<T>(this IApiHttp3Builder builder) where T : class
    {
        return builder.EnableSelfcheck<T>(_ => { });
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IApiHttp3Builder EnableSelfcheck<T>(this IApiHttp3Builder builder, Action<SelfcheckServiceOptions> configure) where T : class
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
