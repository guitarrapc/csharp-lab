using MemoryPack;

namespace Serialization.Core;

public enum TestEnum
{
    one, two, three
}

[MemoryPackable]
public partial class HyperClass
{
    public Guid? Gn { get; set; }
    public int A { get; set; }
    public long B { get; set; }
    public DateTime C { get; set; }
    public uint D { get; set; }
    public decimal E { get; set; }
    public TimeSpan F { get; set; }
    public Guid G { get; set; }
    public TestEnum H { get; set; }

    public void FillDummy()
    {
        Gn = null;
        A = 1566411337;
        B = 3369950072111981502;
        C = new DateTime(1997, 06, 20, 13, 28, 19);
        D = 676867901U;
        E = 0.440611945264302m;
        F = TimeSpan.Parse("14192.22:27:19");
        G = Guid.Parse("28e229b2-6478-4326-8516-07fd9afa80d2");
        H = TestEnum.one;
    }

    // Call before serialize
    public void Initialize()
    {
        var rnd = new System.Random();
        A = rnd.Next();
        B = rnd.NextInt64();
        C = new DateTime(1970, 1, 1).AddSeconds(rnd.Next());
        D = (uint)rnd.Next();
        E = (decimal)rnd.NextDouble();
        F = TimeSpan.FromSeconds(rnd.Next());
        G = Guid.NewGuid();
        H = (TestEnum)rnd.Next(0, 2);
    }
}
