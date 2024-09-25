using StackExchange.Redis;

namespace RedisFailoverDirect.Infrastructures;

public class ElastiCacheConnectionContext : RedisConnectionContext
{
    public ElastiCacheConnectionContext(string redisConnectionString, ILogger<RedisConnectionContext> logger)
        : base("ElastiCache", redisConnectionString, logger)
    {
    }
}
public class MemoryDBConnectionContext : RedisConnectionContext
{
    public MemoryDBConnectionContext(string redisConnectionString, ILogger<RedisConnectionContext> logger)
        : base("MemoryDB", redisConnectionString, logger)
    {
    }
}
public class RedisConnectionContext
{
    private readonly string _connectionString;
    private Lazy<IConnectionMultiplexer> _lazyConnection; // Singleton pattern for ConnectionMultiplexer

    private readonly ILogger<RedisConnectionContext> _logger;
    private readonly object _lock = new object();
    private int _failedConnectionAttempts = 0;
    private const int MaxFailedConnectionAttempts = 999; // Threshold to regenerate the connection

    public string Name { get; }

    public RedisConnectionContext(string name, string connectionString, ILogger<RedisConnectionContext> logger)
    {
        Name = name;
        _connectionString = connectionString;
        _logger = logger;
        _lazyConnection = new Lazy<IConnectionMultiplexer>(() => CreateConnection());
    }

    /// <summary>
    /// Get the singleton connection instance
    /// </summary>
    private IConnectionMultiplexer Connection => _lazyConnection.Value;

    /// <summary>
    /// Method to get the Redis database instance
    /// </summary>
    /// <returns></returns>
    public IDatabase GetDatabase()
    {
        return Connection.GetDatabase();
    }

    /// <summary>
    /// Create new Redis connection
    /// </summary>
    /// <returns></returns>
    private IConnectionMultiplexer CreateConnection()
    {
        var configurationOptions = ConfigurationOptions.Parse(_connectionString);
        // for failover
        configurationOptions.AbortOnConnectFail = false; // Reconnect when Redis cannot connect
        configurationOptions.ReconnectRetryPolicy = new ExponentialRetry(5000); // try reconnect every 5sec
        configurationOptions.HeartbeatConsistencyChecks = true; // Set heratbeat to detect connection failure
        configurationOptions.HeartbeatInterval = TimeSpan.FromSeconds(3); // Server shutdown delay duration this interval
        configurationOptions.AllowAdmin = true; // follow to Redis Cluster topoligy change by failover

        _logger.LogInformation($"Connecting to redis: {Name}/{string.Join(",", configurationOptions.EndPoints)}");
        var connection = ConnectionMultiplexer.Connect(configurationOptions);

        connection.ConnectionFailed += (_, args) => OnConnectionFailed(args);
        connection.ConnectionRestored += (_, args) => OnConnectionRestored(args);

        _failedConnectionAttempts = 0; // Reset failed attempts after successful connection

        return connection;
    }

    /// <summary>
    /// Conneciton failure callback. Recreate IConnectionMultiplexer when it's internal state may broken because of Failover or any reason
    /// </summary>
    /// <param name="args"></param>
    private void OnConnectionFailed(ConnectionFailedEventArgs args)
    {
        Console.WriteLine($"Redis connection failed to {args.EndPoint}: {args.FailureType}. Exception: {args.Exception?.Message}");
        Interlocked.Increment(ref _failedConnectionAttempts); // Increment failed connection attempts

        // If the number of failed attempts exceeds the threshold, recreate the connection
        if (_failedConnectionAttempts >= MaxFailedConnectionAttempts)
        {
            lock (_lock)
            {
                // Ensure only one thread regenerates the connection
                if (_lazyConnection!.IsValueCreated)
                {
                    Console.WriteLine($"Recreating Redis connection after multiple failures {Name}: {args.EndPoint}");
                    _lazyConnection.Value.Dispose(); // Dispose of the existing connection
                    _lazyConnection = new Lazy<IConnectionMultiplexer>(() => CreateConnection()); // Recreate the connection
                }
            }
        }
    }

    /// <summary>
    /// Connection restore callback. Reset failed attemp count because it's completed.
    /// </summary>
    /// <param name="args"></param>
    private void OnConnectionRestored(ConnectionFailedEventArgs args)
    {
        Console.WriteLine($"Redis connection restored {Name}: {args.EndPoint}.");
        _failedConnectionAttempts = 0; // Reset the counter on successful reconnection
    }
}
