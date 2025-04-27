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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.22 ms** |  **0.378 ms** | **0.021 ms** |  **10.19 ms** |  **10.23 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.20 ms |  0.344 ms | 0.019 ms |  10.19 ms |  10.22 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.08 ms** | **11.184 ms** | **0.613 ms** | **751.69 ms** | **752.78 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.59 ms |  1.294 ms | 0.071 ms | 751.53 ms | 751.67 ms |    3832 B |
