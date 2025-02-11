```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.19 ms** | **0.083 ms** | **0.005 ms** |  **10.19 ms** |  **10.20 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.16 ms | 0.159 ms | 0.009 ms |  10.15 ms |  10.17 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.94 ms** | **1.702 ms** | **0.093 ms** | **751.84 ms** | **752.03 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.45 ms | 9.577 ms | 0.525 ms | 750.85 ms | 751.80 ms |    3832 B |
