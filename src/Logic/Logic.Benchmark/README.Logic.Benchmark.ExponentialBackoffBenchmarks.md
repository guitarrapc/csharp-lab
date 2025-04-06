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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** |  **0.362 ms** | **0.020 ms** |  **10.21 ms** |  **10.24 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.22 ms |  0.503 ms | 0.028 ms |  10.20 ms |  10.25 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.43 ms** | **10.187 ms** | **0.558 ms** | **751.79 ms** | **752.79 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.00 ms |  8.508 ms | 0.466 ms | 751.66 ms | 752.53 ms |    4120 B |
