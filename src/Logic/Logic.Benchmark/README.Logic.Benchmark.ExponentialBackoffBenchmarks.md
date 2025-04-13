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
| **ExponentialBackoff** | **.NET 8.0** | **1**      |  **10.24 ms** | **0.863 ms** | **0.047 ms** |  **10.20 ms** |  **10.29 ms** |     **520 B** |
| ExponentialBackoff | .NET 9.0 | 1      |  10.28 ms | 1.090 ms | 0.060 ms |  10.23 ms |  10.35 ms |     520 B |
| **ExponentialBackoff** | **.NET 8.0** | **10**     | **751.77 ms** | **3.542 ms** | **0.194 ms** | **751.55 ms** | **751.91 ms** |    **4120 B** |
| ExponentialBackoff | .NET 9.0 | 10     | 752.01 ms | 1.618 ms | 0.089 ms | 751.91 ms | 752.07 ms |    4120 B |
