using Microsoft.AspNetCore.Components;

namespace BlazorServerIPBlockApp.Pages;

public partial class Index
{
    [Inject]
    private IHttpContextAccessor Accessor { get; set;  } = default!;

    private IDictionary<string, string> _headers = default!;
    private string _xForwardedHost = "";
    private string _remoteIps = "";

    protected override void OnInitialized()
    {
        _headers = Accessor.HttpContext!.Request.Headers.ToDictionary(kv => kv.Key.ToString(), kv => kv.Value.ToString());
        if (Accessor.HttpContext!.Request.Headers.TryGetValue("X-Forwarded-Host", out var host))
        {
            _xForwardedHost = host;
        }
        _remoteIps = Accessor.HttpContext!.Connection.RemoteIpAddress!.ToString();
    }
}
