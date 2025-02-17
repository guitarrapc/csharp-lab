namespace Async.Core;

public class MyClient(HttpClient httpClient)
{
    /// <summary>
    /// Handling Timeout, Cancel and success sample
    /// </summary>
    /// <param name="message"></param>
    /// <param name="timeout"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="OperationCanceledException"></exception>
    /// <exception cref="TimeoutException"></exception>
    public async Task<HttpResponseMessage> RequestAsync(HttpRequestMessage message, TimeSpan timeout, CancellationToken cancellationToken)
    {
        // Create CancelltationToken to link Timeout and Cancel.
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(timeout); // timeout handling

        try
        {
            // Both Timeout and Cancel will cancel SendAsync, or it succeed if not cancel occur.
            var result = await httpClient.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, cts.Token);
            return result;
        }
        catch (OperationCanceledException ex) when (ex.CancellationToken == cts.Token)
        {
            // Cancel should swap linked CancellationToken to invokation CancellationToken, so that caller can identify your token is cause of cancellation.
            if (cancellationToken.IsCancellationRequested)
            {
                throw new OperationCanceledException(ex.Message, ex, cancellationToken);
            }
            else
            {
                // throw Timeout when CancellationToken is not canceld but OperationCanceledException occur.
                throw new TimeoutException($"The request was canceled due to the configured Timeout of {timeout.TotalSeconds} seconds elapsing.", ex);
            }

            throw;
        }
    }
}

/// <summary>
/// HttpHandler inject delay before every request.
/// </summary>
public class DelayDummyHttpClientHandler : DelegatingHandler
{
    private readonly TimeSpan _delayTimespan;
    public DelayDummyHttpClientHandler(TimeSpan delayTimespan)
    {
        _delayTimespan = delayTimespan;
        InnerHandler = new HttpClientHandler();
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        await Task.Delay(_delayTimespan, cancellationToken).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

        // swap response with dummy.
        //return await base.SendAsync(request, cancellationToken);
        return await Task.Run(() => new HttpResponseMessage
        {
            StatusCode = System.Net.HttpStatusCode.OK,
            Content = new StringContent($$"""
                {
                  "args": {},
                  "headers": {
                    "Host": "example.com",
                    "X-Amzn-Trace-Id": "Root=1-1234567a-abcdefghijklmn1234567890"
                  },
                  "origin": "192.168.1.1",
                  "url": "{{request.RequestUri}}"
                }
                """)
        }, cancellationToken);
    }
}
