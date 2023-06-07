namespace MemoryLeak.Core;

public class RequestCountHandler
{
    public int RequestedCount => currentRequestCount;
    private int currentRequestCount = 0;

    private readonly int requestCountThreshold;
    private readonly Action<MemoryAllocator>? onRequestCountReached;
    private readonly MemoryAllocator allocator;

    public RequestCountHandler(int requestCountThreshold, Action<MemoryAllocator>? onRequestCountReached, MemoryAllocator allocator)
    {
        this.requestCountThreshold = requestCountThreshold;
        this.onRequestCountReached = onRequestCountReached;
        this.allocator = allocator;
    }

    /// <summary>
    /// Increment request count
    /// </summary>
    public void Increment()
    {
        Interlocked.Increment(ref currentRequestCount);

        if (currentRequestCount > requestCountThreshold)
        {
            onRequestCountReached?.Invoke(allocator);
        }
    }
    /// <summary>
    /// Reset request count
    /// </summary>
    public void Reset() => Interlocked.Exchange(ref currentRequestCount, 0);
}
