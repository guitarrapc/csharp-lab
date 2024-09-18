using Microsoft.Net.Http.Headers;
using System.Text.Json;

namespace ApiHttp3.Infrastructures;

public static class SelfCheckService
{
    public static void ConfigureSelfCheckService(this IServiceCollection services)
    {
        services.AddHostedService<SelfcheckBackgroundService>();
        services.AddSingleton<SelfcheckHttp3Service>();

        // Set HttpClient configuratioan
        services.AddHttpClient("SelfcheckHttp3", httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://localhost:5001");
            httpClient.DefaultRequestVersion = new Version(3, 0);
            httpClient.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;

            httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
        });
    }
}

public class SelfcheckBackgroundService(SelfcheckHttp3Service client, IHostApplicationLifetime hostApplicationLifetime): BackgroundService
{
    private const int delayStart = 3;
    private const int interval = 10;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // wait until app started
        while (hostApplicationLifetime.ApplicationStarted.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
        }

        await Task.Delay(TimeSpan.FromSeconds(delayStart));

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
        try
        {
            var client = clientFactory.CreateClient("SelfcheckHttp3");
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
            logger.LogError(ex, $"Error happen when calling {nameof(SelfcheckHttp3Service)}");
        }
    }
}
