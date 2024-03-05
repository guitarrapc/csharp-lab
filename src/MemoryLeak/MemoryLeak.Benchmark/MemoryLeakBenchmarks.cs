using BenchmarkDotNet.Attributes;
using MemoryLeak.Core;
using System.Buffers;

namespace MemoryLeak.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class MemoryLeakBenchmarks : IDisposable
{
    [Params(1, 3)]
    public int Number { get; set; }

    private readonly MemoryAllocator _allocator;

    public MemoryLeakBenchmarks()
    {
        _allocator = new MemoryAllocator();
    }

    [GlobalCleanup]
    public void Dispose()
    {
        _allocator.Dispose();
    }

    [Benchmark]
    public void AllocateStringStatic()
    {
        // _allocator.AllocateStaticString(5120); // 10KB
        // _allocator.AllocateStaticString(51200); // 100KB
        // _allocator.AllocateStaticString(51200 * 10); // 1000KB

        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateStaticString(512); // 1KB
        }
    }

    [Benchmark]
    public void AllocateString()
    {
        // _allocator.AllocateString(5120); // 10KB
        // _allocator.AllocateString(51200); // 100KB
        // _allocator.AllocateString(51200 * 10); // 1000KB

        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateString(512); // 1KB
        }
    }

    [Benchmark]
    public void AllocateLoH()
    {
        // _allocator.AllocateLoH(1024); // 1KB
        // _allocator.AllocateLoH(10240); // 10KB
        // _allocator.AllocateLoH(10240 * 2); // 20KB

        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateLoH(1024); // 1KB
        }
    }

    [Benchmark]
    public void AllocateArray()
    {
        //_allocator.AllocateArray(1024); // 1KB
        //_allocator.AllocateArray(10240); // 10KB
        //_allocator.AllocateArray(10240 * 2); // 20KB

        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateArray(1024); // 1KB
        }
    }

    [Benchmark]
    public void AllocateArrayPool()
    {
        // _allocator.AllocateArrayPool(1024); // 1KB
        // _allocator.AllocateArrayPool(2048); // 2KB
        // _allocator.AllocateArrayPool(4096); // 4KB
        // _allocator.AllocateArrayPool(2048 + 4096); // 8KB
        // _allocator.AllocateArrayPool(8192); // 8KB
        // _allocator.AllocateArrayPool(10240); // 16KB
        // _allocator.AllocateArrayPool(10240 * 2); // 32KB

        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateArrayPool(768);
        }
    }
}

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class NoAllocMemoryLeakBenchmarks
{
    [Params(1, 10)]
    public int Number { get; set; }

    private readonly MemoryAllocator _allocator;
    private readonly List<byte[]> _returnRentBags;

    public NoAllocMemoryLeakBenchmarks()
    {
        _allocator = new MemoryAllocator();
        _returnRentBags = new List<byte[]>();
    }

    [Benchmark]
    public void RentReturn()
    {
        var pool = ArrayPool<byte>.Shared;
        for (var i = 0; i < Number; i++)
        {
            var array = pool.Rent(1024);
            _returnRentBags.Add(array);
        }

        foreach (var array in _returnRentBags)
        {
            pool.Return(array);
        }

        _returnRentBags.Clear();
    }

    [Benchmark]
    public void AllocateArrayPool()
    {
        for (var i = 0; i < Number; i++)
        {
            _allocator.AllocateArrayPool(256); // 2KB
        }

        _allocator.Clear();
    }
}
