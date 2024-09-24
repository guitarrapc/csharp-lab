using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System.Text.Json;

namespace ApiHttp3.Infrastructures;

public class SelfcheckServiceOptions
{
    /// <summary>
    /// HTTPClient BaseAddress to request this server's htts listener address.
    /// Visual Studio / Docker / Kubernetes or any other launch method will not guaranteed which port to be used.
    /// This method will inject proper address for any launch style.
    /// </summary>
    public Uri BaseAddress { get; set; } = new Uri("https://localhost:8081");
}

/// <summary>
/// Connect to localhost's api to check it's availability
/// </summary>
/// <param name="client"></param>
/// <param name="hostApplicationLifetime"></param>
/// <param name="server"></param>
public class SelfcheckBackgroundService(SelfcheckServiceOptions options, SelfcheckHttp3Client client, IHostApplicationLifetime hostApplicationLifetime, IServer server): BackgroundService
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
        var addresses = server.Features.Get<IServerAddressesFeature>()?.Addresses ?? ["https://localhost:8081"];
        var port = addresses.Select(x => new Uri(x)).First(x => x.Scheme == "https").Port;
        options.BaseAddress = new Uri($"https://localhost:{port}");

        await Task.Delay(TimeSpan.FromSeconds(delayStart), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        while (!stoppingToken.IsCancellationRequested)
        {
            await client.SendAsync(stoppingToken);
            await Task.Delay(TimeSpan.FromSeconds(interval), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
        }
    }
}

public class SelfcheckHttp3Client(IHttpClientFactory clientFactory, ILogger<SelfcheckHttp3Client> logger)
{
    public async Task SendAsync(CancellationToken cancellationToken)
    {
        var client = clientFactory.CreateClient("SelfcheckHttp3");
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
        catch (Exception ex)
        {
            logger.LogError(ex, $"Error happen when calling {client.BaseAddress}.");
        }
    }
}
