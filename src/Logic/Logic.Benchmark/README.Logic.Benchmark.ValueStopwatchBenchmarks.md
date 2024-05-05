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
| **Stopwatch**      | **1**      |  **61.31 ns** | **1.139 ns** | **0.062 ns** |  **61.26 ns** |  **61.38 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.107 ns | 0.006 ns |  57.10 ns |  57.11 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.73 ns** | **4.840 ns** | **0.265 ns** | **119.55 ns** | **120.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.00 ns | 0.215 ns | 0.012 ns | 113.99 ns | 114.01 ns |      - |         - |
