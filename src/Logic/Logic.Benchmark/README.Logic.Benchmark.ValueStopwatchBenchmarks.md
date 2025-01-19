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
| **Stopwatch**      | **1**      |  **58.07 ns** | **0.576 ns** | **0.032 ns** |  **58.05 ns** |  **58.10 ns** |         **-** |
| ValueStopwatch | 1      |  57.86 ns | 0.141 ns | 0.008 ns |  57.85 ns |  57.87 ns |         - |
| **Stopwatch**      | **3**      | **117.64 ns** | **4.236 ns** | **0.232 ns** | **117.49 ns** | **117.91 ns** |         **-** |
| ValueStopwatch | 3      | 115.86 ns | 1.201 ns | 0.066 ns | 115.79 ns | 115.92 ns |         - |
