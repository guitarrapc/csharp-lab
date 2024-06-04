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
| **Stopwatch**      | **1**      |  **61.50 ns** | **2.659 ns** | **0.146 ns** |  **61.39 ns** |  **61.67 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.11 ns | 0.074 ns | 0.004 ns |  57.11 ns |  57.11 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.69 ns** | **5.412 ns** | **0.297 ns** | **119.52 ns** | **120.04 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.03 ns | 0.683 ns | 0.037 ns | 114.01 ns | 114.07 ns |      - |         - |
