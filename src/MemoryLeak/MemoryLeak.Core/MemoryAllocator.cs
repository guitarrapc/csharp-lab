using System.Collections.Concurrent;

namespace MemoryLeak.Core;
public class MemoryAllocator : IDisposable
{
    private static readonly ConcurrentBag<string> staticStringBags = new ();

    private readonly ConcurrentBag<string> stringBags = new ();
    private readonly ConcurrentBag<byte[]> arrayBags = new ();
    private readonly ConcurrentBag<PooledArray> pooledArrayBags = new();

    /// <summary>
    /// Allocate String to static field
    /// </summary>
    /// <param name="size">5120 = 10KB</param>
    public void AllocateStaticString(int size = 5120)
    {
        var str = new string('x', size);
        staticStringBags.Add(str);
    }

    /// <summary>
    /// Allocate String
    /// </summary>
    /// <param name="size">5120 = 10KB</param>
    public void AllocateString(int size = 5120)
    {
        var str = new string('y', size);
        stringBags.Add(str);
    }

    /// <summary>
    /// Allocate LoH
    /// </summary>
    /// <param name="size">102400 = 10KB</param>
    public void AllocateLoH(int size = 10240)
    {
        var array = new byte[size];
        arrayBags.Add(array);
    }

    /// <summary>
    /// Allocate ArrayPool Shared memory.
    /// </summary>
    /// <param name="size">2048 = 2KB, 4098 = 8KB</param>
    public void AllocateArrayPoolArray(int size)
    {
        var array = new PooledArray(size);
        pooledArrayBags.Add(array);
    }

    public void Clear()
    {
        staticStringBags.Clear();
        stringBags.Clear();
        arrayBags.Clear();
        foreach (var pooledArray in pooledArrayBags)
        {
            pooledArray.Return();
        }
        pooledArrayBags.Clear();
    }

    public void Dispose()
    {
        Clear();

        GC.Collect();
        GC.Collect(); // GC incremented generation
    }
}
