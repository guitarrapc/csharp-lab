```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.84 ns** | **4.002 ns** | **0.219 ns** |  **61.70 ns** |  **62.09 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.44 ns | 2.552 ns | 0.140 ns |  58.35 ns |  58.60 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.09 ns | 1.153 ns | 0.063 ns |  58.05 ns |  58.17 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.32 ns | 0.183 ns | 0.010 ns |  58.30 ns |  58.32 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.76 ns** | **4.942 ns** | **0.271 ns** | **120.55 ns** | **121.06 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.87 ns | 0.553 ns | 0.030 ns | 115.83 ns | 115.89 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.68 ns | 3.727 ns | 0.204 ns | 117.44 ns | 117.81 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.17 ns | 1.016 ns | 0.056 ns | 116.14 ns | 116.24 ns |      - |         - |
