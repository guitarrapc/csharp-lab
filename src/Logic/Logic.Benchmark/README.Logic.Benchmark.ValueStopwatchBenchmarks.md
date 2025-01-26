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
| **Stopwatch**      | **1**      |  **58.05 ns** | **0.092 ns** | **0.005 ns** |  **58.05 ns** |  **58.06 ns** |         **-** |
| ValueStopwatch | 1      |  57.40 ns | 0.674 ns | 0.037 ns |  57.37 ns |  57.44 ns |         - |
| **Stopwatch**      | **3**      | **117.46 ns** | **0.623 ns** | **0.034 ns** | **117.42 ns** | **117.49 ns** |         **-** |
| ValueStopwatch | 3      | 116.23 ns | 9.086 ns | 0.498 ns | 115.94 ns | 116.81 ns |         - |
