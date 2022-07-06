public class ExponentialBackoff
{
    private readonly int _delayMilliseconds;
    private readonly int _maxDelayMilliseconds;
    public int Retries => _retries;
    private int _retries;
    private int _pow;

    public ExponentialBackoff(int delayMilliseconds, int maxDelayMilliseconds)
    {
        _delayMilliseconds = delayMilliseconds;
        _maxDelayMilliseconds = maxDelayMilliseconds;
        _retries = 0;
        _pow = 0;
    }

    public async ValueTask DelayAsync(CancellationToken ct = default)
    {
        Interlocked.Increment(ref _retries);
        if (_retries < 31)
        {
            Interlocked.Increment(ref _pow);
        }
        var delay = (Math.Min(_delayMilliseconds * (int)Math.Pow(2, _pow - 1), _maxDelayMilliseconds)); // Exponential. If delay is 1000 then 1s,2s,4s,8s,16s... max will clamp to maxDelay
        await Task.Delay(delay, ct).ConfigureAwait(false);
    }
}

public static class SandboxExponentialBackoff
{
    public static async Task RunAsync()
    {
        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)); // whole limit second
            var limit = 0;
            var exponentialBackoff = new ExponentialBackoff(1000, 10000);
            while (limit++ < 10)
            {
                Console.WriteLine($"[{DateTime.Now}]: Class. retries: {exponentialBackoff.Retries}");
                await exponentialBackoff.DelayAsync(cts.Token);
            }
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("timeout reached.");
        }
    }
}

public static class MinimumExponentialBackoff
{
    public static async Task RunAsync()
    {
        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)); // whole limit second
            var retries = 0;
            var maxRetry = 10;
            do
            {
                Console.WriteLine($"[{DateTime.Now}]: Minimum. retries: {retries}");
                await Task.Delay((Math.Min((int)Math.Pow(2, retries), maxRetry) * 1000), cts.Token); // Exponential. 1s,2s,4s,8s,16s... max will clamp to 10s
            } while (retries++ < 10);
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("timeout reached.");
        }
    }
}
