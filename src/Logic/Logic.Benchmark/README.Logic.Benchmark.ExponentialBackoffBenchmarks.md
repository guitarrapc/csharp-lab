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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.15 ms** |  **0.318 ms** | **0.017 ms** |  **10.14 ms** |  **10.17 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.18 ms |  0.249 ms | 0.014 ms |  10.16 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.33 ms** |  **9.173 ms** | **0.503 ms** | **751.75 ms** | **752.67 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.14 ms | 11.876 ms | 0.651 ms | 751.61 ms | 752.87 ms |    3832 B |
