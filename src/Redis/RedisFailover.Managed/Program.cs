using Microsoft.Extensions.Caching.Distributed;
using RedisFailover.Managed.Infrastructures;
using StackExchange.Redis;

// Redis failed over handling by Microsoft.Extensions.Caching.Distributed

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(TimeProvider.System);
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.ConfigurationOptions = ConfigurationOptions.Parse(builder.Configuration.GetConnectionString("Redis")!);
    // for failover
    options.ConfigurationOptions.AbortOnConnectFail = false;
    options.ConfigurationOptions.HeartbeatConsistencyChecks = true; // Set heratbeat to detect connection failure
    options.ConfigurationOptions.HeartbeatInterval = TimeSpan.FromSeconds(3); // Server shutdown delay duration this interval
    options.ConfigurationOptions.AllowAdmin = true; // follow to Redis Cluster topoligy change by failover
    options.InstanceName = "Redis";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapPost("/cache/long_operation", async (string key, TimeProvider timeProvider, IDistributedCache cache, CancellationToken ct) =>
{
    var ts = timeProvider.GetTimestamp();
    DateTimeOffset value = timeProvider.GetLocalNow();
    while (timeProvider.GetElapsedTime(ts) < TimeSpan.FromMinutes(2))
    {
        try
        {
            value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), DistributedCacheExpiration.Medium, ct);
            app.Logger.LogInformation($"Redis operation success. {value}");
        }
        catch (RedisConnectionException ex)
        {
            app.Logger.LogError(ex, ex.Message);
        }
        finally
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
    return Results.Ok(value);
})
.WithName("LongCacheOperation")
.WithOpenApi();

app.MapPost("/cacheX", async (string key, TimeProvider timeProvider, IDistributedCache cache) =>
{
    var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), DistributedCacheExpiration.Medium);
    return Results.Ok(value);
})
.WithName("SetCacheX")
.WithOpenApi();

app.MapGet("/cache/{key}", async (string key, IDistributedCache cache, CancellationToken ct) =>
{
    var result = await cache.TryGetValueAsync<DateTimeOffset>(key, ct);
    return result.Success
        ? Results.Ok(result.Value)
        : Results.NotFound();
})
.WithName("GetCache")
.WithOpenApi();

app.MapPost("/cache", async (string key, TimeProvider timeProvider, IDistributedCache cache) =>
{
    await cache.SetAsync(key, timeProvider.GetLocalNow(), DistributedCacheExpiration.Short);
    return Results.Ok();
})
.WithName("SetCache")
.WithOpenApi();

app.MapDelete("/cache/{key}", async (string key, IDistributedCache cache) =>
{
    await cache.RemoveAsync(key);
    return Results.Ok();
})
.WithName("DeleteCache")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
