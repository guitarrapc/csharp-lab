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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.20 ms** | **0.319 ms** | **0.017 ms** |  **10.18 ms** |  **10.22 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms | 0.047 ms | 0.003 ms |  10.19 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.88 ms** | **1.386 ms** | **0.076 ms** | **751.79 ms** | **751.92 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.64 ms | 2.579 ms | 0.141 ms | 751.55 ms | 751.80 ms |    4120 B |
