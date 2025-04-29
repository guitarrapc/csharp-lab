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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.19 ms** | **0.129 ms** | **0.007 ms** |  **10.19 ms** |  **10.20 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.16 ms | 0.362 ms | 0.020 ms |  10.14 ms |  10.17 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.82 ms** | **0.440 ms** | **0.024 ms** | **751.79 ms** | **751.84 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.85 ms | 2.701 ms | 0.148 ms | 751.69 ms | 751.98 ms |    4120 B |
