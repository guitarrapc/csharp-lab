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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.20 ms** | **0.226 ms** | **0.012 ms** |  **10.18 ms** |  **10.21 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms | 0.189 ms | 0.010 ms |  10.18 ms |  10.19 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.70 ms** | **2.114 ms** | **0.116 ms** | **751.61 ms** | **751.83 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.72 ms | 0.443 ms | 0.024 ms | 751.69 ms | 751.74 ms |    4120 B |
