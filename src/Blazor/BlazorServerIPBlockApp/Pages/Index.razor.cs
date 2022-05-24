using Microsoft.AspNetCore.Components;

namespace BlazorServerIPBlockApp.Pages;

public partial class Index
{
    [Inject]
    private IHttpContextAccessor Accessor { get; set;  } = default!;

    private string _remoteIps = "";

    protected override void OnInitialized()
    {
        _remoteIps = Accessor?.HttpContext?.Connection.RemoteIpAddress?.ToString() ?? "";
    }
}
