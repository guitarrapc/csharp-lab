```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.06 ns** | **6.773 ns** | **0.371 ns** |  **61.66 ns** |  **62.39 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.47 ns | 0.848 ns | 0.046 ns |  57.42 ns |  57.51 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.11 ns | 1.107 ns | 0.061 ns |  58.06 ns |  58.18 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.21 ns | 0.100 ns | 0.005 ns |  58.20 ns |  58.21 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.41 ns** | **5.992 ns** | **0.328 ns** | **121.20 ns** | **121.79 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.84 ns | 0.257 ns | 0.014 ns | 115.83 ns | 115.85 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.49 ns | 0.237 ns | 0.013 ns | 117.47 ns | 117.50 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.19 ns | 0.250 ns | 0.014 ns | 116.18 ns | 116.21 ns |      - |         - |
