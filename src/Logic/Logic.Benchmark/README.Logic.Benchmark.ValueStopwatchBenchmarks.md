```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.06 ns** |  **5.552 ns** | **0.304 ns** |  **61.73 ns** |  **62.34 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.24 ns | 10.646 ns | 0.584 ns |  57.89 ns |  58.91 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.11 ns |  1.645 ns | 0.090 ns |  58.05 ns |  58.21 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.39 ns |  0.285 ns | 0.016 ns |  57.38 ns |  57.41 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.73 ns** |  **3.279 ns** | **0.180 ns** | **121.54 ns** | **121.90 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.81 ns |  0.180 ns | 0.010 ns | 116.80 ns | 116.82 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.60 ns |  1.221 ns | 0.067 ns | 117.54 ns | 117.67 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.73 ns |  0.342 ns | 0.019 ns | 116.71 ns | 116.74 ns |      - |         - |
