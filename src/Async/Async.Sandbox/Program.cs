using Async.Core;

const string url = "https://httpbin.org/get";
var delay = TimeSpan.FromMilliseconds(1000);
var httpClient = new HttpClient(new DelayDummyHttpClientHandler(delay));
var client = new MyClient(httpClient);
using var cts = new CancellationTokenSource();

// success (timeout > delay)
var result = await client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, url), TimeSpan.FromMilliseconds(1500), cts.Token);
Console.WriteLine(result);

// timeout (timeout < delay)
try { _ = await client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, url), TimeSpan.FromMilliseconds(100), cts.Token); }
catch (TimeoutException tex) { Console.WriteLine($"Timeout. {tex.Message}"); }

// cancel
cts.Cancel();
try { _ = await client.RequestAsync(new HttpRequestMessage(HttpMethod.Get, url), TimeSpan.FromMilliseconds(100), cts.Token); }
catch (OperationCanceledException oex) { Console.WriteLine($"Cancelled. {oex.Message}"); }

