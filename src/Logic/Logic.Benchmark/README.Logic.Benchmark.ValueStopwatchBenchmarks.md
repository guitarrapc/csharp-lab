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
| **Stopwatch**      | **1**      |  **58.09 ns** | **0.905 ns** | **0.050 ns** |  **58.05 ns** |  **58.15 ns** |         **-** |
| ValueStopwatch | 1      |  57.43 ns | 0.625 ns | 0.034 ns |  57.40 ns |  57.47 ns |         - |
| **Stopwatch**      | **3**      | **117.53 ns** | **1.171 ns** | **0.064 ns** | **117.48 ns** | **117.60 ns** |         **-** |
| ValueStopwatch | 3      | 116.32 ns | 0.290 ns | 0.016 ns | 116.30 ns | 116.33 ns |         - |
