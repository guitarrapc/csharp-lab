using Async.Core;
using System.Threading.Tasks;

namespace Async.Tests;

public class MyClientTest
{
    private readonly MyClient _client;
    private const string RequestUrl = "https://httpbin.org/get";

    public MyClientTest()
    {
        var delay = TimeSpan.FromMilliseconds(1000);
        var httpClient = new HttpClient(new DelayDummyHttpClientHandler(delay));
        _client = new MyClient(httpClient);
    }

    [Test]
    [Arguments(1200)]
    public async Task SuccessTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        var result = await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token);
        await Assert.That(result.StatusCode).IsEqualTo(System.Net.HttpStatusCode.OK);
    }

    [Test]
    [Arguments(100)]
    [Arguments(200)]
    public async Task TimeoutTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        await Assert.ThrowsAsync<TimeoutException>(async () => await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token));
    }

    [Test]
    [Arguments(100)]
    [Arguments(200)]
    public async Task OperationCancelledTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        cts.Cancel(); // OperationCanclled.
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token));
    }
}