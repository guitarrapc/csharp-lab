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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.14 ns** | **4.083 ns** | **0.224 ns** |  **60.93 ns** |  **61.38 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.44 ns | 0.100 ns | 0.005 ns |  57.44 ns |  57.45 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.80 ns | 0.278 ns | 0.015 ns |  57.79 ns |  57.82 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.41 ns | 0.164 ns | 0.009 ns |  57.40 ns |  57.42 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.48 ns** | **5.470 ns** | **0.300 ns** | **119.28 ns** | **119.83 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.72 ns | 1.243 ns | 0.068 ns | 114.65 ns | 114.78 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 115.15 ns | 1.911 ns | 0.105 ns | 115.03 ns | 115.23 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.59 ns | 0.162 ns | 0.009 ns | 114.58 ns | 114.60 ns |      - |         - |
