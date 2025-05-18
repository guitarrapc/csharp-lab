```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **60.33 ns** | **2.989 ns** | **0.164 ns** |  **60.16 ns** |  **60.48 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.42 ns | 0.230 ns | 0.013 ns |  57.41 ns |  57.43 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.80 ns | 0.069 ns | 0.004 ns |  57.79 ns |  57.80 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.09 ns | 0.062 ns | 0.003 ns |  57.09 ns |  57.10 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.72 ns** | **4.594 ns** | **0.252 ns** | **119.56 ns** | **120.01 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.29 ns | 0.348 ns | 0.019 ns | 114.27 ns | 114.31 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 114.74 ns | 0.241 ns | 0.013 ns | 114.73 ns | 114.76 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.92 ns | 0.278 ns | 0.015 ns | 114.91 ns | 114.94 ns |      - |         - |
