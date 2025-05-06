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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.12 ns** | **1.247 ns** | **0.068 ns** |  **62.05 ns** |  **62.18 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.45 ns | 0.551 ns | 0.030 ns |  57.42 ns |  57.48 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.83 ns | 0.836 ns | 0.046 ns |  57.78 ns |  57.87 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.43 ns | 0.802 ns | 0.044 ns |  57.40 ns |  57.48 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.10 ns** | **3.317 ns** | **0.182 ns** | **119.92 ns** | **120.28 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.28 ns | 0.338 ns | 0.018 ns | 115.26 ns | 115.30 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.81 ns | 0.527 ns | 0.029 ns | 115.79 ns | 115.84 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.88 ns | 8.791 ns | 0.482 ns | 114.56 ns | 115.44 ns |      - |         - |
