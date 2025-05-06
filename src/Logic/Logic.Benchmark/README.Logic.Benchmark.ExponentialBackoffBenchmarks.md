```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.22 ms** | **0.079 ms** | **0.004 ms** |  **10.21 ms** |  **10.22 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.21 ms | 0.110 ms | 0.006 ms |  10.21 ms |  10.22 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.34 ms** | **0.930 ms** | **0.051 ms** | **752.30 ms** | **752.39 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.13 ms | 3.011 ms | 0.165 ms | 751.97 ms | 752.30 ms |    4120 B |
