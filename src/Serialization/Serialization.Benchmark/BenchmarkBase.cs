using MemoryPack;
using Serialization.Core;
using System.Text.Json;

namespace Serialization.Benchmark;

public class BenchmarkBase
{
    // Complex
    public static IEnumerable<HyperClass> TestComplexData()
    {
        var data = new HyperClass();
        data.FillDummy();
        yield return data;
    }

    public static IEnumerable<string> TestComplexJson()
    {
        var data = new HyperClass();
        data.FillDummy();
        yield return JsonSerializer.Serialize(data);
    }

    public static IEnumerable<byte[]> TestComplexMemoryPack()
    {
        var data = new HyperClass();
        data.FillDummy();
        yield return MemoryPackSerializer.Serialize(data);
    }

    // Simple
    public static IEnumerable<MyClass> TestSimpleData()
    {
        var data = new MyClass();
        data.FillDummy();
        yield return data;
    }

    public static IEnumerable<string> TestSimpleJson()
    {
        var data = new MyClass();
        data.FillDummy();
        yield return JsonSerializer.Serialize(data);
    }

    public static IEnumerable<byte[]> TestSimpleMemoryPack()
    {
        var data = new MyClass();
        data.FillDummy();
        yield return MemoryPackSerializer.Serialize(data);
    }

    // Primitives
    public static IEnumerable<Primitives> TestPrimitivesData()
    {
        var data = new Primitives();
        data.FillDummy();
        yield return data;
    }

    public static IEnumerable<string> TestPrimitivesJson()
    {
        var data = new Primitives();
        data.FillDummy();
        yield return JsonSerializer.Serialize(data);
    }

    public static IEnumerable<byte[]> TestPrimitivesMemoryPack()
    {
        var data = new Primitives();
        data.FillDummy();
        yield return MemoryPackSerializer.Serialize(data);
    }

    // Nest
    public static IEnumerable<NestClass> TestNestData()
    {
        var data = new NestClass();
        data.FillDummy();
        yield return data;
    }

    public static IEnumerable<string> TestNestJson()
    {
        var data = new NestClass();
        data.FillDummy();
        yield return JsonSerializer.Serialize(data);
    }
}
