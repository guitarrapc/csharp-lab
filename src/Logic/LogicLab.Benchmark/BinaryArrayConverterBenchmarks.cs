using BenchmarkDotNet.Attributes;
using LogicLab;

namespace Logic.Benchmark;

[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class BinaryArrayConverterBenchmarks
{
    [Benchmark]
    public void ToBinaryArrayInt()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayInt(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayConvertToString()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayConvertToString(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayIntMod()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntMod(i);
        }
    }

    [Benchmark]
    public void ToBinaryArrayIntModNumber()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntModNumber(i);
        }
    }
}
