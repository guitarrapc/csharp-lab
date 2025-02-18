```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.24 ms** |  **0.408 ms** | **0.022 ms** |  **10.22 ms** |  **10.27 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.22 ms |  0.342 ms | 0.019 ms |  10.21 ms |  10.24 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.77 ms** |  **1.956 ms** | **0.107 ms** | **751.65 ms** | **751.87 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.08 ms | 12.218 ms | 0.670 ms | 751.65 ms | 752.86 ms |    4120 B |
