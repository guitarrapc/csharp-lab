﻿using Grpc.Core;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace Api.Shared.GrpcShared.Infrastructures;

/// <summary>
/// Connect to localhost's api to check it's availability
/// </summary>
/// <param name="options"></param>
/// <param name="unaryClient"></param>
/// <param name="duplexClient"></param>
/// <param name="hostApplicationLifetime"></param>
/// <param name="server"></param>
/// <param name="logger"></param>
public class GrpcSelfcheckBackgroundService(SelfcheckServiceOptions options, GrpcSelfcheckUnaryClient unaryClient, GrpcSelfcheckDuplexClient duplexClient, IHostApplicationLifetime hostApplicationLifetime, IServer server, ILogger<GrpcSelfcheckBackgroundService> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var cts = CancellationTokenSource.CreateLinkedTokenSource(stoppingToken);
        hostApplicationLifetime.ApplicationStopping.Register(() =>
        {
            logger.LogInformation($"Server stop triggered by {nameof(hostApplicationLifetime.ApplicationStopping)}.");
            cts.Cancel();
        });

        // Wait until app started. Because `<IServerAddressesFeature>.Addresses` will be null or empty until ApplicationStarted.
        hostApplicationLifetime.ApplicationStarted.Register(async () =>
        {
            SetBaseAddress();
            await SelfcheckAsync(cts.Token);
        });
    }

    private async Task SelfcheckAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(options.DelayStart, cancellationToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        using var timer = new PeriodicTimer(options.Interval);
        try
        {
            var duplex = duplexClient.SendAsync(options.Interval, cancellationToken);
            while (await timer.WaitForNextTickAsync(cancellationToken))
            {
                await unaryClient.SendAsync(cancellationToken);
            }
            await duplex;
        }
        catch (OperationCanceledException)
        {
            logger.LogDebug($"Server stopped, {nameof(GrpcSelfcheckBackgroundService)} cancelled.");
        }
        finally
        {
            logger.LogInformation($"{nameof(GrpcSelfcheckBackgroundService)} stopped.");
        }
    }

    private void SetBaseAddress()
    {
        var addresses = server.Features.Get<IServerAddressesFeature>()?.Addresses ?? [options.BaseAddress.ToString()];
        var prefferHttpsListen = addresses.Select(x => new Uri(x)).First(x => x.Scheme == options.BaseAddress.Scheme || x.Scheme == "https");
        options.BaseAddress = new Uri($"{prefferHttpsListen.Scheme}://{options.BaseAddress.Host}:{prefferHttpsListen.Port}");
    }
}

public class GrpcSelfcheckUnaryClient(SelfcheckServiceOptions options, ILogger<GrpcSelfcheckUnaryClient> logger)
{
    private readonly HelloRequest cachedRequest = new HelloRequest
    {
        Name = "Selfcheck",
    };
    public async Task SendAsync(CancellationToken cancellationToken)
    {
        var chanel = GrpcChannelPool.Instance.CreateChannel(options.BaseAddress, options.EnableTls, options.UseHttp3, options.SelfCertValidationType);
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

public class GrpcSelfcheckDuplexClient(SelfcheckServiceOptions options, ILogger<GrpcSelfcheckDuplexClient> logger)
{
    private readonly BidiHelloRequest cachedRequest = new BidiHelloRequest
    {
        Name = "Selfcheck",
    };

    public async Task SendAsync(TimeSpan interval, CancellationToken cancellationToken)
    {
        var chanel = GrpcChannelPool.Instance.CreateChannel(options.BaseAddress, options.EnableTls, options.UseHttp3);
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
