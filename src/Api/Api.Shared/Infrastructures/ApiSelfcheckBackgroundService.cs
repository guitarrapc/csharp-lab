using Api.Shared.Services;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Api.Shared.Infrastructures;

/// <summary>
/// Connect to localhost's api to check it's availability
/// </summary>
/// <param name="client"></param>
/// <param name="hostApplicationLifetime"></param>
/// <param name="server"></param>
public class ApiSelfcheckBackgroundService(SelfcheckServiceOptions options, ApiSelfcheckClient client, IHostApplicationLifetime hostApplicationLifetime, IServer server): BackgroundService
{
    private const int delayStart = 3;
    private const int interval = 10;

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

        await Task.Delay(TimeSpan.FromSeconds(delayStart), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        while (!stoppingToken.IsCancellationRequested)
        {
            await client.SendAsync(stoppingToken);
            await Task.Delay(TimeSpan.FromSeconds(interval), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
        }
    }
}

public class ApiSelfcheckClient(IHttpClientFactory clientFactory, ILogger<ApiSelfcheckClient> logger)
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
                await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>>(contentStream);
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
