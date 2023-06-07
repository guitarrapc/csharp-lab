using System.Collections.Concurrent;

namespace MemoryLeak.Core;

public enum RequestReachedAction
{
    Nothing,
    AutoClear,
    AutoCollect,
}

public class MemoryAllocator : IDisposable
{
    private static readonly ConcurrentBag<string> staticStringBags = new();

    // NOTE: Don't use ConcurrentBag, it allocates memory when Add(T).
    private readonly List<string> stringBags = new();
    private readonly List<byte[]> arrayBags = new();
    private readonly List<PooledArray> pooledArrayBags = new();
    private readonly List<byte[]> allocateArrayBags = new();
    private readonly object gate = new object();

    private readonly RequestCountHandler request;

    public MemoryAllocator() : this(int.MaxValue, RequestReachedAction.Nothing)
    {
    }

    public MemoryAllocator(int requestCountThreshold, RequestReachedAction requestReachedAction)
    {
        request = requestReachedAction switch
        {
            RequestReachedAction.Nothing => new RequestCountHandler(requestCountThreshold, allocator => { }, this),
            RequestReachedAction.AutoClear => new RequestCountHandler(requestCountThreshold, allocator => allocator.Clear(), this),
            RequestReachedAction.AutoCollect => new RequestCountHandler(requestCountThreshold, allocator => allocator.Collect(), this),
            _ => throw new NotSupportedException(),
        };
    }

    /// <summary>
    /// Allocate String to static field
    /// </summary>
    /// <param name="size">5120 = 10KB</param>
    public void AllocateStaticString(int size = 5120)
    {
        request?.Increment();

        var str = new string('x', size);
        lock (staticStringBags)
        {
            staticStringBags.Add(str);
        }
    }

    /// <summary>
    /// Allocate String
    /// </summary>
    /// <param name="size">5120 = 10KB</param>
    public void AllocateString(int size = 5120)
    {
        request?.Increment();

        var str = new string('y', size);
        lock (stringBags)
        {
            stringBags.Add(str);
        }
    }

    /// <summary>
    /// Allocate LoH
    /// </summary>
    /// <param name="size">102400 = 10KB</param>
    public void AllocateLoH(int size = 10240)
    {
        request?.Increment();

        var array = new byte[size];
        lock (arrayBags)
        {
            arrayBags.Add(array);
        }
    }

    /// <summary>
    /// Allocate Array from low GC
    /// </summary>
    /// <param name="size">2048 = 2KB, 4098 = 8KB</param>
    public void AllocateArray(int size)
    {
        request?.Increment();

        var array = GC.AllocateArray<byte>(size);
        lock (allocateArrayBags)
        {
            allocateArrayBags.Add(array);
        }
    }

    /// <summary>
    /// Allocate ArrayPool Shared memory.
    /// </summary>
    /// <param name="size">2048 = 2KB, 4098 = 8KB</param>
    public void AllocateArrayPool(int size)
    {
        request?.Increment();

        var array = new PooledArray(size);
        lock (pooledArrayBags)
        {
            pooledArrayBags.Add(array);
        }
    }

    /// <summary>
    /// Clear references inside allocator
    /// </summary>
    public void Clear()
    {
        lock (gate)
        {
            request?.Reset();

            staticStringBags.Clear();
            stringBags.Clear();
            arrayBags.Clear();
            allocateArrayBags.Clear();
            foreach (var pooledArray in pooledArrayBags)
            {
                pooledArray.Return();
            }
            pooledArrayBags.Clear();
        }
    }

    /// <summary>
    /// Clear references and run GC Collect
    /// </summary>
    public void Collect()
    {
        Clear();

        GC.Collect();
        GC.Collect(2, GCCollectionMode.Forced, true, true); // Full GC Collection == Force GC, Blocking and compacting
        GC.WaitForPendingFinalizers();
    }

    public void Dispose()
    {
        Clear();
    }
}
