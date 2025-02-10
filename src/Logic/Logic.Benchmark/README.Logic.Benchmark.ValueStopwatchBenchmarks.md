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
| **Stopwatch**      | **1**      |  **58.13 ns** | **0.941 ns** | **0.052 ns** |  **58.09 ns** |  **58.18 ns** |         **-** |
| ValueStopwatch | 1      |  58.04 ns | 0.858 ns | 0.047 ns |  58.01 ns |  58.09 ns |         - |
| **Stopwatch**      | **3**      | **117.19 ns** | **1.536 ns** | **0.084 ns** | **117.10 ns** | **117.27 ns** |         **-** |
| ValueStopwatch | 3      | 115.80 ns | 1.051 ns | 0.058 ns | 115.76 ns | 115.86 ns |         - |
