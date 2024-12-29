```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.15 ms** |  **1.646 ms** | **0.090 ms** |  **12.08 ms** |  **12.25 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **754.56 ms** | **24.505 ms** | **1.343 ms** | **753.68 ms** | **756.11 ms** |    **4120 B** |
