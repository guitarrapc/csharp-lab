using System.Net;

namespace BlazorServerIPBlockApp.Middlewares;

public class DebugSafeIPListMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<DebugSafeIPListMiddleware> _logger;
    private readonly byte[][] _safelist;

    public DebugSafeIPListMiddleware(RequestDelegate next, ILogger<DebugSafeIPListMiddleware> logger, DebugSafeIPOption option)
    {
        _next = next;
        _logger = logger;

        // ; separated IP list string. "8.8.8.8;1.1.1.1;4.4.4.4"
        if (!option.Enabled)
        {
            _safelist = Array.Empty<byte[]>();
        }
        else
        {
            ArgumentNullException.ThrowIfNull(option.IPList);

            var ips = option.IPList;
            _safelist = new byte[ips.Length][];
            for (var i = 0; i < ips.Length; i++)
            {
                if (IPAddress.TryParse(ips[i], out var ip))
                {
                    _safelist[i] = ip.GetAddressBytes();
                }
            }
        }
    }

    public async Task Invoke(HttpContext context)
    {
        var remoteIp = context.Request.Headers.TryGetValue("X-Forwarded-Host", out var host) ? IPAddress.Parse(host) : context.Connection.RemoteIpAddress;

        _logger.LogInformation("Request from Remote IP address: {RemoteIP}", remoteIp);
        if (remoteIp is null)
        {
            await _next(context);
        }
        else if (_safelist.Length == 0)
        {
            await _next(context);
        }
        else
        {
            var bytes = remoteIp.GetAddressBytes();
            var badIp = true;
            foreach (var address in _safelist)
            {
                if (address.SequenceEqual(bytes))
                {
                    badIp = false;
                    break;
                }
            }

            if (badIp)
            {
                _logger.LogWarning("Forbidden request from remote IP Address: {RemoteIP}", remoteIp);
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            await _next.Invoke(context);
        }
    }
}

public class DebugSafeIPOption
{
    public bool Enabled { get; set; }
    public string[]? IPList { get; set; }
}
