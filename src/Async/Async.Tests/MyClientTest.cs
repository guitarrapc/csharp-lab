using Async.Core;

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

    [Theory]
    [InlineData(1200)]
    public async Task SuccessTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        var result = await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token);
        Assert.Equal(System.Net.HttpStatusCode.OK, result.StatusCode);
    }

    [Theory]
    [InlineData(100)]
    [InlineData(200)]
    public async Task TimeoutTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        await Assert.ThrowsAsync<TimeoutException>(async () => await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token));
    }

    [Theory]
    [InlineData(100)]
    [InlineData(200)]
    public async Task OperationCancelledTest(int timeoutMs)
    {
        using var cts = new CancellationTokenSource();
        var timeout = TimeSpan.FromMilliseconds(timeoutMs);
        cts.Cancel(); // OperationCanclled.
        await Assert.ThrowsAsync<OperationCanceledException>(async () => await _client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, RequestUrl), timeout, cts.Token));
    }
}
