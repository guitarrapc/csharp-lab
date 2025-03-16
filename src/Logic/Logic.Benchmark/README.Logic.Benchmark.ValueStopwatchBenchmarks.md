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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.63 ns** | **2.057 ns** | **0.113 ns** |  **61.53 ns** |  **61.76 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.43 ns | 0.906 ns | 0.050 ns |  58.38 ns |  58.47 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  59.03 ns | 1.058 ns | 0.058 ns |  58.99 ns |  59.09 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.94 ns | 1.179 ns | 0.065 ns |  57.87 ns |  57.99 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.63 ns** | **8.686 ns** | **0.476 ns** | **121.27 ns** | **122.17 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.86 ns | 0.972 ns | 0.053 ns | 115.80 ns | 115.90 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.86 ns | 8.167 ns | 0.448 ns | 117.57 ns | 118.38 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.50 ns | 1.075 ns | 0.059 ns | 116.46 ns | 116.57 ns |      - |         - |
