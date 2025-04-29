```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.93 ns** | **0.383 ns** | **0.021 ns** |  **61.91 ns** |  **61.95 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.45 ns | 0.915 ns | 0.050 ns |  57.40 ns |  57.50 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.41 ns | 1.527 ns | 0.084 ns |  57.32 ns |  57.47 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.39 ns | 0.445 ns | 0.024 ns |  57.37 ns |  57.42 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.54 ns** | **3.665 ns** | **0.201 ns** | **119.35 ns** | **119.75 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.32 ns | 0.464 ns | 0.025 ns | 114.29 ns | 114.35 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.17 ns | 0.994 ns | 0.054 ns | 115.11 ns | 115.22 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.64 ns | 1.252 ns | 0.069 ns | 114.56 ns | 114.70 ns |      - |         - |
