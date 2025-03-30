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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.16 ms** |  **0.247 ms** | **0.014 ms** |  **10.15 ms** |  **10.17 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.24 ms |  0.280 ms | 0.015 ms |  10.22 ms |  10.25 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.81 ms** |  **1.608 ms** | **0.088 ms** | **751.75 ms** | **751.91 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.13 ms | 11.100 ms | 0.608 ms | 751.69 ms | 752.83 ms |    4120 B |
