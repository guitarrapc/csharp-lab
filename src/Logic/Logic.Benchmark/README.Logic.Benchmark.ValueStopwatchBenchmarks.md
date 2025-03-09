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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **63.18 ns** | **5.724 ns** | **0.314 ns** |  **62.97 ns** |  **63.54 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.36 ns | 0.565 ns | 0.031 ns |  58.33 ns |  58.40 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  59.00 ns | 0.052 ns | 0.003 ns |  58.99 ns |  59.00 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.40 ns | 0.078 ns | 0.004 ns |  57.40 ns |  57.40 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.01 ns** | **3.769 ns** | **0.207 ns** | **121.81 ns** | **122.22 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.86 ns | 0.215 ns | 0.012 ns | 115.85 ns | 115.87 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.57 ns | 1.321 ns | 0.072 ns | 117.49 ns | 117.63 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.92 ns | 1.980 ns | 0.109 ns | 115.85 ns | 116.04 ns |      - |         - |
