```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.61 ns** | **2.353 ns** | **0.129 ns** |  **61.49 ns** |  **61.74 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.09 ns | 0.064 ns | 0.003 ns |  57.08 ns |  57.09 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.66 ns** | **4.756 ns** | **0.261 ns** | **119.49 ns** | **119.96 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.98 ns | 0.638 ns | 0.035 ns | 113.95 ns | 114.01 ns |      - |         - |
