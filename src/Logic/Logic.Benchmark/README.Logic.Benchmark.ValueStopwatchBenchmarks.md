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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.12 ns** | **3.054 ns** | **0.167 ns** |  **62.00 ns** |  **62.31 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.43 ns | 0.125 ns | 0.007 ns |  57.42 ns |  57.44 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.11 ns | 1.246 ns | 0.068 ns |  58.07 ns |  58.19 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.38 ns | 0.126 ns | 0.007 ns |  57.38 ns |  57.39 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.36 ns** | **2.143 ns** | **0.117 ns** | **122.23 ns** | **122.46 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.81 ns | 0.343 ns | 0.019 ns | 115.79 ns | 115.82 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.60 ns | 0.991 ns | 0.054 ns | 117.56 ns | 117.66 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.87 ns | 0.621 ns | 0.034 ns | 115.83 ns | 115.90 ns |      - |         - |
