using RedisFailover.Direct.Infrastructures;
using StackExchange.Redis;

namespace RedisFailover.Direct;

public static class MemoryDBRouteHandler
{
    public static void AddMemoryDBRouteHandler(this WebApplication app)
    {
        app.MapPost("/persistent/long_operation", async (string key, TimeProvider timeProvider, MemoryDBConnectionContext context, CancellationToken ct) =>
        {
            var ts = timeProvider.GetTimestamp();
            DateTimeOffset value = timeProvider.GetLocalNow();
            while (!ct.IsCancellationRequested && timeProvider.GetElapsedTime(ts) < TimeSpan.FromMinutes(10))
            {
                try
                {
                    var cache = context.GetDatabase();
                    value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
                    app.Logger.LogInformation($"Persistent Redis operation success. {value}");
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
        .WithName("LongPersistentOperation")
        .WithOpenApi();

        app.MapPost("/persistentX", async (string key, TimeProvider timeProvider, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
            return Results.Ok(value);
        })
        .WithName("SetPersistentX")
        .WithOpenApi();

        app.MapGet("/persistent/{key}", async (string key, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var result = await cache.TryGetValueAsync<DateTimeOffset>(key);
            return result.Success
                ? Results.Ok(result.Value)
                : Results.NotFound();
        })
        .WithName("GetPersistent")
        .WithOpenApi();

        app.MapPost("/persistent", async (string key, TimeProvider timeProvider, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.SetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Short);
            return Results.Ok();
        })
        .WithName("SetPersistent")
        .WithOpenApi();

        app.MapDelete("/persistent/{key}", async (string key, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.RemoveAsync(key);
            return Results.Ok();
        })
        .WithName("DeletePersistent")
        .WithOpenApi();
    }
}
