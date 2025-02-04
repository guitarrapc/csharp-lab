```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **10.23 ms** |  **0.525 ms** | **0.029 ms** |  **10.20 ms** |  **10.26 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **751.67 ms** | **10.771 ms** | **0.590 ms** | **751.00 ms** | **752.11 ms** |    **3832 B** |
