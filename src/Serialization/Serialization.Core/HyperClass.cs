namespace Serialization.Core;

public enum TestEnum
{
    one, two, three
}

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
