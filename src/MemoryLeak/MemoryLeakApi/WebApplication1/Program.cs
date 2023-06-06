using System.Buffers;
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/leak100kb", () =>
{
    ;
    return "ok";
});

app.MapGet("/fix", () =>
{
    return "ok";
});

app.Run();

public class MemoryAllocator
{
    private static readonly ConcurrentBag<string> staticStrings = new ConcurrentBag<string>();

    public string AllocateStaticString()
    {
        var str = new String('x', 10 * 1024);
        staticStrings.Add(str);
        return str;
    }

    public string AllocateString()
    {
        return new String('x', 10 * 1024);
    }

    public byte[] AllocateArray(int size)
    {
        var array = new byte[size];

        var random = new Random();
        random.NextBytes(array);

        return array;
    }

    public byte[] AllocateArrayPoolArray(int size)
    {
        var array = new PooledArray(size);
    
        var random = new Random();
        random.NextBytes(array.Array);

        return array.Array;
    }
}

public class PooledArray : IDisposable
{
    private static ArrayPool<byte> arrayPool = ArrayPool<byte>.Create();
    public byte[] Array { get; private set; }

    public PooledArray(int size)
    {
        Array = arrayPool.Rent(size);
    }

    public void Dispose()
    {
        arrayPool.Return(Array);
    }
}
