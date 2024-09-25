using Grpc.Net.Client;
using System.Collections.Concurrent;

namespace Api.Shared.GrpcShared.Infrastructures;

/// <summary>
/// GrpcChannel is high cost operation and should be reusable. Let's create pool for each host and reuse a channel.
/// </summary>
public class GrpcChannelPool
{
    private record TlsFile(string PfxFileName, string Password)
    {
        public static TlsFile Default = new TlsFile("Certs/client.pfx", "1111");
    }

    public static GrpcChannelPool Instance { get; } = new GrpcChannelPool();

    private readonly ConcurrentDictionary<Uri, GrpcChannel> _channels = new();

    public GrpcChannel CreateChannel(Uri host, bool enableTls, bool useHttp3, bool useClientAuth = false)
    {
        var channel = Create(host, enableTls, useHttp3, useClientAuth);

        // Pool state control
        switch (channel.State)
        {
            case Grpc.Core.ConnectivityState.TransientFailure:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host, enableTls, useHttp3, useClientAuth);
            case Grpc.Core.ConnectivityState.Shutdown:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host, enableTls, useHttp3, useClientAuth);
            default:
                return channel;
        };

        GrpcChannel Create(Uri h, bool enableTls, bool useHttp3, bool clientauth)
        {
            var handler = new SocketsHttpHandler
            {
                // Enable Keep-alive ping
                PooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan,
                KeepAlivePingDelay = TimeSpan.FromSeconds(60),
                KeepAlivePingTimeout = TimeSpan.FromSeconds(30),
                KeepAlivePingPolicy = HttpKeepAlivePingPolicy.Always,
                // Enable connection concurrency
                EnableMultipleHttp2Connections = true,
            };

            if (clientauth)
            {
                var basePath = Path.GetDirectoryName(AppContext.BaseDirectory);
                var certPath = Path.Combine(basePath!, TlsFile.Default.PfxFileName);
                // .NET 9 API....
                //var clientCertificates = X509CertificateLoader.LoadPkcs12CollectionFromFile(certPath, TlsFile.Default.Password);
                var clientCertificates = new System.Security.Cryptography.X509Certificates.X509Certificate2Collection(new System.Security.Cryptography.X509Certificates.X509Certificate2(certPath, TlsFile.Default.Password));
                handler.SslOptions.ClientCertificates = clientCertificates;
            }

            if (enableTls)
            {
                // TLS
                handler.SslOptions = new System.Net.Security.SslClientAuthenticationOptions
                {
                    RemoteCertificateValidationCallback = (_, _, _, _) => true,
                };
            }
            return _channels.GetValueOrDefault(h, GrpcChannel.ForAddress(host, new GrpcChannelOptions
            {
                HttpHandler = useHttp3 ? new Http3Handler(handler) : handler,
            }));
        }
    }

    /// <summary>
    /// temporary solution for .NET8 and lower
    /// </summary>
    public class Http3Handler : DelegatingHandler
    {
        public Http3Handler(HttpMessageHandler innerHandler) : base(innerHandler) { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Force H3 on all requests.
            request.Version = System.Net.HttpVersion.Version30;
            request.VersionPolicy = HttpVersionPolicy.RequestVersionExact;

            return base.SendAsync(request, cancellationToken);
        }
    }
}
