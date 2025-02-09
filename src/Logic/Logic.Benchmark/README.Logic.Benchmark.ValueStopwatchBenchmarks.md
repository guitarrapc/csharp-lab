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
| **Stopwatch**      | **1**      |  **58.10 ns** | **0.819 ns** | **0.045 ns** |  **58.07 ns** |  **58.15 ns** |         **-** |
| ValueStopwatch | 1      |  57.42 ns | 0.496 ns | 0.027 ns |  57.39 ns |  57.45 ns |         - |
| **Stopwatch**      | **3**      | **117.76 ns** | **3.718 ns** | **0.204 ns** | **117.60 ns** | **117.99 ns** |         **-** |
| ValueStopwatch | 3      | 116.78 ns | 0.350 ns | 0.019 ns | 116.76 ns | 116.79 ns |         - |
