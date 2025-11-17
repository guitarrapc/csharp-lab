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
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Performs a long-running persistent operation that retries on connection failures.";
            operation.Description = "Attempts to get or set a value in Redis every second for up to 10 minutes, logging successes and errors.";
            return Task.FromResult(operation);
        });

        app.MapPost("/persistentX", async (string key, TimeProvider timeProvider, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var value = await cache.GetOrSetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Medium);
            return Results.Ok(value);
        })
        .WithName("SetPersistentX")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Sets a cache value if it does not already exist.";
            operation.Description = "Retrieves the value associated with the specified key from the cache. If the key does not exist, it sets the key with the current local time and returns that value.";
            return Task.FromResult(operation);
        });

        app.MapGet("/persistent/{key}", async (string key, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            var result = await cache.TryGetValueAsync<DateTimeOffset>(key);
            return result.Success
                ? Results.Ok(result.Value)
                : Results.NotFound();
        })
        .WithName("GetPersistent")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Retrieves a cache value by key.";
            operation.Description = "Fetches the value associated with the specified key from the cache. Returns 404 if the key does not exist.";
            return Task.FromResult(operation);
        });

        app.MapPost("/persistent", async (string key, TimeProvider timeProvider, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.SetAsync(key, timeProvider.GetLocalNow(), RedisExpiry.Short);
            return Results.Ok();
        })
        .WithName("SetPersistent")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Sets a cache value with a short expiration time.";
            operation.Description = "Sets the specified key in the cache with the current local time as its value, expiring after a short duration.";
            return Task.FromResult(operation);
        });

        app.MapDelete("/persistent/{key}", async (string key, MemoryDBConnectionContext context) =>
        {
            var cache = context.GetDatabase();
            await cache.RemoveAsync(key);
            return Results.Ok();
        })
        .WithName("DeletePersistent")
        .AddOpenApiOperationTransformer((operation, context, ct) =>
        {
            operation.Summary = "Deletes a cache value by key.";
            operation.Description = "Removes the specified key and its associated value from the cache.";
            return Task.FromResult(operation);
        });
    }
}
