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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **60.83 ns** | **3.298 ns** | **0.181 ns** |  **60.62 ns** |  **60.94 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.44 ns | 0.393 ns | 0.022 ns |  57.42 ns |  57.46 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.79 ns | 0.095 ns | 0.005 ns |  57.79 ns |  57.80 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.42 ns | 0.090 ns | 0.005 ns |  57.41 ns |  57.42 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **118.59 ns** | **3.225 ns** | **0.177 ns** | **118.49 ns** | **118.80 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.33 ns | 0.310 ns | 0.017 ns | 114.31 ns | 114.35 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.05 ns | 0.986 ns | 0.054 ns | 115.01 ns | 115.11 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.61 ns | 0.230 ns | 0.013 ns | 114.59 ns | 114.62 ns |      - |         - |
