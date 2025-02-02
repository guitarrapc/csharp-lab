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
| **Stopwatch**      | **1**      |  **58.55 ns** | **0.723 ns** | **0.040 ns** |  **58.51 ns** |  **58.59 ns** |         **-** |
| ValueStopwatch | 1      |  58.41 ns | 5.075 ns | 0.278 ns |  58.24 ns |  58.73 ns |         - |
| **Stopwatch**      | **3**      | **117.52 ns** | **0.562 ns** | **0.031 ns** | **117.49 ns** | **117.55 ns** |         **-** |
| ValueStopwatch | 3      | 116.46 ns | 0.972 ns | 0.053 ns | 116.42 ns | 116.52 ns |         - |
