```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **58.43 ns** | **1.001 ns** | **0.055 ns** |  **58.39 ns** |  **58.50 ns** |         **-** |
| ValueStopwatch | 1      |  57.85 ns | 0.146 ns | 0.008 ns |  57.84 ns |  57.86 ns |         - |
| **Stopwatch**      | **3**      | **117.57 ns** | **1.387 ns** | **0.076 ns** | **117.48 ns** | **117.63 ns** |         **-** |
| ValueStopwatch | 3      | 116.37 ns | 2.290 ns | 0.126 ns | 116.25 ns | 116.50 ns |         - |
