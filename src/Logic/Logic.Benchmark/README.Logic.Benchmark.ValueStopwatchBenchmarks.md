```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **58.06 ns** | **0.301 ns** | **0.016 ns** |  **58.05 ns** |  **58.08 ns** |         **-** |
| ValueStopwatch | 1      |  57.87 ns | 0.505 ns | 0.028 ns |  57.85 ns |  57.90 ns |         - |
| **Stopwatch**      | **3**      | **117.64 ns** | **3.293 ns** | **0.181 ns** | **117.46 ns** | **117.82 ns** |         **-** |
| ValueStopwatch | 3      | 116.15 ns | 8.182 ns | 0.448 ns | 115.88 ns | 116.66 ns |         - |
