```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.39 ns** |  **3.559 ns** | **0.195 ns** |  **62.17 ns** |  **62.56 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.46 ns |  0.335 ns | 0.018 ns |  57.44 ns |  57.48 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.06 ns |  0.100 ns | 0.005 ns |  58.05 ns |  58.06 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.40 ns |  0.286 ns | 0.016 ns |  57.38 ns |  57.41 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.78 ns** | **10.358 ns** | **0.568 ns** | **121.37 ns** | **122.42 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.81 ns |  0.881 ns | 0.048 ns | 116.76 ns | 116.86 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.55 ns |  0.983 ns | 0.054 ns | 117.50 ns | 117.61 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.74 ns |  0.455 ns | 0.025 ns | 116.72 ns | 116.77 ns |      - |         - |
