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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.19 ms** |  **0.058 ms** | **0.003 ms** |  **10.19 ms** |  **10.19 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.18 ms |  0.136 ms | 0.007 ms |  10.17 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.66 ms** | **11.041 ms** | **0.605 ms** | **750.98 ms** | **752.14 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.93 ms |  2.705 ms | 0.148 ms | 751.76 ms | 752.04 ms |    4120 B |
