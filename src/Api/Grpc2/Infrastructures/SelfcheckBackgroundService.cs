using Grpc.Core;
using Grpc2;
using Grpc2.Infrastructures;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;

namespace ApiHttp12.Infrastructures;

public class SelfcheckServiceOptions
{
    /// <summary>
    /// HTTPClient BaseAddress to request this server's htts listener address.
    /// Visual Studio / Docker / Kubernetes or any other launch method will not guaranteed which port to be used.
    /// This method will inject proper address for any launch style.
    /// </summary>
    public Uri BaseAddress { get; set; } = new Uri("http://localhost:5000");
}

/// <summary>
/// Connect to localhost's api to check it's availability
/// </summary>
/// <param name="options"></param>
/// <param name="unaryClient"></param>
/// <param name="hostApplicationLifetime"></param>
/// <param name="server"></param>
public class SelfcheckBackgroundService(SelfcheckServiceOptions options, SelfcheckUnaryClient unaryClient, SelfcheckDuplexClient duplexClient, IHostApplicationLifetime hostApplicationLifetime, IServer server): BackgroundService
{
    private static readonly TimeSpan delayStart = TimeSpan.FromSeconds(3);
    private static readonly TimeSpan interval = TimeSpan.FromSeconds(10);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Wait until app started. Because `<IServerAddressesFeature>.Addresses` will be null or empty until ApplicationStarted.
        hostApplicationLifetime.ApplicationStarted.Register(async () =>
        {
            await SelfcheckAsync(stoppingToken);
        });
    }

    private async Task SelfcheckAsync(CancellationToken stoppingToken)
    {
        var addresses = server.Features.Get<IServerAddressesFeature>()?.Addresses ?? [options.BaseAddress.ToString()];
        var port = addresses.Select(x => new Uri(x)).First(x => x.Scheme == options.BaseAddress.Scheme).Port;
        options.BaseAddress = new Uri($"{options.BaseAddress.Scheme}://{options.BaseAddress.Host}:{port}");

        await Task.Delay(delayStart, stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        var duplex = duplexClient.SendAsync(interval, stoppingToken);

        using var timer = new PeriodicTimer(interval);
        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            await unaryClient.SendAsync(stoppingToken);
        }

        await duplex;
    }
}

public class SelfcheckUnaryClient(SelfcheckServiceOptions options, GrpcChannelPool pool, ILogger<SelfcheckUnaryClient> logger)
{
    private readonly HelloRequest cachedRequest = new HelloRequest
    {
        Name = "Selfcheck",
    };
    public async Task SendAsync(CancellationToken cancellationToken)
    {
        var chanel = pool.CreateChannel(options.BaseAddress);
        var client = new Greeter.GreeterClient(chanel);

        try
        {
            // to get StatusCode and Trailers, don't await directly, we need AsyncUnaryCall<TResponse> to get them.
            using var call = client.SayHelloAsync(cachedRequest, cancellationToken: cancellationToken);
            _ = await call;
            var responseHeaders = (await call.ResponseHeadersAsync).Select(x => $"{{{x.Key}:{string.Join(",", x.Value)}}}");
            logger.LogInformation($"Unary StatusCode={call.GetStatus().StatusCode}, Headers={string.Join(", ", responseHeaders)}");
        }
        catch (RpcException ex)
        {
            var trailers = ex.Trailers.Select(x => $"{{{x.Key}:{string.Join(",", x.Value)}}}");
            logger.LogError(ex, $"Error happen when calling {options.BaseAddress}. StatusCode={ex.StatusCode}, Trailers={string.Join(", ", trailers)}");
        }
        catch (Exception e)
        {
            logger.LogError(e, $"Error happen when calling {options.BaseAddress}.");
        }
    }
}

public class SelfcheckDuplexClient(SelfcheckServiceOptions options, GrpcChannelPool pool, ILogger<SelfcheckDuplexClient> logger)
{
    private readonly BidiHelloRequest cachedRequest = new BidiHelloRequest
    {
        Name = "Selfcheck",
    };

    public async Task SendAsync(TimeSpan interval, CancellationToken cancellationToken)
    {
        var chanel = pool.CreateChannel(options.BaseAddress);
        var client = new Duplexer.DuplexerClient(chanel);
        using var call = client.Echo(cancellationToken: cancellationToken);

        using var timer = new PeriodicTimer(interval);
        while (await timer.WaitForNextTickAsync(cancellationToken))
        {
            try
            {
                await call.RequestStream.WriteAsync(cachedRequest, cancellationToken);
                await call.ResponseStream.MoveNext(cancellationToken);
                logger.LogInformation($"Duplex Message={call.ResponseStream.Current.Message}");
            }
            catch (RpcException ex)
            {
                var trailers = ex.Trailers.Select(x => $"{{{x.Key}:{string.Join(",", x.Value)}}}");
                logger.LogError(ex, $"Error happen when calling {options.BaseAddress}. StatusCode={ex.StatusCode}, Trailers={string.Join(", ", trailers)}");
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error happen when calling {options.BaseAddress}.");
            }
        }
    }
}
