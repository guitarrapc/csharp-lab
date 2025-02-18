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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.73 ns** | **5.613 ns** | **0.308 ns** |  **61.40 ns** |  **62.01 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.76 ns | 0.212 ns | 0.012 ns |  57.75 ns |  57.77 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.70 ns | 0.697 ns | 0.038 ns |  58.68 ns |  58.75 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.20 ns | 0.514 ns | 0.028 ns |  58.18 ns |  58.23 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.19 ns** | **1.578 ns** | **0.086 ns** | **121.09 ns** | **121.24 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.23 ns | 1.766 ns | 0.097 ns | 116.16 ns | 116.34 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.64 ns | 3.429 ns | 0.188 ns | 117.45 ns | 117.83 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.80 ns | 0.640 ns | 0.035 ns | 115.78 ns | 115.84 ns |      - |         - |
