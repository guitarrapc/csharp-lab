using RedisFailover.Direct.Infrastructures;
using StackExchange.Redis;

namespace RedisFailover.Direct;

public static class ElastiCacheRouteHandler
{
    public static void AddElastiCacheRouteHandler(this WebApplication app)
    {
        app.MapPost("/cache/long_operation", async (string key, TimeProvider timeProvider, ElastiCacheConnectionContext context, CancellationToken ct) =>
        {
            var ts = timeProvider.GetTimestamp();
            DateTimeOffset value = timeProvider.GetLocalNow();
            while (!ct.IsCancellationRequested && timeProvider.GetElapsedTime(ts) < TimeSpan.FromMinutes(10))
            {
                try
                {
                    var cache = context.GetDatabase();
                    value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
                    app.Logger.LogInformation($"Cache Redis operation success. {value}");
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

        app.MapPost("/cacheX", async (string key, TimeProvider timeProvider, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
            return Results.Ok(value);
        })
        .WithName("SetCacheX")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Sets a cache value if it does not already exist.";
            operation.Description = "Retrieves the value associated with the specified key from the cache. If the key does not exist, it sets the key with the current local time and returns that value.";
            return Task.FromResult(operation);
        });

        app.MapGet("/cache/{key}", async (string key, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var result = await cache.TryGetValueAsync<DateTimeOffset>(key);
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

        app.MapPost("/cache", async (string key, TimeProvider timeProvider, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.SetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Short);
            return Results.Ok();
        })
        .WithName("SetCache")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Sets a cache value with a short expiration time.";
            operation.Description = "Sets the specified key in the cache with the current local time as its value, expiring after a short duration.";
            return Task.FromResult(operation);
        });

        app.MapDelete("/cache/{key}", async (string key, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
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
    }
}
