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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.26 ms** | **0.697 ms** | **0.038 ms** |  **10.23 ms** |  **10.30 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.24 ms | 0.323 ms | 0.018 ms |  10.22 ms |  10.26 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **752.25 ms** | **3.457 ms** | **0.189 ms** | **752.06 ms** | **752.43 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.26 ms | 1.890 ms | 0.104 ms | 752.16 ms | 752.37 ms |    4120 B |
