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

                static bool ValidateNormal(X509Certificate certificate) => ValidateFingerprint(certificate)
                    && ValidateExpiry(certificate);
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
                            if (string.Equals(oid.Value, Constants.SelfsignedCertConstants.EKU, StringComparison.OrdinalIgnoreCase))
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
