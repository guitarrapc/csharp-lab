namespace Api.Shared.GrpcShared.Infrastructures;

public record SelfcheckServiceOptions
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
    /// <summary>
    /// Control how to validate SelfSigned Certificate, won't be used if EnableTls is false and Certificate is not SelfSigned
    /// </summary>
    public SelfSignedCertValidationType SelfCertValidationType { get; set; } = SelfSignedCertValidationType.Normal;
}

/// <summary>
/// Define SelfSigned Certificate validation method.
/// Use Strict for all validation, Normal for only Thumbprint, None for no validation.
/// </summary>
[Flags]
public enum SelfSignedCertValidationType
{
    /// <summary>
    /// indicate no check
    /// </summary>
    None = 0,
    /// <summary>
    /// indicate Thunbprint only
    /// </summary>
    Normal = 1 << 0,
    /// <summary>
    /// indicate Thumbprint, PublicCertificate, Expiry, EKU, Subject, Issuer
    /// </summary>
    Strict = 1 << 1,
}
