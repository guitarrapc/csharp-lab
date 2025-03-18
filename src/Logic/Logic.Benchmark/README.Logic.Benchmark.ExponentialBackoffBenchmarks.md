```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.20 ms** | **0.349 ms** | **0.019 ms** |  **10.19 ms** |  **10.22 ms** |     **534 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms | 0.056 ms | 0.003 ms |  10.18 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.97 ms** | **0.832 ms** | **0.046 ms** | **751.92 ms** | **752.02 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.07 ms | 2.339 ms | 0.128 ms | 751.94 ms | 752.20 ms |    3832 B |
