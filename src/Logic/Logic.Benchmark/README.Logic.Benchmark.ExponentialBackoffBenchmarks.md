```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.16 ms** |   **0.925 ms** | **0.051 ms** |  **12.12 ms** |  **12.22 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **757.23 ms** | **108.681 ms** | **5.957 ms** | **753.77 ms** | **764.11 ms** |    **4120 B** |
