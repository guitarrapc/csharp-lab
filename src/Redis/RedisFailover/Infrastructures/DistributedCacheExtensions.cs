using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RedisFailover.Infrastructures;

public static class DistributedCacheExpiration
{
    public static DistributedCacheEntryOptions Short = new DistributedCacheEntryOptions()
        .SetSlidingExpiration(TimeSpan.FromSeconds(5))
        .SetAbsoluteExpiration(TimeSpan.FromSeconds(10));

    public static DistributedCacheEntryOptions Medium = new DistributedCacheEntryOptions()
        .SetSlidingExpiration(TimeSpan.FromMinutes(30))
        .SetAbsoluteExpiration(TimeSpan.FromMinutes(60));

    public static DistributedCacheEntryOptions Long = new DistributedCacheEntryOptions()
        .SetSlidingExpiration(TimeSpan.FromDays(1))
        .SetAbsoluteExpiration(TimeSpan.FromDays(7));
}

public static class DistributedCacheExtensions
{
    private static JsonSerializerOptions serializerOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    private static DistributedCacheEntryOptions defaultOptions = DistributedCacheExpiration.Medium;

    public static async Task SetAsync<T>(this IDistributedCache cache, string key, T value, CancellationToken ct = default)
    {
        await SetAsync(cache, key, value, defaultOptions, ct);
    }

    public static async Task SetAsync<T>(this IDistributedCache cache, string key, T value, DistributedCacheEntryOptions options, CancellationToken ct = default)
    {
        var bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(value, serializerOptions));
        await cache.SetAsync(key, bytes, options, ct);
    }

    public static async Task<(bool Success, T? Value)> TryGetValueAsync<T>(this IDistributedCache cache, string key, CancellationToken ct = default)
    {
        var val = await cache.GetAsync(key, ct);
        if (val == null)
        {
            return (false, default);
        }

        var value = JsonSerializer.Deserialize<T>(val, serializerOptions);
        return (true, value);
    }

    public static async Task<T?> GetOrSetAsync<T>(this IDistributedCache cache, string key, T value, DistributedCacheEntryOptions? options = null, CancellationToken ct = default)
    {
        options ??= defaultOptions;
        var val = await cache.TryGetValueAsync<T>(key, ct);
        if (val.Success)
        {
            return val.Value;
        }

        await cache.SetAsync<T>(key, value, options, ct);
        return value;
    }
}
