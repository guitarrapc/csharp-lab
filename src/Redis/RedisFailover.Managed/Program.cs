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
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Gets the weather forecast for the next 5 days.";
    operation.Description = "Returns an array of weather forecast objects.";
    return Task.FromResult(operation);
});

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
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Performs a long-running cache operation that retries on connection failures.";
    operation.Description = "Attempts to get or set a cache value repeatedly for up to 10 minutes, handling Redis connection exceptions gracefully.";
    return Task.FromResult(operation);
});


app.MapPost("/cacheX", async (string key, TimeProvider timeProvider, IDistributedCache cache) =>
{
    var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), DistributedCacheExpiration.Medium);
    return Results.Ok(value);
})
.WithName("SetCacheX")
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Sets a cache value if it does not already exist.";
    operation.Description = "Retrieves the value associated with the specified key from the cache. If the key does not exist, it sets the key with the current local time and returns that value.";
    return Task.FromResult(operation);
});


app.MapGet("/cache/{key}", async (string key, IDistributedCache cache, CancellationToken ct) =>
{
    var result = await cache.TryGetValueAsync<DateTimeOffset>(key, ct);
    return result.Success
        ? Results.Ok(result.Value)
        : Results.NotFound();
})
.WithName("GetCache")
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Retrieves a cache value by key.";
    operation.Description = "Fetches the value associated with the specified key from the cache. Returns 404 if the key does not exist.";
    return Task.FromResult(operation);
});

app.MapPost("/cache", async (string key, TimeProvider timeProvider, IDistributedCache cache) =>
{
    await cache.SetAsync(key, timeProvider.GetLocalNow(), DistributedCacheExpiration.Short);
    return Results.Ok();
})
.WithName("SetCache")
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Sets a cache value with a short expiration time.";
    operation.Description = "Sets the specified key in the cache with the current local time as its value, expiring after a short duration.";
    return Task.FromResult(operation);
});

app.MapDelete("/cache/{key}", async (string key, IDistributedCache cache) =>
{
    await cache.RemoveAsync(key);
    return Results.Ok();
})
.WithName("DeleteCache")
.AddOpenApiOperationTransformer((operation, context, ct) =>
{
    operation.Summary = "Deletes a cache value by key.";
    operation.Description = "Removes the specified key and its associated value from the cache.";
    return Task.FromResult(operation);
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
