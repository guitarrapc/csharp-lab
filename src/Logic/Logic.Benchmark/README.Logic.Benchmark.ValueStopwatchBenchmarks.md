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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.82 ns** |  **7.399 ns** | **0.406 ns** |  **61.42 ns** |  **62.23 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.27 ns | 25.925 ns | 1.421 ns |  57.44 ns |  59.91 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.09 ns |  0.858 ns | 0.047 ns |  58.06 ns |  58.14 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.35 ns |  0.107 ns | 0.006 ns |  57.35 ns |  57.36 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.93 ns** |  **4.638 ns** | **0.254 ns** | **120.68 ns** | **121.19 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.30 ns |  0.647 ns | 0.035 ns | 116.28 ns | 116.34 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.53 ns |  1.489 ns | 0.082 ns | 117.43 ns | 117.59 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.02 ns |  0.634 ns | 0.035 ns | 115.99 ns | 116.05 ns |      - |         - |
