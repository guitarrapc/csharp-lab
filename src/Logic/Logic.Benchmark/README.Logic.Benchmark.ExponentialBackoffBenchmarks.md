```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** | **0.051 ms** | **0.003 ms** |  **10.23 ms** |  **10.24 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms | 0.172 ms | 0.009 ms |  10.18 ms |  10.20 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.34 ms** | **7.348 ms** | **0.403 ms** | **750.89 ms** | **751.67 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.70 ms | 1.479 ms | 0.081 ms | 751.62 ms | 751.78 ms |    4120 B |
