using MemoryPack;

namespace Serialization.Core;

[MemoryPackable]
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

    public void FillDummy()
    {
        Short = -18342;
        Int = 1117031887;
        Long = 7230604690804306497;
        Byte = 6;
        Bool = false;
        Char = 'Ψ';
        Float = 0.9143927f;
        Double = 0.9682891736991077d;
        Decimal = 0.778148585605472m;
        String = "a5d2a9bb-093f-4935-89a6-5b04290c3422";
    }

    // Call before serialize
    public void Initialize()
    {
        var rnd = new System.Random();
        Short = (short)rnd.Next();
        Int = (int)rnd.Next();
        Long = Long = rnd.NextInt64();
        Byte = (byte)rnd.Next();
        Char = (char)rnd.Next(0, 11840); // over 11840 includes CJK
        Float = (float)rnd.NextDouble();
        Double = rnd.NextDouble();
        Decimal = (decimal)rnd.NextDouble();
        String = Guid.NewGuid().ToString();
    }
}
