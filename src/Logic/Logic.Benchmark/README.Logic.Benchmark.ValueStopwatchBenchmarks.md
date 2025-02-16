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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.49 ns** | **8.265 ns** | **0.453 ns** |  **62.19 ns** |  **63.01 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.43 ns | 0.173 ns | 0.009 ns |  57.42 ns |  57.44 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.41 ns | 0.334 ns | 0.018 ns |  58.39 ns |  58.43 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.45 ns | 1.964 ns | 0.108 ns |  58.34 ns |  58.56 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.05 ns** | **2.441 ns** | **0.134 ns** | **121.93 ns** | **122.20 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.85 ns | 0.374 ns | 0.020 ns | 115.83 ns | 115.87 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.64 ns | 4.118 ns | 0.226 ns | 117.44 ns | 117.89 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.88 ns | 1.720 ns | 0.094 ns | 115.78 ns | 115.96 ns |      - |         - |
