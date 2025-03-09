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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.35 ns** | **5.997 ns** | **0.329 ns** |  **62.03 ns** |  **62.69 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.42 ns | 0.225 ns | 0.012 ns |  57.41 ns |  57.44 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.99 ns | 0.191 ns | 0.010 ns |  58.98 ns |  59.00 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.41 ns | 0.716 ns | 0.039 ns |  57.39 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.96 ns** | **6.062 ns** | **0.332 ns** | **120.59 ns** | **121.22 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.81 ns | 0.364 ns | 0.020 ns | 115.79 ns | 115.83 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.57 ns | 1.801 ns | 0.099 ns | 117.51 ns | 117.69 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.68 ns | 0.765 ns | 0.042 ns | 116.65 ns | 116.72 ns |      - |         - |
