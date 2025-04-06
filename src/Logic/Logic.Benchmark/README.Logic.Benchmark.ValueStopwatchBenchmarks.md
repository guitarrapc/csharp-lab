```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.68 ns** | **3.816 ns** | **0.209 ns** |  **61.53 ns** |  **61.92 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.41 ns | 0.631 ns | 0.035 ns |  57.38 ns |  57.44 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.06 ns | 0.958 ns | 0.053 ns |  58.02 ns |  58.12 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.38 ns | 0.526 ns | 0.029 ns |  57.36 ns |  57.41 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.22 ns** | **1.516 ns** | **0.083 ns** | **121.12 ns** | **121.27 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.44 ns | 0.883 ns | 0.048 ns | 116.39 ns | 116.49 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.41 ns | 0.720 ns | 0.039 ns | 117.38 ns | 117.45 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.77 ns | 0.264 ns | 0.014 ns | 115.76 ns | 115.78 ns |      - |         - |
