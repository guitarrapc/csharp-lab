using StackExchange.Redis;

namespace RedisFailover.Direct.Infrastructures;

/// <inheritdoc />
public class ElastiCacheConnectionContext : RedisConnectionContext
{
    public ElastiCacheConnectionContext(string redisConnectionString, ILoggerFactory loggerFactory, IHostApplicationLifetime lifetime)
        : base("ElastiCache", redisConnectionString, loggerFactory.CreateLogger<ElastiCacheConnectionContext>(), lifetime)
    {
    }
}
/// <inheritdoc />
public class MemoryDBConnectionContext : RedisConnectionContext
{
    public MemoryDBConnectionContext(string redisConnectionString, ILoggerFactory loggerFactory, IHostApplicationLifetime lifetime)
        : base("MemoryDB", redisConnectionString, loggerFactory.CreateLogger<MemoryDBConnectionContext>(), lifetime)
    {
    }
}

/// <summary>
/// Redis connection context to manage Redis connection and database instance
/// </summary>
public class RedisConnectionContext
{
    private readonly string _connectionString;
    private Lazy<IConnectionMultiplexer> _lazyConnection; // Lazy initialization for singleton
    private Lazy<IDatabase> _lazyDatabase; // Lazy initialization for singleton

    private readonly ILogger<RedisConnectionContext> _logger;
    private readonly IHostApplicationLifetime _lifetime;
    private readonly object _lock = new object();
    private int _failedConnectionAttempts = 0;
    private const int MaxFailedConnectionAttempts = 10; // Threshold to regenerate the connection

    public string Name { get; }

    public RedisConnectionContext(string name, string connectionString, ILogger<RedisConnectionContext> logger, IHostApplicationLifetime lifetime)
    {
        Name = name;
        _connectionString = connectionString;
        _logger = logger;
        _lifetime = lifetime;
        _lazyConnection = new Lazy<IConnectionMultiplexer>(() => CreateConnection());
        _lazyDatabase = new Lazy<IDatabase>(() => _lazyConnection.Value.GetDatabase());
    }

    /// <summary>
    /// Method to get the Redis database instance
    /// </summary>
    /// <returns></returns>
    public IDatabase GetDatabase() => _lazyDatabase.Value;

    /// <summary>
    /// Create new Redis connection
    /// </summary>
    /// <returns></returns>
    private IConnectionMultiplexer CreateConnection()
    {
        var configurationOptions = CreateConfigurationOptions(_connectionString);
        var connection = ConnectionMultiplexer.Connect(configurationOptions);
        connection.ConnectionFailed += (_, args) => OnConnectionFailed(args);
        connection.ConnectionRestored += (_, args) => OnConnectionRestored(args);
        return connection;
    }

    /// <summary>
    /// Create configuration options for Redis connection with failover handling
    /// </summary>
    /// <remarks>
    /// https://stackexchange.github.io/StackExchange.Redis/Configuration
    /// </remarks>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    private ConfigurationOptions CreateConfigurationOptions(string connectionString)
    {
        var configurationOptions = ConfigurationOptions.Parse(_connectionString);

        // MUST BE FALSE. If true, Connect will not create a connection while no servers are available (default true)
        configurationOptions.AbortOnConnectFail = false;
        // SHOULD ADJUST. Time (seconds) at which to send a message to help keep sockets alive (60 sec default)
        configurationOptions.KeepAlive = 60;
        // SHOULD ADJUST. Used for ping on connection recovery. Timeout for synchronous operations. (default 5000)
        configurationOptions.SyncTimeout = 3000;
        // SHOULD ADJUST. Reconnect retry policy. Exponential retry every 5sec
        configurationOptions.ReconnectRetryPolicy = new ExponentialRetry(5000);
        // MUST BE TRUE. follow to Redis Cluster topology change by failover
        configurationOptions.AllowAdmin = true;
        // MUST BE TRUE. Set heartbeat to detect connection failure
        configurationOptions.HeartbeatConsistencyChecks = true;
        // SHOULD ADJUST. Server shutdown delay duration this interval
        configurationOptions.HeartbeatInterval = TimeSpan.FromSeconds(3);
        _logger.LogInformation($"Connecting to redis: {Name}/{string.Join(",", configurationOptions.EndPoints)}");
        return configurationOptions;
    }

    /// <summary>
    /// Conneciton failure callback. Recreate IConnectionMultiplexer when it's internal state may broken because of Failover or any reason
    /// </summary>
    /// <param name="args"></param>
    private void OnConnectionFailed(ConnectionFailedEventArgs e)
    {
        _logger.LogError(e.Exception, $"Redis disconnection detected, restoring connection. Endpoint={e.EndPoint}, FailureType={e.FailureType}, ExceptionType={e.Exception?.Message}");
        WaitForReconnect();

        // Wait for the connection to be restored
        void WaitForReconnect()
        {
            var ct = _lifetime.ApplicationStopping;

            // reconnect every 5sec, ping 3sec + 2sec wait, until application stopping. It may be some connection problem.
            while (!ct.IsCancellationRequested)
            {
                var instanceHash = _lazyConnection.Value.GetHashCode();
                try
                {
                    // Timeout by SyncTimeout value
                    _lazyDatabase.Value.Ping();
                    _failedConnectionAttempts = 0;
                    return;
                }
                catch (RedisConnectionException ex)
                {
                    Interlocked.Increment(ref _failedConnectionAttempts);
                    _logger.LogError(ex, $"Redis reconnect ping failed. ({_failedConnectionAttempts}/{MaxFailedConnectionAttempts}). Endpoint={e.EndPoint}, Hash={instanceHash}");
                }

                // failed connection attempts is less than threshold, wait 2sec and retry
                if (_failedConnectionAttempts < MaxFailedConnectionAttempts)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    continue;
                }

                // connection failed count is over threshold, recreate connection instance. It may be failover.
                if (_failedConnectionAttempts >= MaxFailedConnectionAttempts)
                {
                    lock (_lock)
                    {
                        // Recreate ConnectionMultiplexer instance to handle failover.
                        if (_lazyConnection.IsValueCreated)
                        {
                            _logger.LogWarning($"Redis reconnect reached max commands to retry, creating new multiplexer instance. ({_failedConnectionAttempts}/{MaxFailedConnectionAttempts}). Endpoint={e.EndPoint}");
                            _lazyConnection.Value.Dispose();
                            _lazyConnection = new Lazy<IConnectionMultiplexer>(() => CreateConnection());
                        }
                        if (_lazyDatabase.IsValueCreated)
                        {
                            _lazyDatabase = new(() => _lazyConnection.Value.GetDatabase());
                        }
                        _failedConnectionAttempts = 0;
                    }

                    // ConnectionMultiplexer instance is connected, exit the loop
                    if (_lazyConnection.Value.IsConnected)
                        return;

                    // ConnectionMultiplexer instance is not connected, continue reconnection loop. It may be fail over isn't completed.
                    _logger.LogWarning($"Redis reconnect failed event recreated multiplexer, continue reconnection loop.");
                }
            }
        }
    }

    /// <summary>
    /// Connection restore callback while connection established. Reset failed attemp count because it already restored.
    /// </summary>
    /// <param name="args"></param>
    private void OnConnectionRestored(ConnectionFailedEventArgs args)
    {
        _logger.LogWarning($"Redis connection restored {Name}: {args.EndPoint}.");
        _failedConnectionAttempts = 0; // Reset the counter on successful reconnection
    }
}
