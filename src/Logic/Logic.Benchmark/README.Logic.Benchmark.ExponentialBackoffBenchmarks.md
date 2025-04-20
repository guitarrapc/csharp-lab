```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** | **0.513 ms** | **0.028 ms** |  **10.20 ms** |  **10.25 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.20 ms | 0.027 ms | 0.001 ms |  10.19 ms |  10.20 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.71 ms** | **1.595 ms** | **0.087 ms** | **751.62 ms** | **751.79 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.75 ms | 1.243 ms | 0.068 ms | 751.70 ms | 751.82 ms |    3832 B |
