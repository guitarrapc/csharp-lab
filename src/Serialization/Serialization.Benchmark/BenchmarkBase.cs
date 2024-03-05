using Serialization.Core;
using System.Text.Json;

namespace Serialization.Benchmark;

public class BenchmarkBase
{
    // Complex
    public static IEnumerable<HyperClass> TestComplexData()
    {
        var data = new HyperClass();
        data.Initialize();
        yield return data;
    }

    public static IEnumerable<string> TestComplexJson()
    {
        var data = new HyperClass();
        data.Initialize();
        yield return JsonSerializer.Serialize(data);
    }

    // Simple
    public static IEnumerable<MyClass> TestSimpleData()
    {
        var data = new MyClass();
        data.Initialize();
        yield return data;
    }

    public static IEnumerable<string> TestSimpleJson()
    {
        var data = new MyClass();
        data.Initialize();
        yield return JsonSerializer.Serialize(data);
    }

    // Primitives
    public static IEnumerable<Primitives> TestPrimitivesData()
    {
        var data = new Primitives();
        data.Initialize();
        yield return data;
    }

    public static IEnumerable<string> TestPrimitivesJson()
    {
        var data = new Primitives();
        data.Initialize();
        yield return JsonSerializer.Serialize(data);
    }

    // Nest
    public static IEnumerable<NestClass> TestNestData()
    {
        var data = new NestClass();
        data.Initialize();
        yield return data;
    }

    public static IEnumerable<string> TestNestJson()
    {
        var data = new NestClass();
        data.Initialize();
        yield return JsonSerializer.Serialize(data);
    }
}
