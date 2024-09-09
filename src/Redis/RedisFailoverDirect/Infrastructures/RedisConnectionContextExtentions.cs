namespace RedisFailoverDirect.Infrastructures;

public static class RedisConnectionContextExtentions
{
    public static IServiceCollection AddRedisCache(this IServiceCollection services)
    {
        services.AddSingleton(sp =>
        {
            var logger = sp.GetRequiredService<ILogger<RedisConnectionContext>>();
            var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("Redis1");
            return new ElastiCacheConnectionContext(connectionString!, logger);
        });
        services.AddSingleton(sp =>
        {
            var logger = sp.GetRequiredService<ILogger<RedisConnectionContext>>();
            var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("Redis2");
            return new MemoryDBConnectionContext(connectionString!, logger);
        });

        return services;
    }
}
