```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.21 ms** | **0.140 ms** | **0.008 ms** |  **10.20 ms** |  **10.22 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.20 ms | 0.210 ms | 0.012 ms |  10.19 ms |  10.21 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.79 ms** | **1.689 ms** | **0.093 ms** | **751.71 ms** | **751.89 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.02 ms | 9.819 ms | 0.538 ms | 751.62 ms | 752.64 ms |    4120 B |
