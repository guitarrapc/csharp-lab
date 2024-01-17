```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.05 ms** |   **1.191 ms** | **0.065 ms** |  **11.99 ms** |  **12.12 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **757.12 ms** | **107.225 ms** | **5.877 ms** | **753.56 ms** | **763.90 ms** |    **4120 B** |
