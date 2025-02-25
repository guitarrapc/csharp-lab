```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.59 ns** | **4.744 ns** | **0.260 ns** |  **61.33 ns** |  **61.85 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.42 ns | 0.676 ns | 0.037 ns |  57.39 ns |  57.46 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.55 ns | 1.300 ns | 0.071 ns |  58.50 ns |  58.63 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.69 ns | 0.154 ns | 0.008 ns |  57.68 ns |  57.70 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.96 ns** | **3.838 ns** | **0.210 ns** | **120.77 ns** | **121.19 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.88 ns | 2.302 ns | 0.126 ns | 116.74 ns | 116.98 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.55 ns | 2.131 ns | 0.117 ns | 117.45 ns | 117.68 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.73 ns | 0.832 ns | 0.046 ns | 116.70 ns | 116.78 ns |      - |         - |
