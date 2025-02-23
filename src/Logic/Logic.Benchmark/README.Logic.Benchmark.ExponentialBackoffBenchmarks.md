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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.21 ms** |  **0.422 ms** | **0.023 ms** |  **10.19 ms** |  **10.24 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.19 ms |  0.168 ms | 0.009 ms |  10.18 ms |  10.20 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.33 ms** | **22.318 ms** | **1.223 ms** | **751.60 ms** | **753.74 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.34 ms | 22.372 ms | 1.226 ms | 751.57 ms | 753.76 ms |    4120 B |
