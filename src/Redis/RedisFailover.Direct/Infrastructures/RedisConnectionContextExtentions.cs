namespace RedisFailover.Direct.Infrastructures;

public static class RedisConnectionContextExtentions
{
    /// <summary>
    /// Add Redis cache services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddRedisCache(this IServiceCollection services)
    {
        services.AddSingleton(sp =>
        {
            var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
            var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("Redis1");
            var lifetime = sp.GetRequiredService<IHostApplicationLifetime>();
            return new ElastiCacheConnectionContext(connectionString!, loggerFactory, lifetime);
        });
        services.AddSingleton(sp =>
        {
            var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
            var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("Redis2");
            var lifetime = sp.GetRequiredService<IHostApplicationLifetime>();
            return new MemoryDBConnectionContext(connectionString!, loggerFactory, lifetime);
        });

        return services;
    }
}
