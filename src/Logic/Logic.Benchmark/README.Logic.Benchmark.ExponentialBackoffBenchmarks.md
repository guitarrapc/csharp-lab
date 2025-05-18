```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.20 ms** | **0.038 ms** | **0.002 ms** |  **10.20 ms** |  **10.20 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.20 ms | 0.019 ms | 0.001 ms |  10.20 ms |  10.20 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.79 ms** | **1.318 ms** | **0.072 ms** | **751.72 ms** | **751.86 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.73 ms | 2.161 ms | 0.118 ms | 751.65 ms | 751.87 ms |    4120 B |
