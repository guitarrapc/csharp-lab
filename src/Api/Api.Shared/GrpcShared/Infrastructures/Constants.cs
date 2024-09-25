namespace Api.Shared.GrpcShared.Infrastructures;

public static class Constants
{
    public static class GrpcConstants
    {
        // client

        /// <summary>
        /// Client Pooled Connection Idle Timeout
        /// </summary>
        public static readonly TimeSpan ClientPooledConnectionIdleTimeout = Timeout.InfiniteTimeSpan;
        /// <summary>
        /// Client KeepAlive Ping Interval
        /// </summary>
        public static readonly TimeSpan ClientKeepAlivePingInterval = TimeSpan.FromSeconds(60);
        /// <summary>
        /// Client KeepAlive Ping Timeout
        /// </summary>
        public static readonly TimeSpan ClientKeepAlivePingTimeout = TimeSpan.FromSeconds(30);

        // server

        /// <summary>
        /// Server Shutdown delay for wait Server-Client connection complete.
        /// Should be longer than `<see cref="ClientKeepAlivePingInterval"/> * 2`
        /// </summary>
        public static readonly TimeSpan ServerKeepConnectionWait = ClientKeepAlivePingInterval * 2;
    }
}
