```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.10 ms** |   **0.783 ms** | **0.043 ms** |  **12.07 ms** |  **12.15 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **760.86 ms** | **114.680 ms** | **6.286 ms** | **753.99 ms** | **766.32 ms** |    **4120 B** |
