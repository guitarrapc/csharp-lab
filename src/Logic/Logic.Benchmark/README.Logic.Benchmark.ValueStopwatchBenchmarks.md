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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.03 ns** | **1.585 ns** | **0.087 ns** |  **60.93 ns** |  **61.09 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.45 ns | 0.168 ns | 0.009 ns |  57.44 ns |  57.46 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.89 ns | 2.997 ns | 0.164 ns |  57.78 ns |  58.08 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.45 ns | 0.287 ns | 0.016 ns |  57.43 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.83 ns** | **3.269 ns** | **0.179 ns** | **119.68 ns** | **120.03 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.28 ns | 0.408 ns | 0.022 ns | 114.26 ns | 114.30 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.05 ns | 1.535 ns | 0.084 ns | 114.99 ns | 115.15 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.66 ns | 1.587 ns | 0.087 ns | 114.58 ns | 114.75 ns |      - |         - |
