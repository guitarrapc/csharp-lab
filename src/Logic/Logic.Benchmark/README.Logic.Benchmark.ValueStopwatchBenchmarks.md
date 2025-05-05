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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.65 ns** | **2.253 ns** | **0.124 ns** |  **62.51 ns** |  **62.75 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  56.56 ns | 0.888 ns | 0.049 ns |  56.50 ns |  56.59 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.53 ns | 1.247 ns | 0.068 ns |  57.48 ns |  57.61 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.47 ns | 1.106 ns | 0.061 ns |  57.42 ns |  57.53 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.96 ns** | **5.527 ns** | **0.303 ns** | **119.75 ns** | **120.31 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.96 ns | 4.307 ns | 0.236 ns | 114.78 ns | 115.23 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.06 ns | 1.104 ns | 0.060 ns | 115.00 ns | 115.12 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.61 ns | 0.133 ns | 0.007 ns | 114.60 ns | 114.61 ns |      - |         - |
