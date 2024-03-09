namespace Serialization.Core;

public partial class Primitives
{
    public short Short { get; set; }
    public int Int { get; set; }
    public long Long { get; set; }
    public byte Byte { get; set; }
    public bool Bool { get; set; }
    public char Char { get; set; }
    public float Float { get; set; }
    public double Double { get; set; }
    public decimal Decimal { get; set; }
    public string String { get; set; } = default!;

    // Call before serialize
    public void Initialize()
    {
        var rnd = new System.Random();
        Short = (short)rnd.Next();
        Int = (int)rnd.Next();
        Long = (short)rnd.Next();
        Byte = (byte)rnd.Next();
        Char = (char)rnd.Next();
        Float = (float)rnd.NextDouble();
        Double = rnd.NextDouble();
        Decimal = (decimal)rnd.NextDouble();
        String = Guid.NewGuid().ToString();
    }
}
