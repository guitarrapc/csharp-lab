Console.WriteLine($"SandboxConsoleApp running. {string.Join(" ", args)}");

await Task.WhenAll(MinimumExponentialBackoff.RunAsync(), SandboxExponentialBackoff.RunAsync());
