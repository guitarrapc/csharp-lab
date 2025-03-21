```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.21 ms** |  **0.283 ms** | **0.016 ms** |  **10.20 ms** |  **10.23 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms |  0.201 ms | 0.011 ms |  10.19 ms |  10.21 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.67 ms** | **23.594 ms** | **1.293 ms** | **751.78 ms** | **754.15 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.02 ms |  0.235 ms | 0.013 ms | 752.00 ms | 752.02 ms |    4120 B |
