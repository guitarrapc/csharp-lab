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
| **Stopwatch**      | **1**      |  **61.82 ns** | **1.773 ns** | **0.097 ns** |  **61.71 ns** |  **61.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.83 ns | 0.200 ns | 0.011 ns |  56.82 ns |  56.84 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.83 ns** | **6.527 ns** | **0.358 ns** | **119.61 ns** | **120.24 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.08 ns | 2.700 ns | 0.148 ns | 113.98 ns | 114.25 ns |      - |         - |
