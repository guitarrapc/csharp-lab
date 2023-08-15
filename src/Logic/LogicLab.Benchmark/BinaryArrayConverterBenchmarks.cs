using BenchmarkDotNet.Attributes;

namespace LogicLab.Benchmark;

[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class BinaryArrayConverterBenchmarks
{
    [Benchmark]
    public void BinaryArrayToBinaryArrayInt()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayInt(i);
        }
    }

    [Benchmark]
    public void BinaryArrayToBinaryArrayConvertToString()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayConvertToString(i);
        }
    }

    [Benchmark]
    public void BinaryArrayToBinaryArrayIntMod()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntMod(i);
        }
    }

    [Benchmark]
    public void BinaryArrayToBinaryArrayIntModNumber()
    {
        for (byte i = 0; i < 255; i++)
        {
            BinaryArrayConverter.ToBinaryArrayIntModNumber(i);
        }
    }
}
