using StackExchange.Redis;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RedisFailover.Direct.Infrastructures;

public static class RedisExpiry
{
    public static TimeSpan Short = TimeSpan.FromSeconds(10);

    public static TimeSpan Medium = TimeSpan.FromMinutes(60);

    public static TimeSpan Long = TimeSpan.FromDays(7);
}

public static class ConnectionMultiplexerExtensions
{
    private static JsonSerializerOptions serializerOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    private static TimeSpan defaultExpiry = RedisExpiry.Medium;

    public static async Task SetAsync<T>(this IDatabase cache, string key, T value, When when = When.Always)
    {
        await SetAsync(cache, key, value, defaultExpiry, when);
    }

    public static async Task SetAsync<T>(this IDatabase cache, string key, T value, TimeSpan expiry, When when = When.Always)
    {
        var bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(value, serializerOptions));
        await cache.StringSetAsync(key, bytes, expiry, when);
    }

    public static async Task<(bool Success, T? Value)> TryGetValueAsync<T>(this IDatabase cache, string key)
    {
        var val = await cache.StringGetAsync(key);
        if (!val.HasValue)
        {
            return (false, default);
        }

        var value = JsonSerializer.Deserialize<T>(val.ToString(), serializerOptions);
        return (true, value);
    }

    public static async Task<T?> GetOrSetAsync<T>(this IDatabase cache, string key, T value, TimeSpan expiry, When when = When.Always)
    {
        var val = await cache.TryGetValueAsync<T>(key);
        if (val.Success)
        {
            return val.Value;
        }

        await cache.SetAsync<T>(key, value, expiry, when);
        return value;
    }

    public static async Task RemoveAsync(this IDatabase cache, string key)
    {
        await cache.KeyDeleteAsync(key);
    }
}
