using BenchmarkDotNet.Attributes;
using Logic.Core;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class BinaryArrayConverterBenchmarks
{
    [Params(1, 3)]
    public int Number { get; set; }

    [Benchmark]
    public void ToBinaryArrayInt()
    {
        for (byte i = 0; i < Number; i++)
        {
            BinaryArrayConverter.ToBinaryArrayInt(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayConvertToString()
    {
        for (byte i = 0; i < Number; i++)
        {
            BinaryArrayConverter.ToBinaryArrayConvertToString(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayIntMod()
    {
        for (byte i = 0; i < Number; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntMod(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayIntModNumber()
    {
        for (byte i = 0; i < Number; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntModNumber(i);
        }
    }
}
