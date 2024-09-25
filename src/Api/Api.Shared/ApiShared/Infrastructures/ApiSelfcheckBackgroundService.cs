using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
#pragma warning disable IDE0005 // Using directive is unnecessary.
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using System.Text.Json;

namespace Api.Shared.ApiShared.Infrastructures;

/// <summary>
/// Connect to localhost's api to check it's availability
/// </summary>
/// <param name="client"></param>
/// <param name="hostApplicationLifetime"></param>
/// <param name="server"></param>
public class ApiSelfcheckBackgroundService<T>(SelfcheckServiceOptions options, ApiSelfcheckClient<T> client, IHostApplicationLifetime hostApplicationLifetime, IServer server) : BackgroundService where T : class
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Wait until app started. Because `<IServerAddressesFeature>.Addresses` will be null or empty until ApplicationStarted.
        hostApplicationLifetime.ApplicationStarted.Register(async () =>
        {
            SetBaseAddress();
            await SelfcheckAsync(stoppingToken);
        });
    }

    private async Task SelfcheckAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(options.DelayStart, stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        using var timer = new PeriodicTimer(options.Interval);
        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            await client.SendAsync(stoppingToken);
        }
    }

    private void SetBaseAddress()
    {
        var addresses = server.Features.Get<IServerAddressesFeature>()?.Addresses ?? [options.BaseAddress.ToString()];
        var port = addresses.Select(x => new Uri(x)).First(x => x.Scheme == options.BaseAddress.Scheme).Port;
        options.BaseAddress = new Uri($"{options.BaseAddress.Scheme}://{options.BaseAddress.Host}:{port}");
    }
}

public class ApiSelfcheckClient<T>(IHttpClientFactory clientFactory, ILogger<ApiSelfcheckClient<T>> logger) where T : class
{
    public async Task SendAsync(CancellationToken cancellationToken)
    {
        var client = clientFactory.CreateClient("SelfcheckHttp");
        try
        {
            var response = await client.GetAsync("weatherforecast", cancellationToken);
            var responseHeaders = response.Headers.Select(x => $"{{{x.Key}:{string.Join(",", x.Value)}}}");
            logger.LogInformation($"StatusCode={response.StatusCode}, Headers={string.Join(", ", responseHeaders)}");

            if (response.IsSuccessStatusCode)
            {
                using var contentStream = await response.Content.ReadAsStreamAsync();
                await JsonSerializer.DeserializeAsync<IEnumerable<T>>(contentStream);
            }
        }
        catch (HttpRequestException ex)
        {
            logger.LogError(ex, $"Error happen when calling {client.BaseAddress}. StatusCode={ex.StatusCode},");
        }
        catch (Exception e)
        {
            logger.LogError(e, $"Error happen when calling {client.BaseAddress}.");
        }
    }
}
