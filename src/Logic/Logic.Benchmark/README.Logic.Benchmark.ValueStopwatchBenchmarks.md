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
| **Stopwatch**      | **1**      |  **61.25 ns** | **2.174 ns** | **0.119 ns** |  **61.18 ns** |  **61.39 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns | 1.275 ns | 0.070 ns |  57.11 ns |  57.24 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.80 ns** | **5.122 ns** | **0.281 ns** | **119.48 ns** | **119.98 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.489 ns | 0.027 ns | 114.00 ns | 114.05 ns |      - |         - |
