```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.18 ms** | **0.223 ms** | **0.012 ms** |  **10.17 ms** |  **10.19 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.18 ms | 0.217 ms | 0.012 ms |  10.17 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.74 ms** | **2.325 ms** | **0.127 ms** | **751.60 ms** | **751.85 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.05 ms | 9.572 ms | 0.525 ms | 751.69 ms | 752.66 ms |    4120 B |
