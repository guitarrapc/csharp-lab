using System.Diagnostics;

namespace LogicLab;

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
        var delay = Math.Min(_delayMilliseconds * (int)Math.Pow(2, _pow - 1), _maxDelayMilliseconds); // Exponential. If delay is 1000 then 1s,2s,4s,8s,16s... max will clamp to maxDelay
        await Task.Delay(delay, ct).ConfigureAwait(false);
    }
}

public static class SandboxExponentialBackoff
{
    public static async Task RunAsync(int delayMs, int maxDelayMs, int retry, TimeSpan timeout)
    {
        try
        {
            using var cts = new CancellationTokenSource(timeout); // whole limit second
            var retries = 1;
            var exponentialBackoff = new ExponentialBackoff(delayMs, maxDelayMs);
            var sw = Stopwatch.StartNew();
            long prev = 0;
            do
            {
                await exponentialBackoff.DelayAsync(cts.Token);
                Console.WriteLine($"[{DateTime.Now}] retries: {exponentialBackoff.Retries}, diff: {(int)(sw.Elapsed.TotalMilliseconds - prev)}ms");
                prev = sw.ElapsedMilliseconds;
            }
            while (retries++ < retry);
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("timeout reached.");
        }

        Console.WriteLine("completed.");
    }
}
