using System.Diagnostics;

namespace Logic.Core;

public class ExponentialBackoff
{
    private readonly int _delayMilliseconds;
    private readonly int _maxDelayMilliseconds;
    private readonly int _maxRetries;
    private readonly TimeSpan? _timeout;
    private readonly Stopwatch? _sw;
    public int Retries => _retries;
    private int _retries = 0;
    private int _pow = 0;

    public ExponentialBackoff(
        int delayMilliseconds,
        int maxDelayMilliseconds,
        int maxRetries = int.MaxValue,
        TimeSpan? timeout = null)
    {
        if (delayMilliseconds <= 0)
            throw new ArgumentOutOfRangeException(nameof(delayMilliseconds), "Must be positive.");
        if (maxDelayMilliseconds < delayMilliseconds)
            throw new ArgumentOutOfRangeException(nameof(maxDelayMilliseconds), "Must be >= delayMilliseconds.");
        if (maxRetries <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxRetries), "Must be positive.");

        _delayMilliseconds = delayMilliseconds;
        _maxDelayMilliseconds = maxDelayMilliseconds;
        _maxRetries = maxRetries;
        _timeout = timeout;
        _sw = timeout.HasValue ? Stopwatch.StartNew() : null;
    }

    public async ValueTask DelayAsync(CancellationToken ct = default)
    {
        if (ct.IsCancellationRequested)
            throw new OperationCanceledException();

        // check retry
        var currentRetry = Interlocked.Increment(ref _retries);
        if (currentRetry > _maxRetries)
            throw new OperationCanceledException("Cancellation requested.", ct);

        // check timeout
        if (_timeout.HasValue && _sw!.Elapsed >= _timeout.Value)
            throw new OperationCanceledException($"Exponential backoff exceeded timeout of {_timeout.Value}.", ct);

        if (_retries < 31)
            Interlocked.Increment(ref _pow);

        var delay = Math.Min(_delayMilliseconds * (int)Math.Pow(2, _pow - 1), _maxDelayMilliseconds);

        // adjust delay for timeout
        if (_timeout.HasValue)
        {
            var remaining = _timeout.Value - _sw!.Elapsed;
            if (remaining <= TimeSpan.Zero)
                throw new OperationCanceledException($"Exponential backoff exceeded timeout of {_timeout.Value}.", ct);

            delay = Math.Min(delay, (int)remaining.TotalMilliseconds);
        }

        try
        {
            await Task.Delay(delay, ct).ConfigureAwait(false);
        }
        catch (TaskCanceledException)
        {
            throw new OperationCanceledException("Delay was cancelled.", ct);
        }
    }

    public void Reset()
    {
        _retries = 0;
        _pow = 0;
        _sw?.Restart();
    }
}

public static class SandboxExponentialBackoff
{
    public static async Task RunAsync(int delayMs, int maxDelayMs, int retry, TimeSpan timeout)
    {
        try
        {
            using var cts = new CancellationTokenSource(timeout);
            var exponentialBackoff = new ExponentialBackoff(delayMs, maxDelayMs, retry, timeout);
            var sw = Stopwatch.StartNew();
            long prev = 0;

            while (true)
            {
                await exponentialBackoff.DelayAsync(cts.Token);
                Console.WriteLine($"[{DateTime.Now}] retries: {exponentialBackoff.Retries}, diff: {(int)(sw.Elapsed.TotalMilliseconds - prev)}ms");
                prev = sw.ElapsedMilliseconds;
            }
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine($"Operation cancelled: {ex.Message}");
        }

        Console.WriteLine("completed.");
    }
}
