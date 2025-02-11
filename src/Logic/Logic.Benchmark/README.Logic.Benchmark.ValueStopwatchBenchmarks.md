```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.72 ns** |  **3.040 ns** | **0.167 ns** |  **61.55 ns** |  **61.88 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.22 ns |  0.503 ns | 0.028 ns |  58.20 ns |  58.25 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.11 ns |  1.341 ns | 0.074 ns |  58.03 ns |  58.17 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.39 ns |  0.190 ns | 0.010 ns |  57.38 ns |  57.40 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.75 ns** |  **7.274 ns** | **0.399 ns** | **122.30 ns** | **123.07 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 117.39 ns | 32.751 ns | 1.795 ns | 116.33 ns | 119.47 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.57 ns |  2.324 ns | 0.127 ns | 117.48 ns | 117.71 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.81 ns |  0.265 ns | 0.015 ns | 115.79 ns | 115.82 ns |      - |         - |
