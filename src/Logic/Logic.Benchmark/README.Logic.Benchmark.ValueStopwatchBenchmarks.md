```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.71 ns** | **1.759 ns** | **0.096 ns** |  **61.59 ns** |  **61.77 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns | 0.336 ns | 0.018 ns |  57.13 ns |  57.17 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.92 ns** | **4.379 ns** | **0.240 ns** | **119.70 ns** | **120.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.04 ns | 1.598 ns | 0.088 ns | 113.98 ns | 114.14 ns |      - |         - |
