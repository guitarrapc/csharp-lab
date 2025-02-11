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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** | **0.424 ms** | **0.023 ms** |  **10.21 ms** |  **10.25 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.25 ms | 0.388 ms | 0.021 ms |  10.22 ms |  10.26 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.08 ms** | **1.386 ms** | **0.076 ms** | **752.00 ms** | **752.15 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.94 ms | 2.573 ms | 0.141 ms | 751.85 ms | 752.10 ms |    4120 B |
