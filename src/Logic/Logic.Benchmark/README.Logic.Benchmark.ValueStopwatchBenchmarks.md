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
| **Stopwatch**      | **1**      |  **61.67 ns** | **2.023 ns** | **0.111 ns** |  **61.55 ns** |  **61.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.293 ns | 0.016 ns |  57.11 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.94 ns** | **5.145 ns** | **0.282 ns** | **119.66 ns** | **120.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.04 ns | 1.004 ns | 0.055 ns | 113.99 ns | 114.10 ns |      - |         - |
