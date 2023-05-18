using StackExchange.Redis;
using StackExchange.Redis.KeyspaceIsolation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

// Connection Strings examples.
//   1. auth_token: "master.your-name.xxxxx.region.cache.amazonaws.com:6379,ssl=true,sslHost=master.your-name.xxxxx.region.cache.amazonaws.com,password=YOUR_PASSWORD";
//   2. acl:        "clustercfg.your-name.xxxxx.region.cache.amazonaws.com:6379,ssl=true,sslHost=clustercfg.your-name.xxxxx.region.cache.amazonaws.com,user=YOUR_USERNAME,password=YOUR_PASSWORD";
const string ENV_KEY_CONNECTIONSTRINGS_HOST = "REDIS_CONNECTION_HOST";
const string ENV_KEY_CONNECTIONSTRINGS_SSL = "REDIS_CONNECTION_SSL";
const string ENV_KEY_CONNECTIONSTRINGS_SSLHOST = "REDIS_CONNECTION_SSLHOST";
const string ENV_KEY_CONNECTIONSTRINGS_PASSWORD = "REDIS_CONNECTION_PASSWORD";
const string ENV_KEY_CONNECTIONSTRINGS_USER = "REDIS_CONNECTION_USER";
const string ENV_KEY_CONNECTIONSTRINGS_OTHER = "REDIS_CONNECTION_OTHER";
const string ENV_KEY_KEY_PREFIX = "REDIS_KEY_PREFIX";

// Get Redis settings from env var.
var connectionHost = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_HOST, EnvironmentVariableTarget.Process);
var connectionSsl = bool.Parse(Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_SSL, EnvironmentVariableTarget.Process) ?? "false");
var connectionSslHost = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_SSLHOST, EnvironmentVariableTarget.Process);
var connectionPassword = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_PASSWORD, EnvironmentVariableTarget.Process);
var connectionUser = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_USER, EnvironmentVariableTarget.Process);
var connectionOther = Environment.GetEnvironmentVariable(ENV_KEY_CONNECTIONSTRINGS_OTHER, EnvironmentVariableTarget.Process);
var prefix = Environment.GetEnvironmentVariable(ENV_KEY_KEY_PREFIX, EnvironmentVariableTarget.Process) ?? "RedisConectTester-";

// Connect Redis
var connectionStrings = CreateConnectionStrings(connectionHost, connectionSsl, connectionSslHost, connectionPassword, connectionUser, connectionOther);
Console.WriteLine($"ConnectionStrings => {connectionStrings}");
var db = ConnectRedis(connectionStrings, prefix);

// Set and Get
using var cts = new CancellationTokenSource(TimeSpan.FromMinutes(60));
while (!cts.IsCancellationRequested)
{
    var key = $"foo-{Random.Shared.Next()}";
    db.StringSet(key, "bar", TimeSpan.FromMinutes(10));
    var value = db.StringGet(key);
    Console.WriteLine($"RedisConnectTester - GetKey result. Key: {key}, HasValue: {value.HasValue}, Value: {value}");

    await Task.Delay(TimeSpan.FromMinutes(5)); // run per 5 minutes
}

string CreateConnectionStrings(string? host, bool ssl, string? sslHost, string? password, string? user, string? other)
{
    var connectionStrings = Create(isMasked: false, host, ssl, sslHost, password, user, other);
    var maskedConnectionStrings = Create(isMasked: true, host, ssl, sslHost, password, user, other);

    Console.WriteLine($"RedisConnectTester - ConnectionStrings: {maskedConnectionStrings}");

    return connectionStrings;

    static string Create(bool isMasked, string? host, bool ssl, string? sslHost, string? password, string? user, string? other)
    {
        var builder = new StringBuilder();
        builder.Append(host);
        builder.Append($",ssl={ssl}");
        if (ssl)
        {
            builder.Append($",sslHost={sslHost}");
        }
        if (!string.IsNullOrEmpty(user))
        {
            builder.Append($",user={user}");
        }
        if (!string.IsNullOrEmpty(password))
        {
            if (isMasked)
            {
                builder.Append($",password=<Secret Hash={HashString(password)}>");
            }
            else
            {
                builder.Append($",password={password}");
            }
        }
        if (!string.IsNullOrEmpty(other))
        {
            builder.Append($",{other}");
        }
        return builder.ToString();
    }

    static string HashString(string value)
    {
        using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(Assembly.GetEntryAssembly()!.FullName!)))
        {
            return Convert.ToHexString(hmac.ComputeHash(Encoding.UTF8.GetBytes(value))).ToLowerInvariant().Substring(0, 8); // 8 letters is enough
        }
    }
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
