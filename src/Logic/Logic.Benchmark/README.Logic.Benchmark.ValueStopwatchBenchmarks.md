```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.02 ns** |  **7.507 ns** | **0.411 ns** |  **61.56 ns** |  **62.36 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.37 ns |  9.213 ns | 0.505 ns |  57.01 ns |  57.94 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.21 ns | 11.596 ns | 0.636 ns |  57.73 ns |  58.93 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.27 ns |  2.479 ns | 0.136 ns |  57.18 ns |  57.43 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **118.28 ns** | **33.464 ns** | **1.834 ns** | **116.40 ns** | **120.06 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 113.83 ns | 25.621 ns | 1.404 ns | 112.22 ns | 114.82 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 116.93 ns | 14.414 ns | 0.790 ns | 116.11 ns | 117.68 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 113.68 ns | 13.331 ns | 0.731 ns | 113.22 ns | 114.52 ns |      - |         - |
