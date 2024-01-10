```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **12.30 ms** |  **3.267 ms** | **0.179 ms** |  **12.18 ms** |  **12.51 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **759.49 ms** | **76.284 ms** | **4.181 ms** | **756.17 ms** | **764.19 ms** |    **4120 B** |
