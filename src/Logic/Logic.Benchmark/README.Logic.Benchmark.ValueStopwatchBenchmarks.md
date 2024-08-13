```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.72 ns** | **1.748 ns** | **0.096 ns** |  **61.63 ns** |  **61.82 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.095 ns | 0.005 ns |  57.12 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.00 ns** | **4.100 ns** | **0.225 ns** | **119.74 ns** | **120.16 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.07 ns | 2.657 ns | 0.146 ns | 113.99 ns | 114.24 ns |      - |         - |
