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
| **Stopwatch**      | **1**      |  **61.28 ns** | **2.200 ns** | **0.121 ns** |  **61.19 ns** |  **61.42 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.143 ns | 0.008 ns |  57.11 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.75 ns** | **6.885 ns** | **0.377 ns** | **119.52 ns** | **120.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.05 ns | 1.160 ns | 0.064 ns | 113.98 ns | 114.10 ns |      - |         - |
