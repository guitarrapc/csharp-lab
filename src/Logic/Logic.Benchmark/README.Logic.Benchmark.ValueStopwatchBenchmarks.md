```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.03 ns** | **5.706 ns** | **0.313 ns** |  **61.83 ns** |  **62.39 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.48 ns | 1.867 ns | 0.102 ns |  57.40 ns |  57.60 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.82 ns | 1.755 ns | 0.096 ns |  57.76 ns |  57.93 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.43 ns | 7.547 ns | 0.414 ns |  57.08 ns |  57.89 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.02 ns** | **4.237 ns** | **0.232 ns** | **119.77 ns** | **120.23 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.92 ns | 0.672 ns | 0.037 ns | 114.89 ns | 114.96 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.09 ns | 1.638 ns | 0.090 ns | 115.00 ns | 115.18 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.39 ns | 0.121 ns | 0.007 ns | 114.39 ns | 114.40 ns |      - |         - |
