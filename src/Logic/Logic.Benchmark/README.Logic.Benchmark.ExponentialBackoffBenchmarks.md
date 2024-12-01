```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **11.97 ms** | **0.623 ms** | **0.034 ms** |  **11.95 ms** |  **12.01 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **754.28 ms** | **2.009 ms** | **0.110 ms** | **754.15 ms** | **754.36 ms** |    **4120 B** |
