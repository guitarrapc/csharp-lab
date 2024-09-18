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
| **Stopwatch**      | **1**      |  **61.51 ns** | **2.086 ns** | **0.114 ns** |  **61.44 ns** |  **61.64 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.101 ns | 0.006 ns |  57.14 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.96 ns** | **3.348 ns** | **0.184 ns** | **119.81 ns** | **120.17 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 0.288 ns | 0.016 ns | 114.00 ns | 114.03 ns |      - |         - |
