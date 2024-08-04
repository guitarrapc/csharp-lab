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
| **Stopwatch**      | **1**      |  **61.59 ns** | **2.238 ns** | **0.123 ns** |  **61.51 ns** |  **61.73 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.07 ns | 0.051 ns | 0.003 ns |  57.07 ns |  57.07 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.97 ns** | **9.946 ns** | **0.545 ns** | **119.65 ns** | **120.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.99 ns | 0.516 ns | 0.028 ns | 113.97 ns | 114.02 ns |      - |         - |
