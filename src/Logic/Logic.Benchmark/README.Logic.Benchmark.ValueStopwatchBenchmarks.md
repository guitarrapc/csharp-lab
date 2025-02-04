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
| **Stopwatch**      | **1**      |  **58.04 ns** | **0.166 ns** | **0.009 ns** |  **58.04 ns** |  **58.05 ns** |         **-** |
| ValueStopwatch | 1      |  58.01 ns | 0.204 ns | 0.011 ns |  58.00 ns |  58.02 ns |         - |
| **Stopwatch**      | **3**      | **117.32 ns** | **2.384 ns** | **0.131 ns** | **117.24 ns** | **117.47 ns** |         **-** |
| ValueStopwatch | 3      | 115.84 ns | 0.056 ns | 0.003 ns | 115.84 ns | 115.85 ns |         - |
