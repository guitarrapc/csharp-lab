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

    /// <summary>
    /// Selfsigned Certificate Allowed Constants Values
    /// </summary>
    public static class SelfsignedCertConstants
    {
        /// <summary>
        /// Certificate Fingerprint string to set.
        /// </summary>
        private static readonly string Fingerprint = "BC0C1B5DAC867DB1B5502CA60539569C75F342C4";
        /// <summary>
        /// Certificate Fingerprint Bytes for comparison
        /// </summary>
        public static readonly byte[] FingerprintHash = CertHashStringToBytes(Fingerprint);
        /// <summary>
        /// Certificate PublicKey Base64 string.
        /// </summary>
        public static readonly string PublicKeyBase64 = "MIIBCgKCAQEA5xOONxJJ8b8Qauvob5/7dPYZfIcd+uhAWL2ZlTPzQvu4oF0QI4iYgP5iGgry9zEtCM+YQS8UhiAlPlqa6ANxgiBSEyMHH/xE8lo/+caYGeACqy640Jpl/JocFGo3xd1L8DCawjlaj6eu7T7T/tpAV2qq13b5710eNRbCAfFe8yALiGQemx0IYhlZXNbIGWLBNhBhvVjJh7UvOqpADk4xtl8o5j0xgMIRg6WJGK6c6ffSIg4eP1XmovNYZ9LLEJG68tF0Q/yIN43B4dt1oq4jzSdCbG4F1EiykT2TmwPVYDi8tml6DfOCDGnit8svnMEmBv/fcPd31GSbXjF8M+KGGQIDAQAB";
        /// <summary>
        /// Certificate EKU
        /// </summary>
        public static readonly string EKU = ""; // Server Authentication should be `1.3.6.1.5.5.7.3.1`
        /// <summary>
        /// Certificate Subject
        /// </summary>
        public static readonly string Subject = "subject=C = US, ST = Illinois, L = Chicago, O = \"Example, Co.\", CN = *.test.google.com";
        /// <summary>
        /// Certificate Issuer
        /// </summary>
        public static readonly string Issuer = "issuer=C = AU, ST = Some-State, O = Internet Widgits Pty Ltd, CN = testca";

        /// <summary>
        /// Convert Fingerprint Hex String to Bytes
        /// </summary>
        /// <param name="certHashString"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static byte[] CertHashStringToBytes(string certHashString)
        {
            Span<byte> certHashBytes = stackalloc byte[certHashString.Length / 2];
            ReadOnlySpan<char> certHashSpan = certHashString.AsSpan();
            for (int i = 0; i < certHashBytes.Length; i++)
            {
                certHashBytes[i] = (byte)((GetHexValue(certHashSpan[i * 2]) << 4) + GetHexValue(certHashSpan[i * 2 + 1]));
            }
            return certHashBytes.ToArray();

            static int GetHexValue(char hex) => hex switch
            {
                >= '0' and <= '9' => hex - '0',
                >= 'A' and <= 'F' => hex - 'A' + 10,
                >= 'a' and <= 'f' => hex - 'a' + 10,
                _ => throw new ArgumentException($"Invalid hex character: {hex}")
            };
        }
    }
}
