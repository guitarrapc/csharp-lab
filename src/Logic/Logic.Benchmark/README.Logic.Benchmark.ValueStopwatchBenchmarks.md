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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.43 ns** | **2.685 ns** | **0.147 ns** |  **62.32 ns** |  **62.60 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.46 ns | 0.762 ns | 0.042 ns |  57.43 ns |  57.51 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.08 ns | 0.056 ns | 0.003 ns |  58.08 ns |  58.09 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.02 ns | 0.084 ns | 0.005 ns |  58.01 ns |  58.02 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.21 ns** | **4.657 ns** | **0.255 ns** | **122.04 ns** | **122.51 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.89 ns | 0.533 ns | 0.029 ns | 115.85 ns | 115.91 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.56 ns | 1.566 ns | 0.086 ns | 117.47 ns | 117.64 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.84 ns | 1.839 ns | 0.101 ns | 116.73 ns | 116.93 ns |      - |         - |
