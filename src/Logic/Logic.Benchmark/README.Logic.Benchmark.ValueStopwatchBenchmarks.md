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
| **Stopwatch**      | **1**      |  **61.55 ns** | **2.369 ns** | **0.130 ns** |  **61.46 ns** |  **61.70 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.261 ns | 0.014 ns |  57.13 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.86 ns** | **4.448 ns** | **0.244 ns** | **119.69 ns** | **120.14 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.08 ns | 1.961 ns | 0.107 ns | 114.01 ns | 114.21 ns |      - |         - |
