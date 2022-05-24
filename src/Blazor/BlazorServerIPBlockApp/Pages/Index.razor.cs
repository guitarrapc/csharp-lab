using Microsoft.AspNetCore.Components;

namespace BlazorServerIPBlockApp.Pages;

public partial class Index
{
    [Inject]
    private IHttpContextAccessor Accessor { get; set;  } = default!;

    private string _xForwardedHost = "";
    private string _remoteIps = "";

    protected override void OnInitialized()
    {
        if (Accessor.HttpContext!.Request.Headers.TryGetValue("X-Forwarded-Host", out var host))
        {
            _xForwardedHost = host;
        }
        _remoteIps = Accessor.HttpContext!.Connection.RemoteIpAddress!.ToString();
    }
}
