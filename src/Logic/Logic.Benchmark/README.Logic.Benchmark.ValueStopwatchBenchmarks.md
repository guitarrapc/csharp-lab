```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.51 ns** | **3.577 ns** | **0.196 ns** |  **62.29 ns** |  **62.67 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.33 ns | 0.067 ns | 0.004 ns |  58.33 ns |  58.34 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.27 ns | 6.277 ns | 0.344 ns |  58.05 ns |  58.66 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.40 ns | 0.209 ns | 0.011 ns |  57.38 ns |  57.41 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.24 ns** | **5.582 ns** | **0.306 ns** | **121.98 ns** | **122.58 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.85 ns | 0.446 ns | 0.024 ns | 115.82 ns | 115.87 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.56 ns | 2.086 ns | 0.114 ns | 117.45 ns | 117.68 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.86 ns | 0.601 ns | 0.033 ns | 115.82 ns | 115.88 ns |      - |         - |
