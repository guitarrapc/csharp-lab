```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.43 ms** |   **4.528 ms** | **0.248 ms** |  **12.27 ms** |  **12.71 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **760.87 ms** | **118.872 ms** | **6.516 ms** | **753.75 ms** | **766.53 ms** |    **4120 B** |
