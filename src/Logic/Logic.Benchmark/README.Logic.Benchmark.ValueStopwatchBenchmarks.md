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
| **Stopwatch**      | **1**      |  **61.52 ns** | **2.754 ns** | **0.151 ns** |  **61.36 ns** |  **61.66 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.500 ns | 0.027 ns |  57.11 ns |  57.16 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.15 ns** | **2.159 ns** | **0.118 ns** | **120.02 ns** | **120.23 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 0.423 ns | 0.023 ns | 113.99 ns | 114.04 ns |      - |         - |
