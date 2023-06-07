using MemoryLeak.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
using var allocator = new MemoryAllocator();

// Configure the HTTP request pipeline.
app.MapGet("/", (HttpRequest request) => allocator.AllocateStaticString(5120)); // 10KB
app.MapGet("/alloc_static", (HttpRequest request) => allocator.AllocateStaticString(GetSize(request.Query, 5120))); // 10KB
app.MapGet("/alloc_str", (HttpRequest request) => allocator.AllocateString(GetSize(request.Query, 5120))); // 10KB
app.MapGet("/alloc_loh", (HttpRequest request) => allocator.AllocateLoH(GetSize(request.Query, 10240))); // 10KB
app.MapGet("/alloc_pool", (HttpRequest request) => allocator.AllocateArrayPoolArray(GetSize(request.Query, 8192))); // 10KB
app.MapGet("/clear", () => allocator.Clear()); // no GC, just Clear
app.MapGet("/gc", () => allocator.Collect()); // Clear and GC

app.Run();

static int GetSize(IQueryCollection query, int defaultSize)
{
    var sizeStr = query["size"];
    var size = int.TryParse(sizeStr, out var value) ? value : 0;
    return size;
}
