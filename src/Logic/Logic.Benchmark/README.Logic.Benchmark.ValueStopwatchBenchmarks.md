```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.25 ns** | **3.454 ns** | **0.189 ns** |  **62.13 ns** |  **62.47 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.32 ns | 0.142 ns | 0.008 ns |  58.32 ns |  58.33 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.53 ns | 0.525 ns | 0.029 ns |  58.51 ns |  58.56 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.35 ns | 0.527 ns | 0.029 ns |  58.32 ns |  58.37 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.99 ns** | **6.645 ns** | **0.364 ns** | **121.70 ns** | **122.40 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.88 ns | 0.983 ns | 0.054 ns | 115.82 ns | 115.93 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.64 ns | 3.607 ns | 0.198 ns | 117.47 ns | 117.86 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.83 ns | 0.226 ns | 0.012 ns | 115.82 ns | 115.85 ns |      - |         - |
