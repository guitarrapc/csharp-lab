using Grpc.Net.Client;
using System.Collections.Concurrent;

namespace Grpc2.Infrastructures;

/// <summary>
/// GrpcChannel is high cost operation and should be reusable. Let's create pool for each host and reuse a channel.
/// </summary>
public class GrpcChannelPool
{
    private readonly ConcurrentDictionary<Uri, GrpcChannel> _channels = new();

    public static GrpcChannelPool Instance { get; } = new GrpcChannelPool();

    public GrpcChannel CreateChannel(Uri host)
    {
        var channel = Create(host);

        // Pool state control
        switch (channel.State)
        {
            case Grpc.Core.ConnectivityState.TransientFailure:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host);
            case Grpc.Core.ConnectivityState.Shutdown:
                _channels.TryRemove(host, out _);
                channel.Dispose();
                return Create(host);
            default:
                return channel;
        };

        GrpcChannel Create(Uri h) => _channels.GetValueOrDefault(h, GrpcChannel.ForAddress(host, new GrpcChannelOptions
        {
            HttpHandler = new SocketsHttpHandler
            {
                // Enable Keep-alive ping
                PooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan,
                KeepAlivePingDelay = TimeSpan.FromSeconds(60),
                KeepAlivePingTimeout = TimeSpan.FromSeconds(30),
                KeepAlivePingPolicy = HttpKeepAlivePingPolicy.Always,
                // Enable connection concurrency
                EnableMultipleHttp2Connections = true
            }
        }));
    }
}
