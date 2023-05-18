namespace ThreadsPoolConsoleApp;

public static class AppThreadPool
{
    /// <summary>
    /// Configure Thread pool.
    /// DO NOT Set minimum ThreadPool to be max thread size. Too much size cause severe condition on High request scenario.
    /// </summary>
    public static void Configure(int minThreads = 200, int maxThreads = 200)
    {
        ThreadPool.SetMinThreads(minThreads, maxThreads);
    }

    public static void ShowCurrent()
    {
        ThreadPool.GetMaxThreads(out var maxWorkerThreads, out var maxCompletionThreads);
        ThreadPool.GetMinThreads(out var minWorkerThreads, out var minCompletionThreads);
        ThreadPool.GetAvailableThreads(out var availableWorkerThreads, out var availableCompletionThreads);

        static string Show(int value)
        {
            const string titleWorker = "WorkerThreads";
            var padding = titleWorker.Length;
            return string.Format($"{{0, -{padding}}}", value);
        }
        var now = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"{now} | WorkerThreads | CompletionThreads ");
        Console.WriteLine($"-------- | ------------- | ----------------- ");
        Console.WriteLine($"Max      | {Show(maxWorkerThreads)} | {maxCompletionThreads}");
        Console.WriteLine($"Min      | {Show(minWorkerThreads)} | {minCompletionThreads}");
        Console.WriteLine($"Available| {Show(availableWorkerThreads)} | {availableCompletionThreads}");
    }
}
