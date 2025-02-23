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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.25 ms** |  **0.258 ms** | **0.014 ms** |  **10.24 ms** |  **10.27 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.23 ms |  0.333 ms | 0.018 ms |  10.21 ms |  10.24 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.34 ms** |  **2.560 ms** | **0.140 ms** | **752.20 ms** | **752.48 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.66 ms | 11.809 ms | 0.647 ms | 752.25 ms | 753.40 ms |    3832 B |
