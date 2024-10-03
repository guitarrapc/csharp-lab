namespace Api.Shared.ApiShared.Infrastructures;

public static class Constants
{
    /// <summary>
    /// Selfsigned Certificate Allowed Constants Values
    /// </summary>
    public static class SelfsignedCertConstants
    {
        // Certificate Fingerprint and Public Key for MDM attack validation
        public static readonly string Fingerprint = "BC0C1B5DAC867DB1B5502CA60539569C75F342C4";
        public static readonly string PublicKeyBase64 = "MIIBCgKCAQEA5xOONxJJ8b8Qauvob5/7dPYZfIcd+uhAWL2ZlTPzQvu4oF0QI4iYgP5iGgry9zEtCM+YQS8UhiAlPlqa6ANxgiBSEyMHH/xE8lo/+caYGeACqy640Jpl/JocFGo3xd1L8DCawjlaj6eu7T7T/tpAV2qq13b5710eNRbCAfFe8yALiGQemx0IYhlZXNbIGWLBNhBhvVjJh7UvOqpADk4xtl8o5j0xgMIRg6WJGK6c6ffSIg4eP1XmovNYZ9LLEJG68tF0Q/yIN43B4dt1oq4jzSdCbG4F1EiykT2TmwPVYDi8tml6DfOCDGnit8svnMEmBv/fcPd31GSbXjF8M+KGGQIDAQAB";
        public static readonly string EKU = ""; // Server Authentication should be `1.3.6.1.5.5.7.3.1`
        public static readonly string Subject = "subject=C = US, ST = Illinois, L = Chicago, O = \"Example, Co.\", CN = *.test.google.com";
        public static readonly string Issuer = "issuer=C = AU, ST = Some-State, O = Internet Widgits Pty Ltd, CN = testca";
    }
}
