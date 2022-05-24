using System.Net;

namespace BlazorServerIPBlockApp.Middlewares;

public class DebugSafeIPListMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<DebugSafeIPListMiddleware> _logger;
    private readonly IReadOnlyList<string> _allowedPath;
    private readonly IPNetwork[] _ipNetworks;

    public DebugSafeIPListMiddleware(RequestDelegate next, ILogger<DebugSafeIPListMiddleware> logger, DebugSafeIPOption option)
    {
        _next = next;
        _logger = logger;

        if (!option.Enabled)
        {
            _allowedPath = Array.Empty<string>();
            _ipNetworks = Array.Empty<IPNetwork>();
        }
        else
        {
            _allowedPath = option.AlwaysAllowPath is not null ? option.AlwaysAllowPath : Array.Empty<string>();

            if (option.IpNetworks is null)
            {
                _ipNetworks = Array.Empty<IPNetwork>();
            }
            else
            {
                var ipNetworks = option.IpNetworks;
                _ipNetworks = new IPNetwork[ipNetworks.Length];
                for (var i = 0; i < _ipNetworks.Length; i++)
                {
                    if (IPNetwork.TryParse(ipNetworks[i], out var ip))
                    {
                        _ipNetworks[i] = ip;
                    }
                }
            }
        }
    }

    public async Task Invoke(HttpContext context)
    {
        var remoteIp = context.Connection.RemoteIpAddress;
        _logger.LogInformation("Request from Remote IP address: {RemoteIP}", remoteIp);

        if (remoteIp is not null && _ipNetworks.Length > 0 && !_allowedPath.Any(x => x.Equals(context.Request.Path, StringComparison.InvariantCultureIgnoreCase)))
        {
            if (remoteIp.IsIPv4MappedToIPv6)
            {
                remoteIp = remoteIp.MapToIPv4();
            }

            if (!_ipNetworks.Any(x => x.Contains(remoteIp)))
            {
                _logger.LogWarning("Forbidden request from remote IP Address: {RemoteIP}", remoteIp);
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }
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
