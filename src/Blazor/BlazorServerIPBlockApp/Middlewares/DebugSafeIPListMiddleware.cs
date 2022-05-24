using System.Net;

namespace BlazorServerIPBlockApp.Middlewares;

public class DebugSafeIPListMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<DebugSafeIPListMiddleware> _logger;
    private readonly IPNetwork[] _ipNetworks;

    public DebugSafeIPListMiddleware(RequestDelegate next, ILogger<DebugSafeIPListMiddleware> logger, DebugSafeIPOption option)
    {
        _next = next;
        _logger = logger;

        // ; separated IP list string. "8.8.8.8;1.1.1.1;4.4.4.4"
        if (!option.Enabled)
        {
            _ipNetworks = Array.Empty<IPNetwork>();
        }
        else
        {
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

        if (remoteIp is not null && _ipNetworks.Length > 0)
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
}
