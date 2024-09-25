namespace Api.Shared.GrpcShared.Infrastructures;

public class SelfcheckServiceOptions
{
    /// <summary>
    /// Selfcheck delay start since ApplicationStarted
    /// </summary>
    public TimeSpan DelayStart { get; } = TimeSpan.FromSeconds(3);
    /// <summary>
    /// Selfcheck interval from previous run
    /// </summary>
    public TimeSpan Interval { get; } = TimeSpan.FromSeconds(10);
    /// <summary>
    /// HTTPClient BaseAddress to request this server's htts listener address.
    /// Visual Studio / Docker / Kubernetes or any other launch method will not guaranteed which port to be used.
    /// This method will inject proper address for any launch style.
    /// </summary>
    public Uri BaseAddress { get; set; } = new Uri("http://localhost:5000");
    /// <summary>
    /// Is TLS Address or not
    /// </summary>
    public bool EnableTls => BaseAddress.Scheme == "https";
    /// <summary>
    /// Use HTTP/3 or not. This help client to setup HTTP/3
    /// </summary>
    public bool UseHttp3 { get; set; }
}
