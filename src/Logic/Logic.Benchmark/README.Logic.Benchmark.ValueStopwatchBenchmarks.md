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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.85 ns** | **3.772 ns** | **0.207 ns** |  **62.66 ns** |  **63.07 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.43 ns | 0.472 ns | 0.026 ns |  57.41 ns |  57.46 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.72 ns | 0.972 ns | 0.053 ns |  58.69 ns |  58.79 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.41 ns | 0.050 ns | 0.003 ns |  57.41 ns |  57.41 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.30 ns** | **4.730 ns** | **0.259 ns** | **122.08 ns** | **122.58 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.85 ns | 0.133 ns | 0.007 ns | 115.84 ns | 115.86 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.64 ns | 1.203 ns | 0.066 ns | 117.58 ns | 117.71 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.03 ns | 2.695 ns | 0.148 ns | 115.86 ns | 116.13 ns |      - |         - |
