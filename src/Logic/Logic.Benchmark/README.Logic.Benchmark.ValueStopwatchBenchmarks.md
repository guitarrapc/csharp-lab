```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.37 ns** | **3.694 ns** | **0.202 ns** |  **61.15 ns** |  **61.55 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.24 ns | 3.832 ns | 0.210 ns |  57.11 ns |  57.48 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.77 ns** | **6.517 ns** | **0.357 ns** | **119.38 ns** | **120.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.72 ns | 0.267 ns | 0.015 ns | 113.70 ns | 113.73 ns |      - |         - |
