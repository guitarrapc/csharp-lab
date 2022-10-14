namespace ThreadsPoolConsoleApp;

public static class AppThreadPool
{
    /// <summary>
    /// Configure Thread pool.
    /// </summary>
    public static void Configure()
    {
        // Set minimum ThreadPool to be max size. (it not means creat thread.)
        ThreadPool.GetMaxThreads(out var workerThreads, out var completionThreads);
        ThreadPool.SetMinThreads(workerThreads, completionThreads);
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
