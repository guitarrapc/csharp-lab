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
| **Stopwatch**      | **1**      |  **59.01 ns** | **1.171 ns** | **0.064 ns** |  **58.97 ns** |  **59.08 ns** |         **-** |
| ValueStopwatch | 1      |  57.43 ns | 0.923 ns | 0.051 ns |  57.38 ns |  57.48 ns |         - |
| **Stopwatch**      | **3**      | **117.59 ns** | **2.326 ns** | **0.128 ns** | **117.45 ns** | **117.70 ns** |         **-** |
| ValueStopwatch | 3      | 116.20 ns | 9.894 ns | 0.542 ns | 115.77 ns | 116.81 ns |         - |
