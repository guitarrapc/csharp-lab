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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.08 ns** | **6.153 ns** | **0.337 ns** |  **61.83 ns** |  **62.46 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.46 ns | 0.768 ns | 0.042 ns |  57.43 ns |  57.51 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  57.80 ns | 0.400 ns | 0.022 ns |  57.78 ns |  57.82 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.45 ns | 1.463 ns | 0.080 ns |  57.41 ns |  57.55 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **119.52 ns** | **5.060 ns** | **0.277 ns** | **119.21 ns** | **119.72 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 114.93 ns | 0.408 ns | 0.022 ns | 114.91 ns | 114.95 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 114.76 ns | 1.075 ns | 0.059 ns | 114.69 ns | 114.81 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 114.75 ns | 0.752 ns | 0.041 ns | 114.71 ns | 114.80 ns |      - |         - |
