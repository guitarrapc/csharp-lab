using System.Buffers;

namespace MemoryLeak.Core;

/*
 * Presudo code
 * 
    var pool = ArrayPool<byte>.Create();
    for (var i = 0; i < N; i++)
    {
        var array = pool.Rent(8192);
        _bags.Add(array);
    }

    foreach (var array in _bags)
    {
        pool.Return(array);
    }

    _bags.Clear();
 */

public readonly struct PooledArray
{
    private static ArrayPool<byte> arrayPool = ArrayPool<byte>.Shared;
    public readonly byte[] Array;

    public PooledArray(int size)
    {
        Array = arrayPool.Rent(size);
    }

    public void Return()
    {
        arrayPool.Return(Array!);
    }
}
