```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **10.21 ms** | **0.459 ms** | **0.025 ms** |  **10.19 ms** |  **10.24 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **751.69 ms** | **0.705 ms** | **0.039 ms** | **751.64 ms** | **751.71 ms** |    **3832 B** |
