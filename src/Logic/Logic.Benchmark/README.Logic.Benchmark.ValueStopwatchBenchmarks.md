```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **58.07 ns** |  **0.237 ns** | **0.013 ns** |  **58.05 ns** |  **58.08 ns** |         **-** |
| ValueStopwatch | 1      |  59.26 ns | 43.672 ns | 2.394 ns |  57.86 ns |  62.02 ns |         - |
| **Stopwatch**      | **3**      | **117.64 ns** |  **1.400 ns** | **0.077 ns** | **117.56 ns** | **117.71 ns** |         **-** |
| ValueStopwatch | 3      | 115.84 ns |  0.284 ns | 0.016 ns | 115.82 ns | 115.85 ns |         - |
