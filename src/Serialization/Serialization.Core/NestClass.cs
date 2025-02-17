namespace Serialization.Core;

// MemoryPack does not support Nest Class
public partial class NestClass
{
    public partial class Inner
    {
        public int Int { get; set; }
        public double Double { get; set; }
        public string String { get; set; }

        public Inner()
        {
            var rnd = new System.Random();
            Int = rnd.Next();
            Double = rnd.NextDouble();
            String = Guid.NewGuid().ToString();
        }
    }

    public Inner A { get; set; } = default!;
    public Inner B { get; set; } = default!;
    public Inner C { get; set; } = default!;
    public Inner D { get; set; } = default!;
    public Inner E { get; set; } = default!;
    public Inner F { get; set; } = default!;
    public Inner G { get; set; } = default!;
    public Inner H { get; set; } = default!;
    public Inner I { get; set; } = default!;

    public void FillDummy()
    {
        A = new Inner
        {
            Int = 534652575,
            Double = 0.20024573508601418d,
            String = "60266e49-76cf-4ac0-b71d-fd1c575528ff",
        };
        B = new Inner
        {
            Int = 767836572,
            Double = 0.5744131010151348d,
            String = "4ed1ea16-d2ce-4b46-ac15-091b4377348c",
        };
        C = new Inner
        {
            Int = 1641845322,
            Double = 0.5980141202813583d,
            String = "ae8da83b-2bfe-4974-83c8-f83f2375b448",
        };
        D = new Inner
        {
            Int = 2066814107,
            Double = 0.0714152323197359d,
            String = "6006fcc1-4a09-4a73-8122-810757719f85",
        };
        E = new Inner
        {
            Int = 158769796,
            Double = 0.3683387070053934d,
            String = "e64b15aa-bc58-4333-a8f9-9b1d849768df",
        };
        F = new Inner
        {
            Int = 1364137538,
            Double = 0.06763043837603833d,
            String = "82424621-c869-42bc-961b-52ff5954cae2",
        };
        G = new Inner
        {
            Int = 1163138910,
            Double = 0.8659520402202101d,
            String = "6873e453-87cb-42c7-b1f3-da545761ccf6",
        };
        H = new Inner
        {
            Int = 1625046231,
            Double = 0.4831041576967343d,
            String = "29cfc673-931a-41dc-b965-0c713c84872a",
        };
        I = new Inner
        {
            Int = 765756951,
            Double = 0.05202887052269267d,
            String = "eabe1949-f9f5-4971-8ed9-b9bf374da3de",
        };
    }

    // Call before serialize
    public void Initialize()
    {
        A = new Inner();
        B = new Inner();
        C = new Inner();
        D = new Inner();
        E = new Inner();
        F = new Inner();
        G = new Inner();
        H = new Inner();
        I = new Inner();
    }
}
