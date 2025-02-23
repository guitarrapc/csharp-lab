```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.17 ms** | **0.067 ms** | **0.004 ms** |  **10.17 ms** |  **10.17 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.16 ms | 0.190 ms | 0.010 ms |  10.15 ms |  10.17 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.90 ms** | **0.496 ms** | **0.027 ms** | **751.88 ms** | **751.93 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.78 ms | 1.174 ms | 0.064 ms | 751.70 ms | 751.82 ms |    4120 B |
