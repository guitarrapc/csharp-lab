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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.19 ms** |  **0.165 ms** | **0.009 ms** |  **10.18 ms** |  **10.19 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.18 ms |  0.081 ms | 0.004 ms |  10.18 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.17 ms** | **11.137 ms** | **0.610 ms** | **751.80 ms** | **752.88 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.78 ms |  2.260 ms | 0.124 ms | 751.67 ms | 751.91 ms |    4120 B |
