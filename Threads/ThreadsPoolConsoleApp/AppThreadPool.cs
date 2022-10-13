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
}
