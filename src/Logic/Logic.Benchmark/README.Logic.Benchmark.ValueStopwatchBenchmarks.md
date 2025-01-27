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
| **Stopwatch**      | **1**      |  **58.75 ns** | **1.029 ns** | **0.056 ns** |  **58.71 ns** |  **58.81 ns** |         **-** |
| ValueStopwatch | 1      |  57.44 ns | 1.210 ns | 0.066 ns |  57.40 ns |  57.52 ns |         - |
| **Stopwatch**      | **3**      | **117.62 ns** | **0.561 ns** | **0.031 ns** | **117.59 ns** | **117.65 ns** |         **-** |
| ValueStopwatch | 3      | 116.21 ns | 1.910 ns | 0.105 ns | 116.11 ns | 116.32 ns |         - |
