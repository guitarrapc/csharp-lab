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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.85 ns** | **1.848 ns** | **0.101 ns** |  **61.79 ns** |  **61.97 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.48 ns | 0.680 ns | 0.037 ns |  57.44 ns |  57.51 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.83 ns | 0.714 ns | 0.039 ns |  57.79 ns |  57.87 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.43 ns | 0.462 ns | 0.025 ns |  57.42 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.19 ns** | **6.978 ns** | **0.382 ns** | **119.81 ns** | **120.57 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.31 ns | 0.378 ns | 0.021 ns | 114.30 ns | 114.34 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.04 ns | 0.276 ns | 0.015 ns | 115.02 ns | 115.05 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.00 ns | 2.605 ns | 0.143 ns | 114.91 ns | 115.16 ns |      - |         - |
