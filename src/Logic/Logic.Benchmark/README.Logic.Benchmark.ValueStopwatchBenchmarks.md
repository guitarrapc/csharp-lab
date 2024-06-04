```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.46 ns** | **2.463 ns** | **0.135 ns** |  **61.35 ns** |  **61.61 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.09 ns | 0.025 ns | 0.001 ns |  57.09 ns |  57.09 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.87 ns** | **4.134 ns** | **0.227 ns** | **119.65 ns** | **120.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.608 ns | 0.033 ns | 113.99 ns | 114.05 ns |      - |         - |
