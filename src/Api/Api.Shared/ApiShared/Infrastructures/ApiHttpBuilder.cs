#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

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
    /// TLS File for HTTPS Listener
    /// </summary>
    /// <param name="PfxFileName"></param>
    /// <param name="Password"></param>
    internal record TlsFile(string PfxFileName, string Password)
    {
        public static TlsFile Default = new TlsFile("Certs/server1.pfx", "1111");
    }

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
                if (port == 5001)
                {
                    var basePath = Path.GetDirectoryName(AppContext.BaseDirectory);
                    var certPath = Path.Combine(basePath!, TlsFile.Default.PfxFileName);
                    listenOptions.UseHttps(certPath, TlsFile.Default.Password);
                }
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

        var basePath = Path.GetDirectoryName(AppContext.BaseDirectory);
        var certPath = Path.Combine(basePath!, TlsFile.Default.PfxFileName);

        // see: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http3?view=aspnetcore-8.0
        builder.WebHost.ConfigureKestrel((context, options) =>
        {
            options.ListenAnyIP(port, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps(certPath, TlsFile.Default.Password);
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
        })
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
            {
                // allow self certificate
                ServerCertificateCustomValidationCallback = RemoteCertificateValidationCallback,
            });

        return builder;

        bool RemoteCertificateValidationCallback(object _, X509Certificate? certificate, X509Chain? __, SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            // Is Selfsigned Certificate
            if (sslPolicyErrors.HasFlag(SslPolicyErrors.RemoteCertificateChainErrors))
            {
                if (certificate is null)
                    return false;

                return options.SelfCertValidationType switch
                {
                    SelfSignedCertValidationType.None => true,
                    SelfSignedCertValidationType.Normal => ValidateNormal(certificate),
                    SelfSignedCertValidationType.Strict => ValidateStrict(certificate),
                    _ => throw new NotImplementedException(options.SelfCertValidationType.ToString()),
                };
            }

            return false;

            static bool ValidateNormal(X509Certificate certificate) => ValidateFingerprint(certificate);
            static bool ValidateStrict(X509Certificate certificate) => ValidateFingerprint(certificate)
                && ValidatePublicKey(certificate)
                && ValidateExpiry(certificate)
                && ValidateEKU(certificate)
                && ValidateSubject(certificate)
                && ValidateIssuer(certificate);
            // Certificate Fingerprint should be match.
            static bool ValidateFingerprint(X509Certificate certificate) => certificate.GetCertHash().SequenceEqual(Constants.SelfsignedCertConstants.FingerprintHash);
            // Certificate Public Key should be match.
            static bool ValidatePublicKey(X509Certificate certificate) => Convert.ToBase64String(certificate.GetPublicKey()).Equals(Constants.SelfsignedCertConstants.PublicKeyBase64, StringComparison.OrdinalIgnoreCase);
            // Certificate Expiration should be valid
            static bool ValidateExpiry(X509Certificate certificate)
            {
                if (certificate is X509Certificate2 cert2)
                {
                    // TODO: Use TimeProvider if possible
                    var now = DateTime.UtcNow;
                    var notBefore = cert2.NotBefore.ToUniversalTime();
                    var notAfter = cert2.NotAfter.ToUniversalTime();
                    return now >= notBefore && now <= notAfter;
                }
                return false;
            }
            // Certificate EKU should be valid
            static bool ValidateEKU(X509Certificate certificate)
            {
                if (certificate is X509Certificate2 cert2 && cert2.Extensions["2.5.29.37"] is X509EnhancedKeyUsageExtension ekuExtensions)
                {
                    foreach (var oid in ekuExtensions.EnhancedKeyUsages)
                    {
                        if (oid.Value is not null && oid.Value.Equals(Constants.SelfsignedCertConstants.EKU, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            // Certificate Subject should be valid
            static bool ValidateSubject(X509Certificate certificate) => certificate.Subject.Equals(Constants.SelfsignedCertConstants.Subject, StringComparison.OrdinalIgnoreCase);
            // Certificate Issuer should be valid
            static bool ValidateIssuer(X509Certificate certificate) => certificate.Issuer.Equals(Constants.SelfsignedCertConstants.Issuer, StringComparison.OrdinalIgnoreCase);
        }
    }
}
