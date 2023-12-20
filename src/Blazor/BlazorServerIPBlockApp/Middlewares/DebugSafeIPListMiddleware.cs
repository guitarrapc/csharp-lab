extern alias IPNetwork2; // see: https://github.com/lduchosal/ipnetwork/issues/280
namespace BlazorServerIPBlockApp.Middlewares;

public class DebugSafeIPListMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<DebugSafeIPListMiddleware> _logger;
    private readonly bool _enabled;
    private readonly IReadOnlyList<string> _allowedPath;
    private readonly IPNetwork2.System.Net.IPNetwork[] _ipNetworks;

    public DebugSafeIPListMiddleware(RequestDelegate next, ILogger<DebugSafeIPListMiddleware> logger, DebugSafeIPOption option)
    {
        _next = next;
        _logger = logger;
        _enabled = option.Enabled;

        if (!option.Enabled)
        {
            _allowedPath = Array.Empty<string>();
            _ipNetworks = Array.Empty<IPNetwork2.System.Net.IPNetwork>();
        }
        else
        {
            _allowedPath = option.AlwaysAllowPath is not null ? option.AlwaysAllowPath : Array.Empty<string>();

            if (option.IpNetworks is null)
            {
                _ipNetworks = Array.Empty<IPNetwork2.System.Net.IPNetwork>();
            }
            else
            {
                var ipNetworks = option.IpNetworks;
                _ipNetworks = new IPNetwork2.System.Net.IPNetwork[ipNetworks.Length];
                for (var i = 0; i < _ipNetworks.Length; i++)
                {
                    if (IPNetwork2.System.Net.IPNetwork.TryParse(ipNetworks[i], out var ip))
                    {
                        _ipNetworks[i] = ip;
                    }
                    else
                    {
                        _logger.LogInformation($"Cannnot parse DebugSafeIP for {ipNetworks[i]}.");
                    }
                }
            }
        }
    }

    public async Task Invoke(HttpContext context)
    {
        var remoteIp = context.Connection.RemoteIpAddress;
        _logger.LogInformation("Request from Remote IP address: {RemoteIP}", remoteIp);

        if (!_enabled || remoteIp is null || _ipNetworks.Length == 0 || _allowedPath.Any(x => x.Equals(context.Request.Path, StringComparison.InvariantCultureIgnoreCase)))
        {
            await _next.Invoke(context);
            return;
        }

        if (remoteIp.IsIPv4MappedToIPv6)
        {
            remoteIp = remoteIp.MapToIPv4();
        }

        if (!_ipNetworks.Any(x => x.Contains(remoteIp)))
        {
            _logger.LogWarning("Forbidden request from remote IP Address: {RemoteIP}", remoteIp);
            context.Response.StatusCode = (int)System.Net.HttpStatusCode.Forbidden;
            return;
        }

        await _next.Invoke(context);
    }
}

public class DebugSafeIPOption
{
    public bool Enabled { get; set; }
    public string[]? IpNetworks { get; set; }
    public string[]? AlwaysAllowPath { get; set; }
}
