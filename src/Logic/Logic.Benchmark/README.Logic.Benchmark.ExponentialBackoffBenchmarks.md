```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.51 ms** |  **1.872 ms** | **0.103 ms** |  **12.40 ms** |  **12.60 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **755.40 ms** | **43.137 ms** | **2.364 ms** | **753.82 ms** | **758.12 ms** |    **4120 B** |
