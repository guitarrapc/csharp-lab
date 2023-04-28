using StackExchange.Redis;
using StackExchange.Redis.KeyspaceIsolation;

// Connection Strings examples.
//   1. auth_token: "master.your-name.xxxxx.region.cache.amazonaws.com:6379,ssl=true,sslHost=master.your-name.xxxxx.region.cache.amazonaws.com,password=YOUR_PASSWORD";
//   2. acl:        "clustercfg.your-name.xxxxx.region.cache.amazonaws.com:6379,ssl=true,sslHost=clustercfg.your-name.xxxxx.region.cache.amazonaws.com,user=YOUR_USERNAME,password=YOUR_PASSWORD";
const string ENV_KEY_CONNECTIONSTRINGS = "REDIS_CONNECTION_STRINGS";
const string ENV_KEY_KEY_PREFIX = "REDIS_KEY_PREFIX";

// Get Redis settings from env var.
var connectionStrings = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS, EnvironmentVariableTarget.Process);
var prefix = Environment.GetEnvironmentVariable(ENV_KEY_KEY_PREFIX, EnvironmentVariableTarget.Process) ?? "RedisConectTester";
if (string.IsNullOrEmpty(connectionStrings))
{
    throw new ArgumentNullException($"Environment Variable '{nameof(ENV_KEY_CONNECTIONSTRINGS)}' was empty. Please set and retry.");
}

// Connect Redis
var db = ConnectRedis(connectionStrings, prefix);

// Set and Get
using var cts = new CancellationTokenSource(TimeSpan.FromMinutes(60));
while (cts.IsCancellationRequested)
{
    var key = $"foo-{Random.Shared.Next()}";
    db.StringSet(key, "bar", TimeSpan.FromMinutes(10));
    var value = db.StringGet(key);
    Console.WriteLine($"RedisConnectTester - GetKey result. Key: {key}, HasValue: {value.HasValue}, Value: {value}");

    await Task.Delay(TimeSpan.FromMinutes(5)); // run per 5 minutes
}

IDatabase ConnectRedis(string connectionStrings, string? prefix)
{
    try
    {
        var connection = ConnectionMultiplexer.Connect(connectionStrings);
        Console.WriteLine($"RedisConnectTester - Connection Success. IsConnected: {connection.IsConnected}, IsConnecting: {connection.IsConnecting}, KeyPrefix: {prefix}");

        // Set Prefix Key, this transparent key operation.
        // var db = connection.GetDatabase(); // No Prefix
        // var db = connection.GetDatabase().WithKeyPrefix(""); // Same as no Prefix
        // var db = connection.GetDatabase().WithKeyPrefix("PREFIX-"); // with Prefix
        return connection.GetDatabase().WithKeyPrefix(prefix);
    }
    catch (RedisConnectionException)
    {
        Console.WriteLine($"RedisConnectTester - Connection failure. {connectionStrings}");
        throw;
    }
}
