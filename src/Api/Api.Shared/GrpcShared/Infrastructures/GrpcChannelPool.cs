using Grpc.Net.Client;
using System.Collections.Concurrent;

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
    public GrpcChannel CreateChannel(Uri host, bool enableTls, bool useHttp3)
    {
        var channel = Create(host, enableTls, useHttp3);

        // Pool state control
        switch (channel.State)
        {
            case Grpc.Core.ConnectivityState.TransientFailure:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host, enableTls, useHttp3);
            case Grpc.Core.ConnectivityState.Shutdown:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host, enableTls, useHttp3);
            default:
                return channel;
        };

        GrpcChannel Create(Uri h, bool enableTls, bool useHttp3)
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
