```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.22 ms** | **0.280 ms** | **0.015 ms** |  **10.20 ms** |  **10.23 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.22 ms | 0.290 ms | 0.016 ms |  10.21 ms |  10.24 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.19 ms** | **2.505 ms** | **0.137 ms** | **752.05 ms** | **752.32 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.14 ms | 3.325 ms | 0.182 ms | 751.93 ms | 752.27 ms |    4120 B |
