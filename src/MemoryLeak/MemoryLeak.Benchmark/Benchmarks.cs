using BenchmarkDotNet.Attributes;
using MemoryLeak.Core;

namespace MemoryLeak.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
public class MemoryLeakBenchmarks : IDisposable
{
    [Params(10, 100)]
    public int N;
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

        for (var i = 0; i < N; i++)
        {
            _allocator.AllocateStaticString(5120); // 10KB
        }
    }

    [Benchmark]
    public void AllocateString()
    {
        // _allocator.AllocateString(5120); // 10KB
        // _allocator.AllocateString(51200); // 100KB
        // _allocator.AllocateString(51200 * 10); // 1000KB

        for (var i = 0; i < N; i++)
        {
            _allocator.AllocateString(5120); // 10KB
        }
    }

    [Benchmark]
    public void AllocateLoH()
    {
        // _allocator.AllocateLoH(1024); // 1KB
        // _allocator.AllocateLoH(10240); // 10KB
        // _allocator.AllocateLoH(10240 * 2); // 20KB

        for (var i = 0; i < N; i++)
        {
            _allocator.AllocateLoH(10240); // 10KB * 10
        }
    }

    [Benchmark]
    public void AllocateArrayPoolArray()
    {
        // _allocator.AllocateArrayPoolArray(1024); // 1KB
        // _allocator.AllocateArrayPoolArray(2048); // 2KB
        // _allocator.AllocateArrayPoolArray(4096); // 4KB
        // _allocator.AllocateArrayPoolArray(2048 + 4096); // 8KB
        // _allocator.AllocateArrayPoolArray(8192); // 8KB
        // _allocator.AllocateArrayPoolArray(10240); // 16KB
        // _allocator.AllocateArrayPoolArray(10240 * 2); // 32KB

        for (var i = 0; i < N; i++)
        {
            _allocator.AllocateArrayPoolArray(2048); // 2KB
            _allocator.AllocateArrayPoolArray(8192); // 8KB
        }
    }
}
