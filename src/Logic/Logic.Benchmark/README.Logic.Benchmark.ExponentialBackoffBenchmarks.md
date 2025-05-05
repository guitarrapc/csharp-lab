```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.22 ms** |  **0.080 ms** | **0.004 ms** |  **10.22 ms** |  **10.23 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.23 ms |  0.576 ms | 0.032 ms |  10.20 ms |  10.26 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.46 ms** | **12.680 ms** | **0.695 ms** | **752.04 ms** | **753.26 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.83 ms | 11.604 ms | 0.636 ms | 751.10 ms | 752.25 ms |    4120 B |
