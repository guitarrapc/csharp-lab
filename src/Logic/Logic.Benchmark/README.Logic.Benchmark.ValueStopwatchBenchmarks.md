```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **63.87 ns** |  **5.942 ns** | **0.326 ns** |  **63.54 ns** |  **64.19 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.78 ns |  3.571 ns | 0.196 ns |  57.55 ns |  57.91 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  59.14 ns |  1.965 ns | 0.108 ns |  59.03 ns |  59.24 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.45 ns |  2.721 ns | 0.149 ns |  58.34 ns |  58.62 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.82 ns** | **13.650 ns** | **0.748 ns** | **122.35 ns** | **123.68 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.89 ns |  1.451 ns | 0.080 ns | 116.81 ns | 116.97 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.97 ns |  6.808 ns | 0.373 ns | 117.56 ns | 118.29 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.85 ns |  0.662 ns | 0.036 ns | 116.81 ns | 116.88 ns |      - |         - |
