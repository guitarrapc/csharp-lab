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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.95 ns** | **3.482 ns** | **0.191 ns** |  **62.74 ns** |  **63.12 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.44 ns | 0.398 ns | 0.022 ns |  57.41 ns |  57.46 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.12 ns | 0.829 ns | 0.045 ns |  58.07 ns |  58.17 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.43 ns | 0.729 ns | 0.040 ns |  57.40 ns |  57.47 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.72 ns** | **1.889 ns** | **0.104 ns** | **121.61 ns** | **121.80 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.79 ns | 0.616 ns | 0.034 ns | 116.77 ns | 116.83 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.63 ns | 2.548 ns | 0.140 ns | 117.52 ns | 117.79 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.84 ns | 0.656 ns | 0.036 ns | 115.81 ns | 115.88 ns |      - |         - |
