```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **1**      |  **10.21 ms** | **0.303 ms** | **0.017 ms** |  **10.20 ms** |  **10.23 ms** |     **520 B** |
| **ExponentialBackoff** | **10**     | **752.12 ms** | **9.692 ms** | **0.531 ms** | **751.65 ms** | **752.70 ms** |    **3832 B** |
