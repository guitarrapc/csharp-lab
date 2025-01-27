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
        .WithOpenApi();

        app.MapPost("/cacheX", async (string key, TimeProvider timeProvider, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
            return Results.Ok(value);
        })
        .WithName("SetCacheX")
        .WithOpenApi();

        app.MapGet("/cache/{key}", async (string key, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var result = await cache.TryGetValueAsync<DateTimeOffset>(key);
            return result.Success
                ? Results.Ok(result.Value)
                : Results.NotFound();
        })
        .WithName("GetCache")
        .WithOpenApi();

        app.MapPost("/cache", async (string key, TimeProvider timeProvider, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.SetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Short);
            return Results.Ok();
        })
        .WithName("SetCache")
        .WithOpenApi();

        app.MapDelete("/cache/{key}", async (string key, ElastiCacheConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.RemoveAsync(key);
            return Results.Ok();
        })
        .WithName("DeleteCache")
        .WithOpenApi();
    }
}
