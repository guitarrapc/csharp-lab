```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.31 ms** |   **2.164 ms** | **0.119 ms** |  **12.17 ms** |  **12.39 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **759.55 ms** | **175.067 ms** | **9.596 ms** | **752.16 ms** | **770.40 ms** |    **4120 B** |
