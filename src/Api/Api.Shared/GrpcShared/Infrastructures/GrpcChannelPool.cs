using Grpc.Net.Client;
using System.Collections.Concurrent;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Api.Shared.GrpcShared.Infrastructures;

/// <summary>
/// GrpcChannel is high cost operation and should be reusable. Let's create pool for each host and reuse a channel.
/// </summary>
public class GrpcChannelPool
{
    public static GrpcChannelPool Instance { get; } = new GrpcChannelPool();

    private readonly ConcurrentDictionary<Uri, GrpcChannel> _channels = new();

    // Certificate Fingerprint and Public Key for MDM attack validation
    private static readonly string _validationFingerprint = "BC0C1B5DAC867DB1B5502CA60539569C75F342C4";
    private static readonly string _validationPublicKeyBase64 = "MIIBCgKCAQEA5xOONxJJ8b8Qauvob5/7dPYZfIcd+uhAWL2ZlTPzQvu4oF0QI4iYgP5iGgry9zEtCM+YQS8UhiAlPlqa6ANxgiBSEyMHH/xE8lo/+caYGeACqy640Jpl/JocFGo3xd1L8DCawjlaj6eu7T7T/tpAV2qq13b5710eNRbCAfFe8yALiGQemx0IYhlZXNbIGWLBNhBhvVjJh7UvOqpADk4xtl8o5j0xgMIRg6WJGK6c6ffSIg4eP1XmovNYZ9LLEJG68tF0Q/yIN43B4dt1oq4jzSdCbG4F1EiykT2TmwPVYDi8tml6DfOCDGnit8svnMEmBv/fcPd31GSbXjF8M+KGGQIDAQAB";
    private static readonly string _validationEKU = ""; // Server Authentication should be `1.3.6.1.5.5.7.3.1`
    private static readonly string _validateSubject = "subject=C = US, ST = Illinois, L = Chicago, O = \"Example, Co.\", CN = *.test.google.com";
    private static readonly string _validateIssuer = "issuer=C = AU, ST = Some-State, O = Internet Widgits Pty Ltd, CN = testca";

    /// <summary>
    /// Create GrpcChannel
    /// </summary>
    /// <param name="host"></param>
    /// <param name="enableTls"></param>
    /// <param name="useHttp3"></param>
    /// <returns></returns>
    public GrpcChannel CreateChannel(Uri host, bool enableTls, bool useHttp3) => CreateChannel(host, enableTls, useHttp3, SelfSignedCertValidationType.Normal);
    /// <summary>
    /// Create GrpcChannel
    /// </summary>
    /// <param name="host"></param>
    /// <param name="enableTls"></param>
    /// <param name="useHttp3"></param>
    /// <param name="selfSignedCertValidationType"></param>
    /// <returns></returns>
    public GrpcChannel CreateChannel(Uri host, bool enableTls, bool useHttp3, SelfSignedCertValidationType selfSignedCertValidationType)
    {
        var channel = CreateChannel(host, enableTls, useHttp3);

        // Pool state control
        switch (channel.State)
        {
            case Grpc.Core.ConnectivityState.TransientFailure:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return CreateChannel(host, enableTls, useHttp3);
            case Grpc.Core.ConnectivityState.Shutdown:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return CreateChannel(host, enableTls, useHttp3);
            default:
                return channel;
        };

        GrpcChannel CreateChannel(Uri h, bool enableTls, bool useHttp3)
        {
            return _channels.GetOrAdd(h, _ =>
            {
                var httpClientHandler = new SocketsHttpHandler
                {
                    PooledConnectionIdleTimeout = Constants.GrpcConstants.ClientPooledConnectionIdleTimeout,
                    // Enable Keep-alive ping
                    KeepAlivePingDelay = Constants.GrpcConstants.ClientKeepAlivePingTimeout,
                    KeepAlivePingTimeout = Constants.GrpcConstants.ClientKeepAlivePingTimeout,
                    KeepAlivePingPolicy = HttpKeepAlivePingPolicy.Always,
                    // Enable connection concurrency
                    EnableMultipleHttp2Connections = true,
                };

                if (enableTls)
                {
                    // TLS
                    httpClientHandler.SslOptions = new System.Net.Security.SslClientAuthenticationOptions
                    {
                        RemoteCertificateValidationCallback = RemoteCertificateValidationCallback,
                    };
                }

                HttpMessageHandler httpMessageHandler = httpClientHandler;
                if (useHttp3)
                {
                    // HTTP/3 should never call this? But this is required for channel.State handling :(
                    //httpClientHandler.ConnectCallback = (_, _) => throw new InvalidOperationException("Should never be called for H3");

                    httpMessageHandler = new Http3Handler(httpClientHandler);
                }

                return GrpcChannel.ForAddress(host, new GrpcChannelOptions
                {
                    HttpHandler = httpMessageHandler,
                });
            });

            bool RemoteCertificateValidationCallback(object _, X509Certificate? certificate, X509Chain? __, SslPolicyErrors sslPolicyErrors)
            {
                if (sslPolicyErrors == SslPolicyErrors.None)
                    return true;

                // Is Selfsigned Certificate
                if (sslPolicyErrors.HasFlag(SslPolicyErrors.RemoteCertificateChainErrors))
                {
                    if (certificate is null)
                        return false;

                    return selfSignedCertValidationType switch
                    {
                        SelfSignedCertValidationType.None => true,
                        SelfSignedCertValidationType.Normal => ValidateNormal(certificate),
                        SelfSignedCertValidationType.Strict => ValidateStrict(certificate),
                        _ => throw new NotImplementedException(selfSignedCertValidationType.ToString()),
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
                static bool ValidateFingerprint(X509Certificate certificate) => certificate.GetCertHashString().Equals(_validationFingerprint, StringComparison.OrdinalIgnoreCase);
                // Certificate Public Key should be match.
                static bool ValidatePublicKey(X509Certificate certificate) => Convert.ToBase64String(certificate.GetPublicKey()).Equals(_validationPublicKeyBase64, StringComparison.OrdinalIgnoreCase);
                // Certificate Expiration should be valid
                static bool ValidateExpiry(X509Certificate certificate)
                {
                    if (certificate is X509Certificate2 cert2)
                    {
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
                            if (string.Equals(oid.Value, _validationEKU, StringComparison.OrdinalIgnoreCase))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                // Certificate Subject should be valid
                static bool ValidateSubject(X509Certificate certificate) => certificate.Subject.Equals(_validateSubject, StringComparison.OrdinalIgnoreCase);
                // Certificate Issuer should be valid
                static bool ValidateIssuer(X509Certificate certificate) => certificate.Issuer.Equals(_validateIssuer, StringComparison.OrdinalIgnoreCase);
            }
        }
    }

    /// <summary>
    /// temporary solution for .NET8 and lower
    /// </summary>
    internal class Http3Handler(HttpMessageHandler innerHandler) : DelegatingHandler(innerHandler)
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Force H3 on all requests.
            request.Version = System.Net.HttpVersion.Version30;
            request.VersionPolicy = HttpVersionPolicy.RequestVersionExact;

            return base.SendAsync(request, cancellationToken);
        }
    }
}
