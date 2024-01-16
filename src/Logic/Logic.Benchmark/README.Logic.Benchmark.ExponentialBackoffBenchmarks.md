```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.74 ms** |   **0.924 ms** |  **0.051 ms** |  **12.70 ms** |  **12.80 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **761.40 ms** | **206.060 ms** | **11.295 ms** | **753.85 ms** | **774.38 ms** |    **4120 B** |
