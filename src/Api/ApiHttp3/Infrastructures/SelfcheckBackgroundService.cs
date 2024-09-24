using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace ApiHttp3.Infrastructures;

/// <summary>
/// Add Server connection selfcheck background service.
/// </summary>
public static class SelfCheckService
{
    private static Uri? baseAddress;

    public static void ConfigureSelfCheckService(this IServiceCollection services)
    {
        services.AddHostedService<SelfcheckBackgroundService>();
        services.AddSingleton<SelfcheckHttp3Service>();

        // Set HttpClient configuratioan
        services.AddHttpClient("SelfcheckHttp3", httpClient =>
        {
            httpClient.BaseAddress = baseAddress;
            httpClient.DefaultRequestVersion = new Version(3, 0);
            httpClient.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;

            httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
        });
    }

    /// <summary>
    /// Set HTTPClient BaseAddress to this server's listener address.
    /// Visual Studio / Docker / Kubernetes or any other launch method will not guaranteed which port to be used.
    /// This method will inject proper address for any launch style.
    /// </summary>
    /// <param name="port"></param>
    public static void SetBaseAddress(int port)
    {
        baseAddress = new Uri($"https://localhost:{port}");
    }
}

/// <summary>
/// Connect to localhost's HTTP/3 and selfcheck it's availability
/// </summary>
/// <param name="client"></param>
/// <param name="hostApplicationLifetime"></param>
public class SelfcheckBackgroundService(SelfcheckHttp3Service client, IHostApplicationLifetime hostApplicationLifetime, IServer server): BackgroundService
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
        SelfCheckService.SetBaseAddress(port);

        await Task.Delay(TimeSpan.FromSeconds(delayStart), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        while (!stoppingToken.IsCancellationRequested)
        {
            await client.ExecuteAsync(stoppingToken);
            await Task.Delay(TimeSpan.FromSeconds(interval), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
        }
    }
}

public class SelfcheckHttp3Service(IHttpClientFactory clientFactory, ILogger<SelfcheckHttp3Service> logger)
{
    public async Task ExecuteAsync(CancellationToken cancellationToken)
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
