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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.63 ns** | **5.583 ns** | **0.306 ns** |  **61.35 ns** |  **61.96 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.91 ns | 0.214 ns | 0.012 ns |  57.89 ns |  57.91 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.52 ns | 0.745 ns | 0.041 ns |  58.47 ns |  58.54 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.04 ns | 0.272 ns | 0.015 ns |  58.03 ns |  58.06 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.64 ns** | **6.004 ns** | **0.329 ns** | **120.31 ns** | **120.96 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.27 ns | 0.048 ns | 0.003 ns | 116.26 ns | 116.27 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.76 ns | 3.751 ns | 0.206 ns | 117.55 ns | 117.97 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.85 ns | 0.698 ns | 0.038 ns | 115.80 ns | 115.87 ns |      - |         - |
