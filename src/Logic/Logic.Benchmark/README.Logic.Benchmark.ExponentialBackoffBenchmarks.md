```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** |  **0.495 ms** | **0.027 ms** |  **10.20 ms** |  **10.26 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.24 ms |  0.061 ms | 0.003 ms |  10.23 ms |  10.24 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.53 ms** | **12.473 ms** | **0.684 ms** | **752.00 ms** | **753.30 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.33 ms | 12.598 ms | 0.691 ms | 751.92 ms | 753.13 ms |    4120 B |
