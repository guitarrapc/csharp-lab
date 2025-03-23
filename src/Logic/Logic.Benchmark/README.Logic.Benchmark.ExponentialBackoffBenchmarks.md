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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.23 ms** |  **0.409 ms** | **0.022 ms** |  **10.21 ms** |  **10.25 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.23 ms |  0.169 ms | 0.009 ms |  10.22 ms |  10.24 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.71 ms** |  **1.472 ms** | **0.081 ms** | **751.64 ms** | **751.80 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.12 ms | 11.599 ms | 0.636 ms | 751.70 ms | 752.86 ms |    4120 B |
