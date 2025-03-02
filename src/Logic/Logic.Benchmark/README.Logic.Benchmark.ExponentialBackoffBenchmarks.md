```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.22 ms** |  **0.267 ms** | **0.015 ms** |  **10.20 ms** |  **10.23 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms |  0.096 ms | 0.005 ms |  10.18 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.15 ms** | **11.318 ms** | **0.620 ms** | **751.78 ms** | **752.87 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.27 ms | 11.323 ms | 0.621 ms | 750.56 ms | 751.64 ms |    4120 B |
