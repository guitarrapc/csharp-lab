```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.19 ms** |  **0.543 ms** | **0.030 ms** |  **10.17 ms** |  **10.22 ms** |     **534 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.17 ms |  0.131 ms | 0.007 ms |  10.17 ms |  10.18 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.46 ms** | **11.048 ms** | **0.606 ms** | **750.77 ms** | **751.85 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 751.67 ms |  0.446 ms | 0.024 ms | 751.64 ms | 751.69 ms |    4120 B |
