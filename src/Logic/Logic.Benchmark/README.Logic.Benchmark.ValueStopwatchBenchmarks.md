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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.70 ns** |  **4.515 ns** | **0.247 ns** |  **62.54 ns** |  **62.99 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.46 ns |  0.941 ns | 0.052 ns |  57.41 ns |  57.51 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.38 ns |  0.199 ns | 0.011 ns |  58.37 ns |  58.39 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.46 ns |  0.679 ns | 0.037 ns |  57.42 ns |  57.49 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.29 ns** |  **6.452 ns** | **0.354 ns** | **120.90 ns** | **121.59 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.90 ns |  0.541 ns | 0.030 ns | 115.87 ns | 115.92 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 118.70 ns | 23.162 ns | 1.270 ns | 117.90 ns | 120.17 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.78 ns |  0.816 ns | 0.045 ns | 116.74 ns | 116.83 ns |      - |         - |
