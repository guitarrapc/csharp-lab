using Microsoft.AspNetCore.Components;

namespace BlazorServerIPBlockApp.Pages;

public partial class Index
{
    [Inject]
    private IHttpContextAccessor Accessor { get; set; } = default!;

    private string _serverName = "";
    private IDictionary<string, string> _headers = default!;
    private string _remoteIp = "";

    protected override void OnInitialized()
    {
        _serverName = Environment.MachineName;
        _headers = Accessor.HttpContext!.Request.Headers.ToDictionary(kv => kv.Key.ToString(), kv => kv.Value.ToString());
        _remoteIp = Accessor.HttpContext!.Connection.RemoteIpAddress!.ToString();
    }
}
