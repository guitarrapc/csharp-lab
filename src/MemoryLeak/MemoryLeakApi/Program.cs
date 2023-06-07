using MemoryLeak.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Auto GC.Collect every 10000 request
var requestCountThreshold = int.Parse(Environment.GetEnvironmentVariable("AUTOCOLLECT_REQUESTCOUNT_THRESHOLD", EnvironmentVariableTarget.Process) ?? "10000");
using var allocator = new MemoryAllocator(requestCountThreshold, RequestReachedAction.AutoCollect);

// Configure the HTTP request pipeline.
app.MapGet("/", (HttpRequest request) => allocator.AllocateArrayPool(16));
app.MapGet("/alloc_static", (HttpRequest request) => allocator.AllocateStaticString(GetSize(request.Query, 512))); // 1KB
app.MapGet("/alloc_str", (HttpRequest request) => allocator.AllocateString(GetSize(request.Query, 512))); // 1KB
app.MapGet("/alloc_loh", (HttpRequest request) => allocator.AllocateLoH(GetSize(request.Query, 1024))); // 1KB
app.MapGet("/alloc_array", (HttpRequest request) => allocator.AllocateArray(GetSize(request.Query, 1024))); // 1KB
app.MapGet("/alloc_pool", (HttpRequest request) => allocator.AllocateArrayPool(GetSize(request.Query, 1024))); // 1KB
app.MapGet("/clear", () => allocator.Clear()); // no GC, just Clear
app.MapGet("/gc", () => allocator.Collect()); // Clear and GC

app.Run();

static int GetSize(IQueryCollection query, int defaultSize)
{
    var sizeStr = query["size"];
    var size = int.TryParse(sizeStr, out var value) ? value : 0;
    return size;
}
