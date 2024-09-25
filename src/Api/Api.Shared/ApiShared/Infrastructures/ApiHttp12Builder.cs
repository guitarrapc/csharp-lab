using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace Api.Shared.ApiShared.Infrastructures;

public interface IApiHttp12Builder
{
    IServiceCollection Services { get; }
}
public class ApiHttp12Builder(IServiceCollection services) : IApiHttp12Builder
{
    public IServiceCollection Services { get; } = services;
}

public static class ApiHttp12BuilderExtensions
{
    /// <summary>
    /// Enable HTTP/1 and HTTP/2 support
    /// </summary>
    /// <param name="builder"></param>
    public static IApiHttp12Builder ConfigureHttp12Endpoint(this WebApplicationBuilder builder, int port = 5000)
    {
        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
            });
        });

        return new ApiHttp12Builder(builder.Services);
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static IApiHttp12Builder EnableSelfcheck<T>(this IApiHttp12Builder builder) where T : class
    {
        return builder.EnableSelfcheck<T>(_ => { });
    }

    /// <summary>
    /// Add Server connection selfcheck background service.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IApiHttp12Builder EnableSelfcheck<T>(this IApiHttp12Builder builder, Action<SelfcheckServiceOptions> configure) where T : class
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
