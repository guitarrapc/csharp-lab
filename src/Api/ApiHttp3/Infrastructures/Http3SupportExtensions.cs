using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace ApiHttp3.Infrastructures;

public static class Http3SupportExtensions
{
    /// <summary>
    /// Enable HTTP/3 support
    /// </summary>
    /// <param name="builder"></param>
    public static void ConfigureHttp3Endpoint(this WebApplicationBuilder builder)
    {
        // Enable HTTP/3
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(5001, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });
    }
}
