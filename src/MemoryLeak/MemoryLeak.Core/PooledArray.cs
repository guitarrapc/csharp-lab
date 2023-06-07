using System.Buffers;

namespace MemoryLeak.Core;

public class PooledArray : IDisposable
{
    private static ArrayPool<byte> arrayPool = ArrayPool<byte>.Create();
    public byte[] Array { get; private set; }

    public PooledArray(int size)
    {
        Array = arrayPool.Rent(size);
    }

    public void Return()
    {
        arrayPool.Return(Array);
    }

    public void Dispose()
    {
        Return();
    }
}
