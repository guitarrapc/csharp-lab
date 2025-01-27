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
| **Stopwatch**      | **1**      |  **58.07 ns** | **0.116 ns** | **0.006 ns** |  **58.06 ns** |  **58.07 ns** |         **-** |
| ValueStopwatch | 1      |  57.39 ns | 0.327 ns | 0.018 ns |  57.38 ns |  57.41 ns |         - |
| **Stopwatch**      | **3**      | **117.63 ns** | **0.955 ns** | **0.052 ns** | **117.57 ns** | **117.66 ns** |         **-** |
| ValueStopwatch | 3      | 116.07 ns | 6.744 ns | 0.370 ns | 115.83 ns | 116.50 ns |         - |
